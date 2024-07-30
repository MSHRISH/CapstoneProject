using MovieBookingApi.Models.TheaterModels;

namespace MovieBookingApi.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public int SeatId { get; set; }
        public ScreenLayout Seat { get; set; }
    }
}
