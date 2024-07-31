using System.ComponentModel.DataAnnotations;

namespace MovieBookingApi.Models.DTOs.TheaterDTOs
{
    public class AddTheaterDTO
    {
        [Required(ErrorMessage = "Theater name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Theater name must be between 1 and 100 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name can only contain letters and spaces")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Address must be between 5 and 200 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "District is required.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "District must be between 1 and 50 characters.")]
        public string District { get; set; }
    }
}
