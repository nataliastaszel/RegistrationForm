using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace RegistrationForm.Models;

public class RegistrationData
{
    [Required]
    [MinLength(2)]
    public string FirstName { get; set; }

    [Required]
    [MinLength(2)]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$",
        ErrorMessage = "The password must contain at least one uppercase letter, one lowercase letter and one number")]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }

    [Phone]
    public string? PhoneNumber { get; set; }

    [Range(10, 80)]
    public int? Age { get; set; }

    public string? City { get; set; }
}