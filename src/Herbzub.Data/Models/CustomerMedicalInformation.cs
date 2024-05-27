using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Herbzhub.Data.Models
{
    public class CustomerMedicalInformation
    {

        [Column("CustomerMedicalInformationId")]
        public int Id { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }  // Foreign key
        public Customer Customer { get; set; }  // Navigation property to Customer

        // Other properties
        [Required(ErrorMessage = "Patient Id Field is Required")]
        public string PatientId { get; set; }
        [Required(ErrorMessage = "Medical condition Field is Required")]
        public string MedicalCondition { get; set; }
        public string? Allergies { get; set; }
        public string? CurrentMedication { get; set; }
        [Required(ErrorMessage = "Doctor Name Field is Required")]

        public string DoctorName { get; set; }
        [Required(ErrorMessage = "Doctor Contact Field is required")]
        public string? DoctorContact { get; set; }
        public string? PrimaryCarePhysician { get; set; }
        public string? PhysicianContact { get; set; }
        public string? TreatmentHistory { get; set; }
        public string? KnownHealthIssues { get; set; }
        [Required(ErrorMessage = "Medical Marijuana card number Field is required")]
        public string MedicalMarijuanaCardNumber { get; set; }
        [Required(ErrorMessage = "Card Expiration Date Field  is Required")]
        public DateTime CardExpirationDate { get; set; }
    }
}
