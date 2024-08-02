namespace MovieBookingApi.Models.DTOs.TheaterDTOs
{
    public class TheaterSnackDetailsDTO
    {
        public int Id {  get; set; }
        public string SnackName { get; set; }
        public float Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
