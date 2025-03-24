using System.ComponentModel.DataAnnotations;

namespace Logic.Models
{
    public class RegistrationRequestModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public required string Username { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public required string FirstName { get; set; }
        public string? LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public required string Password { get; set; }
    }
}