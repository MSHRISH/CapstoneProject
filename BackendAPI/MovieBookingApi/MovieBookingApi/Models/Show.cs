namespace MovieBookingApi.Models
{
    public class Show
    {
        public int Id { get; set; }
        public int ScreenId { get; set; }
        public Screen Screen { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan ShowTime { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
