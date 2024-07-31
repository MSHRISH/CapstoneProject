using System.ComponentModel.DataAnnotations;

namespace MovieBookingApi.Models.DTOs.TheaterDTOs
{
    public class AddScreenDTO
    {
        [Required(ErrorMessage = "TheaterId is required.")]
        public int TheaterId { get; set; }
        [Required(ErrorMessage = "Screen name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Screen name must be between 1 and 100 characters.")]
        public string ScreenName { get; set; }

        [Required(ErrorMessage = "Schema ID is required.")]
        public int SchemaId { get; set; }
    }
}
