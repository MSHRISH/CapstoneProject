using System.ComponentModel.DataAnnotations;

namespace MovieBookingApi.Models.DTOs.MovieDTOs
{
    public class AddArtistDTO
    {
        [Required(ErrorMessage = "Artist name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Artist name must be between 1 and 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "About the Artist is required.")]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "About must be between 1 and 1000 characters.")]
        public string About { get; set; }
    }
}
