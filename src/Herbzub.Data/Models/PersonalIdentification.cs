using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Herbzhub.Data.Models
{
    public class PersonalIdentification : BaseEntity
    {
        [ForeignKey("AuthenticationEntity")]
        public int AuthenticationEntityId { get; set; }
        public User AuthenticationEntity { get; set; }

        [Required(ErrorMessage = "First Name Field is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Field is required")]
        public string LastName { get; set; }

        public string? MiddleName { get; set; }
        [Required(ErrorMessage = "Date of Birth Field is required")]
        public DateOnly DateOfBirth { get; set; }

        public string? Gender { get; set; }
        
        [Required(ErrorMessage ="Identificaion Field is Required")]
        public string IDentificationIdUpload { get; set; }

        public string? social_security_number { get; set; }


        public PersonalIdentification()
        {
            DateOfBirth = DateOnly.MinValue; // Initialize DateOfBirth with a default value
        }


    }
}
