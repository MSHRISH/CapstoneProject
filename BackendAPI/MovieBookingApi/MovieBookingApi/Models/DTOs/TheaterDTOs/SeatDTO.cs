using MovieBookingApi.Models.TheaterModels;

namespace MovieBookingApi.Models.DTOs.TheaterDTOs
{
    public class SeatDTO
    {
        public int id { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsSeat { get; set; }
        public float Price { get; set; }

        public bool IsAvailable { get; set; }

    }
}
