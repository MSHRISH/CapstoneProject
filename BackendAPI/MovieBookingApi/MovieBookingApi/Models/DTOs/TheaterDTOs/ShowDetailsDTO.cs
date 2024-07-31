using System.ComponentModel.DataAnnotations;

namespace MovieBookingApi.Models.DTOs.TheaterDTOs
{
    public class ShowDetailsDTO
    {
        public int ID { get; set; } 
        public int ScreenId { get; set; }
        public string ScreenName { get; set; }
        public int MovieId { get; set; }
        public DateTime ShowDateTime { get; set; }
       
    }
}
