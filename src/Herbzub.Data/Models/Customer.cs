using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Herbzhub.Data.Models
{
    public class Customer
    {
        [Column("CustomerId")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Secondary Email is Required")]
        public string SecondaryEmail { get; set; }
        [Required(ErrorMessage = "Home Phone number is Required")]
        public string HomePhone { get; set; }
        [Required(ErrorMessage = "Work Phone number is Required")]
        public string WorkPhone { get; set; }
        [Required(ErrorMessage = "Emergency Contact is Required")]
        public string EmergencyContact { get; set; }
        [Required(ErrorMessage = "Emergency Contact Phone is Required")]
        public string EmergencyContactPhone { get; set; }

        public virtual CustomerMedicalInformation MedicalInformation { get; set; }

        // Other navigation properties
        public virtual CustomerLegalDocument CustomerLegalDocuments { get; set; }
        public virtual CustomerPreferencesNotes CustomerPreferencesNotes { get; set; }
        public virtual CustomerAudit CustomerAudit { get; set; }




    }

}