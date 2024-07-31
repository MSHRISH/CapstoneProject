using MovieBookingApi.Models.MovieModels;
using System.ComponentModel.DataAnnotations;

namespace MovieBookingApi.Models.DTOs.TheaterDTOs
{
    public class AddShowDTO
    {
        [Required]
        public int ScreenId { get; set; }
        [Required]
        public int MovieId { get; set; }

        [Required]
        public DateTime ShowDateTime { get; set; }

    }
}   
