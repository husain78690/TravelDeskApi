using System.ComponentModel.DataAnnotations;

namespace TravelDeskApi.ViewModels
{
    public class LoginViewModel
    {
             [Required]
            [EmailAddress(ErrorMessage = "Invalid email address.")]
            public string EmailId { get; set; }

            [Required]
            [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
            public string Password { get; set; }
        }
    }

