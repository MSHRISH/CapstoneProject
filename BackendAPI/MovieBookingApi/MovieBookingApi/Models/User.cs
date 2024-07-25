namespace MovieBookingApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public UserAuth UserAuth { get; set; }
    }
}
