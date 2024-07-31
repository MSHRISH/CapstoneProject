using MovieBookingApi.Models.DTOs.BookingDTOs;
using MovieBookingApi.Models.DTOs.MovieDTOs;
using MovieBookingApi.Models.DTOs.TheaterDTOs;

namespace MovieBookingApi.Iterfaces
{
    public interface IBookingServices
    {
        //Add A Show
        public Task<ShowDetailsDTO> AddShow(AddShowDTO addShowDTO);

        //Get All ScreensInTheater
        public Task<List<AllScreensMiniDTO>> GetAllScreensList();

        //Get All Movies in DB
        public Task<List<AllmoviesMiniDTO>> GetAllMoviesList();

        //Get all Seats in a Show with vacancy
        public Task<ScreenLayoutDTO> GetScreenLayout(int showId);

        //book a seat(s)
        public Task<BookingDetailsDTO> BookTickets(BookTicketsDTO bookTicketsDTO,int userId);

        //Check Discount eligibility of a user
        public Task<bool> DiscountEligibility(int userId);

        //View a Booking
        public Task<BookingDetailsDTO> ViewBooking(int bookingId,int userId,bool isAdmin);

        //Update Payment
        public Task<BookingDetailsDTO> PayForBooking(int bookingId,int userId);

        //Delete Booking
        public Task<BookingDetailsDTO> DeleteBooking(int bookingId, int userId, bool admin);

        //GetAll Bookings
        public Task<List<BookingDetailsDTO>> GetAllBookings(int page, int userId, bool admin);

        //Get Movies from a District that are running i.e ShowDateTime greater than CurrentDateTime
        public Task<List<MovieDetailDTO>> GetRunningMovies(string district);
        
        //Get Running Dates of a Movie
        public Task<List<DateTime>> GetRunningDatesOfMovie(int movieId,string dostrict);




        //Get Shows Grouped by Theaters for a Movie in a Date
        public Task<Dictionary<string, List<ShowDetailsDTO>>> GetShowsByDateForMovie(int movieId, DateTime date,string district);
    }
}
