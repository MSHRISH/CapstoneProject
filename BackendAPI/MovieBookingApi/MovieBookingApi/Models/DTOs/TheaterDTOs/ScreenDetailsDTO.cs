namespace MovieBookingApi.Models.DTOs.TheaterDTOs
{
    public class ScreenDetailsDTO
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public string ScreenName { get; set; }
        public int SchemaId { get; set; }
    }
}
