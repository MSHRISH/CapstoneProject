namespace MovieBookingApi.Models.DTOs.TheaterDTOs
{
    public class TheaterDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string District { get; set; }

        public List<ScreenDetailsDTO> screenDetails { get; set; }
    }
}
