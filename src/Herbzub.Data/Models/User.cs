using System.ComponentModel.DataAnnotations;

namespace Herbzhub.Data.Models
{
    public class User : BaseEntity
    {
        [Required(ErrorMessage = "Username Field is required")]
        [MaxLength(200, ErrorMessage = "Maximum length for the Name is ^0 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email Field is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Field is required")]
        [MinLength(6, ErrorMessage = "Maximum length should be greater than 6")]
        public string HashPassword { get; set; }
        [Required(ErrorMessage = "Mobile Number Field is required")]
        public string MobileNumber { get; set; }

        public string? PasswordResetToken { get; set; }
        public DateTime? ResetTokenExpiry { get; set; }


        public bool IsMFAEnabled { get; set; } // Indicates if MFA is enabled for the user

        public SMSVerificationCode SMSVerificationCodes {  get; set; }
        public PersonalIdentification personalIdentifications {  get; set; }
        public ICollection<Dispensary> Dispensary {  get; set; }
        public ICollection<UserRole> UserRole { get; set; }
    }
}

