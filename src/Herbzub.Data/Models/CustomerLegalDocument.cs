using System.ComponentModel.DataAnnotations;

namespace Herbzhub.Data.Models
{
    public class CustomerLegalDocument : BaseEntity
    {
        public CustomerLegalDocument()
        {
            Customer = new Customer();
        }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required(ErrorMessage = "Id Proof Field is Required")]
        public byte[] IdProof { get; set; }
        [Required(ErrorMessage = "Medical Marijuana Card Field is Required")]
        public byte[] MedicalMarijuanaCard { get; set; }

        public byte[]? Prescription { get; set; }
        [Required(ErrorMessage = "Government Id Number Field is Required")]
        public string GovernmentIdNumber { get; set; }
        [Required(ErrorMessage = "Government Id Type Field is Required")]
        public string GovernmentIdType { get; set; } // Column(String, nullable = False)  # e.g., Passport, Driver’s License
        [Required(ErrorMessage = "Government Id Proof is Required")]
        public byte[] GovernmentIdProof { get; set; }
    }
}
