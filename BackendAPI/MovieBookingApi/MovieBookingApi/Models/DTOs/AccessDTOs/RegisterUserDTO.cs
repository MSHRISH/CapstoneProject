using System.ComponentModel.DataAnnotations;

namespace MovieBookingApi.Models.DTOs.AccessDTOs
{
    public class RegisterUserDTO
    {
        [Required(ErrorMessage ="Name is required")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name can only contain letters and spaces")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Theater name must be between 1 and 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
