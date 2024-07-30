using MovieBookingApi.Context;
using MovieBookingApi.Execptions;
using MovieBookingApi.Iterfaces;
using MovieBookingApi.Migrations;
using MovieBookingApi.Models;
using MovieBookingApi.Models.DTOs.BookingDTOs;
using MovieBookingApi.Models.DTOs.TheaterDTOs;
using MovieBookingApi.Models.TheaterModels;
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

        public BookingServices(IRepository<int,Show> showRepository,IRepository<int,Screen> screenRepository,
                IRepository<int,Booking> bookingRepository, IRepository<int,Schema> schemaRepository, 
                IRepository<int,ScreenLayout> screenLayoutRepository, IRepository<int,Ticket> ticketRepository,
                IRepository<int,Snack> SnackRepository, MovieBookingContext dbContext,
                IRepository<int,SnackOrder> snackOrderRepository)
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
            if (!CheckShowTime(show.Date, show.ShowTime))
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
                        bookTicketsDTO.Snacks.Add(new BookSnackDTO { SnackID = filteredSnack.Id, Quantity = 1 });
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
        private bool CheckShowTime(DateTime dateTime, TimeSpan timeSpan)
        {
            // Get current date and time
            DateTime now = DateTime.Now;
            DateTime showDateTime = dateTime.Date.Add(timeSpan);
            if (now > showDateTime || (showDateTime - now).TotalMinutes <= 10)
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
                IsAvailable = !bookedSeatIds.Contains(s.Id)
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


            return MapBookingToDTO(booking, seatPositions, snackDetails);
        }
        private BookingDetailsDTO MapBookingToDTO(Booking booking, List<string> seatPositions,List<SnackDetailDTO> snackDetails)
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
                Snacks = snackDetails
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
            booking.PaymentStatus = true;
            booking=await _BookingRepository.Update(booking);
            if (booking == null)
            {
                throw new PaymentFailedExecption();
            }
            return await ViewBooking(bookingId, userId, false);
        }

        public async Task<BookingDetailsDTO> DeleteBooking(int bookingId)
        {
            var booking = await ViewBooking(bookingId, 0, true);           
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

        public async Task<List<BookingDetailsDTO>> GetAllBookings(int page,int userId,bool admin)
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
            var pagedBookings = bookings.Skip((page - 1) * 5).Take(5).ToList();
            
            var bookingDTOs = new List<BookingDetailsDTO>();
            for(int i = 0; i < pagedBookings.Count(); i++)
            {
                var bookingDTO=await ViewBooking(pagedBookings[i].Id, 0,true);
                bookingDTOs.Add(bookingDTO);
            }
            return bookingDTOs;

        }
    }
}
