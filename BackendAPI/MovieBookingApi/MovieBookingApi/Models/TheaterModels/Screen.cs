namespace MovieBookingApi.Models.TheaterModels
{
    public class Screen
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public Theater Theater { get; set; }
        public string ScreenName { get; set; }
        
        public int SchemaId { get; set; }
        public Schema Schema { get; set; }
        public ICollection<Show> Shows { get; set; }
    }
}
