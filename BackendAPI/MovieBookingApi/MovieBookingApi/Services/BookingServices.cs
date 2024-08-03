using MovieBookingApi.Context;
using MovieBookingApi.Execptions;
using MovieBookingApi.Iterfaces;

using MovieBookingApi.Models;
using MovieBookingApi.Models.DTOs.BookingDTOs;
using MovieBookingApi.Models.DTOs.MovieDTOs;
using MovieBookingApi.Models.DTOs.TheaterDTOs;
using MovieBookingApi.Models.MovieModels;
using MovieBookingApi.Models.TheaterModels;
using MovieBookingApi.Repositories;
using System.Drawing.Printing;

namespace MovieBookingApi.Services
{
    public class BookingServices:IBookingServices
    {
        private readonly IRepository<int, Show> _showRepository;
        private readonly IRepository<int, Screen> _screenRepository;
        private readonly IRepository<int, Booking> _BookingRepository;
        private readonly IRepository<int, Schema> _schemaRepository;
        private readonly IRepository<int, ScreenLayout> _screenLayoutRepository;
        private readonly IRepository<int, Ticket> _ticketRepository;
        private readonly IRepository<int, Snack> _snackRepository;
        private readonly MovieBookingContext _dbContext;
        private readonly IRepository<int, SnackOrder> _snackOrderRepository;
        private readonly IRepository<int, Movie> _movieRepository;
        private readonly IRepository<int, Theater> _theaterRepository;
        private readonly IRepository<int, Language> _languageRepository;
        private readonly IRepository<int, Format> _formatRepository;
        private readonly IRepository<int, Certification> _certificationRepository;

        public BookingServices(IRepository<int,Show> showRepository,IRepository<int,Screen> screenRepository,
                IRepository<int,Booking> bookingRepository, IRepository<int,Schema> schemaRepository, 
                IRepository<int,ScreenLayout> screenLayoutRepository, IRepository<int,Ticket> ticketRepository,
                IRepository<int,Snack> SnackRepository, MovieBookingContext dbContext,
                IRepository<int,SnackOrder> snackOrderRepository, IRepository<int,Movie> movieRepository,
                IRepository<int,Theater> theaterRepository, IRepository<int,Language> languageRepository,
                IRepository<int,Format> formatRepository, IRepository<int,Certification> certificationRepository)
        {
            _showRepository = showRepository;
            _screenRepository= screenRepository;
            _BookingRepository= bookingRepository;
            _schemaRepository= schemaRepository;
            _screenLayoutRepository= screenLayoutRepository;
            _ticketRepository= ticketRepository;
            _snackRepository=SnackRepository;
            _dbContext= dbContext;
            _snackOrderRepository= snackOrderRepository;
            _movieRepository= movieRepository;
            _theaterRepository= theaterRepository;
            _languageRepository= languageRepository;
            _formatRepository= formatRepository;
            _certificationRepository= certificationRepository;
        }

