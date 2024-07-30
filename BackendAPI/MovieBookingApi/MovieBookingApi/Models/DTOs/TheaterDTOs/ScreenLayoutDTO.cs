using MovieBookingApi.Models.TheaterModels;

namespace MovieBookingApi.Models.DTOs.TheaterDTOs
{
    public class ScreenLayoutDTO
    {
        public int RowDimension { get; set; }
        public int ColumnDimension { get; set; }
        public ICollection<SeatDTO> Seats { get; set; }
    }
}
