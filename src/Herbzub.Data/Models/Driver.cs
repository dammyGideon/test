using System.ComponentModel.DataAnnotations;

namespace Herbzhub.Data.Models
{
    public class Driver : BaseEntity
    {
        [Required(ErrorMessage = "License Number is required")]
        [MaxLength(100, ErrorMessage = "Maximum length for the License Number is 100 characters")]
        //[UniqueLicenseNumber(ErrorMessage = "License Number must be unique")]
        public string LicenseNumber { get; set; }
        public DateOnly LicenseExpiryDate { get; set; }

        [Required(ErrorMessage = "License State is required")]
        public string LicenseState { get; set; }

        public string? DrivingCertification { get; set; }

        public ICollection<DriverVehicleInformation> DriverVehicleInformation { get;set;}

    }

   
}