        public async Task<BookingDetailsDTO> BookTickets(BookTicketsDTO bookTicketsDTO,int userId)
        {
            if (bookTicketsDTO.SeatsBooked.Count() > 5 || bookTicketsDTO.SeatsBooked.Count()==0)
            {
                throw new BookingLimitExecption();
            }
            //Check if show is valid
            var show = await _showRepository.Get(bookTicketsDTO.ShowId);
            if (show == null)
            {
                throw new ShowNotFoundExecption();
            }
           
            if (!CheckShowTime(show.ShowDateTime))
            {
                throw new BookingClosedExecption();
            }

            //Check if the SeatIds are valid
            var screen = await _screenRepository.Get(show.ScreenId);
            var screenLayouts = await _screenLayoutRepository.GetAll();
            var screenLayout = screenLayouts.Where(sl => sl.SchemaId == screen.SchemaId).ToList();

            var validRowIds = screenLayout.Select(sl => sl.Id).ToHashSet();
            bool allValid = bookTicketsDTO.SeatsBooked.All(seatId => validRowIds.Contains(seatId));
            if (!allValid)
            {
                throw new NoSuchSeatsExecption();
            }

            //Get the Bookings of the show
            var bookings = await _BookingRepository.GetAll();
            var filteredBookings = bookings.Where(b => b.ShowId == bookTicketsDTO.ShowId).ToList();

            //Get the Tickets related to the bookings
            var tickets = await _ticketRepository.GetAll();
            var filteredTickets = tickets.Where(t => filteredBookings.Any(b => b.Id == t.BookingId)).ToList();

            //Check if the desired seats are already booked
            var alreadyBookedSeats = bookTicketsDTO.SeatsBooked.Where(seatId => filteredTickets.Any(t => t.SeatId == seatId)).ToList();

            if(alreadyBookedSeats.Any())
            {
                throw new SeatNotAvailableExecption();
            }
            //Check Eligibility for discounts
            if(bookTicketsDTO.AvailDiscount == true && bookTicketsDTO.AvailSnack == true)
            {
                throw new DiscountNotElgibleExecption();
            }
            if(bookTicketsDTO.AvailDiscount==true || bookTicketsDTO.AvailSnack == true)
            {
                if(!await DiscountEligibility(userId))
                {
                    throw new DiscountNotElgibleExecption();
                }
            }


            //Check Snacks Availability
            if(bookTicketsDTO.Snacks.Count() != 0)
            {
                if (! await SnackAvailability(bookTicketsDTO.Snacks))
                {
                    throw new SnackUnavailableExecption();
                }
                if(HasZeroQuantity(bookTicketsDTO.Snacks))
                {
                    throw new EmptySnackValuesExecption();
                }
            }
           
            //Make Booking
            using (var transaction = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    //Ticket Amount Calculation
                    float ticketAmount = 0;
                    for (int i = 0; i < bookTicketsDTO.SeatsBooked.Count(); i++)
                    {
                        var seat = screenLayout.FirstOrDefault(sl => sl.Id == bookTicketsDTO.SeatsBooked[i]);
                        ticketAmount += seat.Price;
                    }

                    //Snack Amount Calculation
                    float snackAmount = 0;
                    for (int i = 0; i < bookTicketsDTO.Snacks.Count(); i++)
                    {
                        var snack = await _snackRepository.Get(bookTicketsDTO.Snacks[i].SnackID);
                        snackAmount += snack.Price*bookTicketsDTO.Snacks[i].Quantity;
                    }
                    //BillAmount
                    float billAmount = ticketAmount + snackAmount;
                    //TotalAmount
                    float totalAmount = billAmount;
                    //Discount
                    float discount = 0;
                    if (bookTicketsDTO.AvailDiscount == true)
                    {
                        discount = 10;
                        totalAmount = billAmount * (1 - discount / 100.0f);
                    }
                    


                    //Make Booking
                    var newBooking = new Booking
                    {
                        ShowId = bookTicketsDTO.ShowId,
                        UserId = userId,
                        TicketAmount = ticketAmount,
                        SnackAmount = snackAmount,
                        BillAmount = billAmount,
                        Discount = discount,
                        TotalAmount = totalAmount,
                        PaymentStatus = false,
                        BookedOn = DateTime.Now
                    };
                    newBooking = await _BookingRepository.Add(newBooking);

                    //Book Tickets
                    for (int i = 0; i < bookTicketsDTO.SeatsBooked.Count(); i++)
                    {
                       var newTicket=new Ticket { BookingId=newBooking.Id, SeatId = bookTicketsDTO.SeatsBooked[i] };
                        newTicket = await _ticketRepository.Add(newTicket);
                    }

                    //Snack Discount
                    if(bookTicketsDTO.AvailSnack == true)
                    {
                        var snacks = await _snackRepository.GetAll();
                        var filteredSnack = snacks.Where(s => s.TheaterId == screen.TheaterId).FirstOrDefault(s => s.Name.Contains("Popcorn", StringComparison.OrdinalIgnoreCase));
                        if(filteredSnack == null)
                        {
                            throw new DiscountNotElgibleExecption();
                        }
                        var alreadyPresent = false;
                        for (int i = 0;i < bookTicketsDTO.Snacks.Count();i++)
                        {
                            if (bookTicketsDTO.Snacks[i].SnackID == filteredSnack.Id)
                            {
                                alreadyPresent = true;
                                bookTicketsDTO.Snacks[i].Quantity += 1;
                            }
                        }
                        if (!alreadyPresent)
                        {
                            bookTicketsDTO.Snacks.Add(new BookSnackDTO { SnackID = filteredSnack.Id, Quantity = 1 });
                        }
                        
                    }
                    


                    //Book Snacks
                    for (int i = 0; i < bookTicketsDTO.Snacks.Count(); i++)
                    {
                       var newSnackOrder=new SnackOrder { BookingId=newBooking.Id, SnackId = bookTicketsDTO.Snacks[i].SnackID, Quantity = bookTicketsDTO.Snacks[i].Quantity };
                        newSnackOrder=await _snackOrderRepository.Add(newSnackOrder);
                    }

                    await _dbContext.SaveChangesAsync();
                    // Commit the transaction
                    await transaction.CommitAsync();

                    return await ViewBooking(newBooking.Id,userId,false);
                }
                catch (Exception ex)
                {
                    // Roll back the transaction
                    await transaction.RollbackAsync();
                    throw new BookingExecption();
                }
            }

        }
        private bool CheckShowTime(DateTime dateTime)
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan timeDifference = dateTime - currentTime;

