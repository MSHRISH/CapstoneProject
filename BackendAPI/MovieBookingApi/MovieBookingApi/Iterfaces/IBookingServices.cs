using MovieBookingApi.Models.DTOs.BookingDTOs;
using MovieBookingApi.Models.DTOs.TheaterDTOs;

namespace MovieBookingApi.Iterfaces
{
    public interface IBookingServices
    {
        //Get all Seats in a Show with vacancy
        public Task<ScreenLayoutDTO> GetScreenLayout(int showId);

        //book a seat(s)
        public Task<BookingDetailsDTO> BookTickets(BookTicketsDTO bookTicketsDTO,int userId);

        //Check Discount eligibility of a user
        public Task<bool> DiscountEligibility(int userId);

        //View a Booking
        public Task<BookingDetailsDTO> ViewBooking(int bookingId,int userId);
    }
}
