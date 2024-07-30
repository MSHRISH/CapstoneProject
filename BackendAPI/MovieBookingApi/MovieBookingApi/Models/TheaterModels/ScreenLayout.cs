namespace MovieBookingApi.Models.TheaterModels
{
    public class ScreenLayout
    {
        public int Id { get; set; }
        public int SchemaId { get; set; }
        public Schema Schema { get; set; }
        public int Row { get; set; }
        public int Column { get; set; } 
        public bool IsSeat { get; set; }
        public float Price { get; set; }
    }
}