            // Return false if current time is within 10 minutes of the given datetime or past the datetime
            if (timeDifference.TotalMinutes <= 10 || timeDifference.TotalMinutes < 0)
            {
                return false;
            }

            return true;
        }
        private bool HasZeroQuantity(List<BookSnackDTO> snackLists)
        {
            bool hasZeroQuantity = snackLists.Any(snack => snack.Quantity == 0); 
            return hasZeroQuantity; 
        }
        private async Task<bool> SnackAvailability(List<BookSnackDTO> snacks)
        {
            var snackIds = snacks.Select(snack => snack.SnackID).ToList();
            var allSnacks = await _snackRepository.GetAll();
            bool allAvailable = snackIds.All(id => allSnacks.Any(s => s.Id == id && s.IsAvailable));
            return allAvailable;
        }
        public async Task<bool> DiscountEligibility(int userId)
        {
            DateTime oneWeekAgo = DateTime.UtcNow.AddDays(-7);
            var bookings = await _BookingRepository.GetAll();
            int bookingCount=bookings.Where(b => b.UserId == userId && b.BookedOn >= oneWeekAgo).Count();

            return bookingCount > 3;
        }

        //Get LAyout of Screen
        public async Task<ScreenLayoutDTO> GetScreenLayout(int showId)
        {
            var show = await _showRepository.Get(showId);
            if(show == null)
            {
                throw new ShowNotFoundExecption();
            }
            var screen=await _screenRepository.Get(show.ScreenId);
            var schema= await _schemaRepository.Get(screen.SchemaId);

            var screenlayouts = await _screenLayoutRepository.GetAll();
            var filteredScreenLayout=screenlayouts.Where(s => s.SchemaId == screen.SchemaId).ToList();

            var bookings=await _BookingRepository.GetAll();
            var filteredBookings=bookings.Where(b => b.ShowId == showId).ToList();

            var tickets= await _ticketRepository.GetAll();
            var filteredTickets = tickets.Where(t => filteredBookings.Any(b => b.Id == t.BookingId)).ToList();
            var bookedSeatIds = filteredTickets.Select(t => t.SeatId).ToHashSet();

            //Create DTO
            var seatDTOs = filteredScreenLayout.Select(s => new SeatDTO
            {
                id = s.Id,
                Row = s.Row,
                Column = s.Column,
                Price = s.Price,
                IsAvailable = !bookedSeatIds.Contains(s.Id),
                 IsSeat=s.IsSeat
                
            }).OrderBy(seat => seat.Row)
              .ThenBy(seat => seat.Column)
              .ToList();

            return new ScreenLayoutDTO { RowDimension = schema.RowDimension, ColumnDimension = schema.ColumnDimension, Seats = seatDTOs };
        }

        public async Task<BookingDetailsDTO> ViewBooking(int bookingId, int userId, bool isAdmin)
        {
            var booking=await _BookingRepository.Get(bookingId);
            if(booking == null)
            {
                throw new NoSuchBookingFoundExecption();
            }
            if(!isAdmin)
            {
                if(booking.UserId != userId)
                {
                    throw new NoSuchBookingFoundExecption();
                }
            }

            //Getting Seat Positions
            var tickets = (await _ticketRepository.GetAll()).Where(t => t.BookingId==bookingId).ToList();
            var show=await _showRepository.Get(booking.ShowId);
            var screen=await _screenRepository.Get(show.ScreenId);
            var theater = await _theaterRepository.Get(screen.TheaterId);
            var movie=await _movieRepository.Get(show.MovieId);
            var language=await _languageRepository.Get(movie.LanguageId);
            var certification = await _certificationRepository.Get(movie.CertificateId);
            var format = await _formatRepository.Get(movie.FormatId);

            var screenLayout=(await _screenLayoutRepository.GetAll()).Where(sl => sl.SchemaId==screen.SchemaId);

            var seatPositions = (from ticket in tickets
                                 join layout in screenLayout
                                 on ticket.SeatId equals layout.Id
                                 select ConvertToSeatPosition(layout.Row,layout.Column)).ToList();

            //Getting Snacks
            var snacks = await _snackRepository.GetAll();
            var snackOrders=(await _snackOrderRepository.GetAll()).Where(so => so.BookingId == bookingId);

            var snackDetails = (from snack in snacks
                                join snackOrder in snackOrders
                                on snack.Id equals snackOrder.SnackId
                                select new SnackDetailDTO { SnackName = snack.Name, Quantity = snackOrder.Quantity }).ToList();


            return MapBookingToDTO(booking, seatPositions, snackDetails, screen, movie, theater,show,format,certification,language);
        }
        private BookingDetailsDTO MapBookingToDTO(Booking booking, List<string> seatPositions,List<SnackDetailDTO> snackDetails, 
                                                    Screen screen, Movie movie, Theater theater,Show show,Format format,
                                                    Certification certification,Language language)
        {
            var bookingDetailsDTO = new BookingDetailsDTO
            {
                BookingId = booking.Id,
                BookedBy = booking.UserId,
                TicketAmount = booking.TicketAmount,
                SnackAmount = booking.SnackAmount,
                BillAmount = booking.BillAmount,
                BookedOn = booking.BookedOn,
                Discount = booking.Discount,
                PaymentStatus = booking.PaymentStatus,
                TotalAmount = booking.TotalAmount,
                BookedSeats = seatPositions,
                Snacks = snackDetails,
                MovieName=movie.Title,
                ScreenName=screen.ScreenName,
                TheaterName=theater.Name,
                 ShowDateTime=show.ShowDateTime,
                  Format=format.FormatName,
                   Language=language.LanguageName,
                    Certification=certification.CertificateType
            };
            return bookingDetailsDTO;
        }
        //Function to Convert Seat position to Readable Format
        private string ConvertToSeatPosition(int row, int column)
        {
              
            string rowLetter = string.Empty;
            while (row > 0)
            {
                row--;

                rowLetter = (char)('A' + (row % 26)) + rowLetter;
               row /= 26;
            }

            return $"{rowLetter}{column}";
        }


        //Payment Update Service
        public async Task<BookingDetailsDTO> PayForBooking(int bookingId, int userId)
        {
            var booking = await _BookingRepository.Get(bookingId);
            if (booking == null || booking.UserId != userId)
            {
                throw new NoSuchBookingFoundExecption();
            }
            if (booking.PaymentStatus)
            {
                throw new AlreadyPaymentDoneExecption();
            }
            booking.PaymentStatus = true;
            booking=await _BookingRepository.Update(booking);
            if (booking == null)
            {
                throw new PaymentFailedExecption();
            }
            return await ViewBooking(bookingId, userId, false);
        }

        //Delete Booking
        public async Task<BookingDetailsDTO> DeleteBooking(int bookingId,int userId,bool admin)
        {
            var booking = await ViewBooking(bookingId, userId, admin);           
            if(booking.PaymentStatus)
            {
                throw new DeleteFailedExecption();
            }
            var delBooking=await _BookingRepository.Delete(bookingId);
            if (delBooking == null)
            {
                throw new DeleteFailedExecption();
            }
            return booking;
        }

        public async Task<List<BookingDetailsDTO>> GetAllBookings(int userId,bool admin)
        {
            var bookings=await _BookingRepository.GetAll();
            if (!admin)
            {
                bookings = bookings.Where(b => b.UserId == userId);
            }
            if (bookings.Count() == 0)
            {
                throw new NoBookingsFound();
            }
            var bookingslist = bookings.OrderByDescending(b => b.BookedOn).ToList();
            var bookingDTOs = new List<BookingDetailsDTO>();
            for(int i = 0; i < bookingslist.Count(); i++)
            {
                var bookingDTO=await ViewBooking(bookingslist[i].Id, 0,true);
                bookingDTOs.Add(bookingDTO);
            }
            return bookingDTOs;

        }

        public async Task<ShowDetailsDTO> AddShow(AddShowDTO addShowDTO)
        {
            if (!IsShowTimeValid(addShowDTO))
            {
                throw new ImporperShowTimeExecption();
            }
            var screen = await _screenRepository.Get(addShowDTO.ScreenId);
            if (screen == null)
            {
                throw new NoSuchScreenFoundExecption();
            }
            var movie=await _movieRepository.Get(addShowDTO.MovieId);
            if(movie == null)
            {
                throw new MovieNotFoundExecption();
            }
            var allShows = await _showRepository.GetAll();
            allShows=allShows.Where(s => s.ScreenId == screen.Id);
            //Conflict Detection
            var movieDuration = TimeSpan.FromMinutes(movie.Duration);
            var minimumTimeDifference = movieDuration + TimeSpan.FromMinutes(30);
            foreach (var currentshow in allShows)
            {
                // Assuming show.StartTime and show.EndTime are of type TimeSpan
                var showEndTime = currentshow.ShowDateTime+ movieDuration;

                if ((addShowDTO.ShowDateTime >= currentshow.ShowDateTime && addShowDTO.ShowDateTime< showEndTime) ||
                    (addShowDTO.ShowDateTime+ movieDuration > currentshow.ShowDateTime && addShowDTO.ShowDateTime+ movieDuration <= showEndTime))
                {
                    throw new ShowTimeTooCloseException();
                }

                // Check minimum time difference
                if (Math.Abs((addShowDTO.ShowDateTime- currentshow.ShowDateTime).TotalMinutes) < minimumTimeDifference.TotalMinutes)
                {
                    throw new ShowTimeTooCloseException();
                }
            }

            var show= new Show { ScreenId=addShowDTO.ScreenId, MovieId=addShowDTO.MovieId, ShowDateTime =addShowDTO.ShowDateTime};
            show=await _showRepository.Add(show);
            if(show == null)
            {
                throw new RegistrationFailedExecption();
            }
            return new ShowDetailsDTO
            {
                ID = show.Id,
                MovieId = show.MovieId,
                ScreenId = screen.Id,
                 ShowDateTime=show.ShowDateTime
            };
        }
        private bool IsShowTimeValid(AddShowDTO addShowDTO)
        {
            DateTime currentTime = DateTime.Now;
            DateTime showDateTime = addShowDTO.ShowDateTime;
            TimeSpan timeDifference = showDateTime - currentTime;

            // Return false if ShowDateTime is in the past or within 30 minutes from now
            if (timeDifference.TotalMinutes <= 30 || timeDifference.TotalMinutes < 0)
            {
                return false;
            }

            return true;
        }

        public async Task<List<DateTime>> GetRunningDatesOfMovie(int movieId,string district)
        {
            var movie=await _movieRepository.Get(movieId);
            if (movie == null)
            {
                throw new MovieNotFoundExecption();
            }
            var shows = await _showRepository.GetAll();
            var theaters = await _theaterRepository.GetAll();
            var screens = await _screenRepository.GetAll();

            var districtTheaterIds = theaters.Where(t => t.District == district)
                                      .Select(t => t.Id)
                                      .ToList();
            var districtScreenIds = screens.Where(sc => districtTheaterIds.Contains(sc.TheaterId))
                                    .Select(sc => sc.Id)
                                    .ToList();


            var runningDates = shows.Where(s => s.MovieId == movieId && districtScreenIds.Contains(s.ScreenId))
                            .Select(s => s.ShowDateTime.Date)
                            .Distinct()
                            .OrderBy(d => d)
                            .ToList();
            return runningDates;
        }

        public async Task<Dictionary<string, List<ShowDetailsDTO>>> GetShowsByDateForMovie(int movieId, DateTime date,string district)
        {
            var movie = await _movieRepository.Get(movieId);
            if (movie == null)
            {
                throw new MovieNotFoundExecption();
            }

            var shows = await _showRepository.GetAll();
            var theaters = await _theaterRepository.GetAll();
            var screens = await _screenRepository.GetAll(); // Assuming you have a repository for screens

            // Filter shows by movie ID and the specified date
            var filteredShows = shows.Where(s => s.MovieId == movieId && s.ShowDateTime.Date == date.Date).ToList();

            // Create a dictionary to store shows grouped by theater
            var showsGroupedByTheater = new Dictionary<string, List<ShowDetailsDTO>>();

            // Group shows by screen ID, which is assumed to map to a theater
            foreach (var group in filteredShows.GroupBy(s => s.ScreenId))
            {
                var screen = screens.FirstOrDefault(sc => sc.Id == group.Key);
                
                var theater = theaters.FirstOrDefault(t => t.Id == screen.TheaterId && t.District == district);
                if (theater != null)
                {
                    var theaterDetails = new TheaterDetailsDTO
                    {
                        Id = theater.Id,
                        Name = theater.Name,
                        Phone = theater.Phone,
                        Address = theater.Address,
                        District = theater.District
                    };

                    var showDetailsList = group.Select(s => new ShowDetailsDTO
                    {
                        ID = s.Id,
                        ScreenId = s.ScreenId,
                        ScreenName = screen.ScreenName,
                        MovieId = s.MovieId,
                        ShowDateTime = s.ShowDateTime
                    }).ToList();

                    showsGroupedByTheater[theater.Name] = showDetailsList;
                }

            }
            if (!showsGroupedByTheater.Any())
            {
                throw new NoShowsFoundException();
            }

            return showsGroupedByTheater;
        }

        public async Task<List<MovieDetailDTO>> GetRunningMovies(string district)
        {
            var shows = await _showRepository.GetAll();
            var theaters = await _theaterRepository.GetAll();
            var movies = await _movieRepository.GetAll();
            var screens = await _screenRepository.GetAll(); // Assuming you have a repository for screens
            var currentDateTime = DateTime.Now;

            // Get theater IDs in the specified district
            var districtTheaterIds = theaters.Where(t => t.District == district)
                                             .Select(t => t.Id)
                                             .ToList();

            // Get screen IDs in the specified district
            var districtScreenIds = screens.Where(sc => districtTheaterIds.Contains(sc.TheaterId))
                                           .Select(sc => sc.Id)
                                           .ToList();

            // Filter shows based on district and ShowDateTime greater than current date and time
            var filteredShows = shows.Where(s => s.ShowDateTime > currentDateTime && districtScreenIds.Contains(s.ScreenId))
                                     .ToList();

            // Get distinct movie IDs from filtered shows
            var movieIds = filteredShows.Select(s => s.MovieId).Distinct().ToList();

            // Get details of these movies
            var runningMovies = movies.Where(m => movieIds.Contains(m.Id))
                                      .Select(m => new MovieDetailDTO
                                      {
                                          Id = m.Id,
                                          Title = m.Title,
                                          PosterUrl = m.PosterUrl,
                                      }).ToList();

            return runningMovies;

        }


        //Helper Services
        public async Task<List<AllScreensMiniDTO>> GetAllScreensList()
        {
            var screens=await _screenRepository.GetAll();
            var theaters=await _theaterRepository.GetAll();

            var res = (from screen in screens
                      join theater in theaters
                      on screen.TheaterId equals theater.Id
                      select new AllScreensMiniDTO { ScreenId = screen.Id, ScreenName = screen.ScreenName, TheaterName = theater.Name }).ToList();
            return res;
        }

        public async Task<List<AllmoviesMiniDTO>> GetAllMoviesList()
        {
            var movie=await _movieRepository.GetAll();
            var res = movie.Select(m => new AllmoviesMiniDTO { MovieId = m.Id, MovieName = m.Title, ReleaseDate = m.RealeaseDate }).ToList();
            return res;
        }
    }
}
