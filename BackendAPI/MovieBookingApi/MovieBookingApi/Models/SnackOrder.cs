namespace MovieBookingApi.Models
{
    public class SnackOrder
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public int SnackId { get; set; }
        public Snack Snack { get; set; }
    }
}
