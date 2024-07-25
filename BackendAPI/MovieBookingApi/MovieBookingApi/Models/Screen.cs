namespace MovieBookingApi.Models
{
    public class Screen
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public Theater Theater { get; set; }
        public string ScreenName { get; set; }
        public int DimensionRow { get; set; }
        public int DimensionColumn { get; set; }
        public int SeatingCapacity { get; set; }

        public ICollection<ScreenSchema> ScreenSchemas { get; set; }
        public ICollection<Show> Shows { get; set; }
    }
}
