using System.ComponentModel.DataAnnotations;

namespace Herbzhub.Data.Models
{
    public class DriverVehicleInformation : BaseEntity
    {
        [Required(ErrorMessage = "Vehicle Make is required")]
        public string VehicleMake { get; set; }

        public int DriverId {  get; set; }
        public Driver Driver {  get; set; }

        [Required(ErrorMessage = "Vehicle Model is required")]
        public string VehicleModel { get; set; }

        [Required(ErrorMessage = "Vehicle Year is required")]
        public int VehicleYear { get; set; }

        [Required(ErrorMessage = "Vehicle License Plate is required")]
        public string VehicleLicensePlate { get; set; }

        [Required(ErrorMessage = "Vehicle Registration Number is required")]
        public string VehicleRegistrationNumber { get; set; }

        [Required(ErrorMessage = "Vehicle Color is required")]
        public string VehicleColor { get; set; }

        [Required(ErrorMessage = "Vehicle Insurance Provider is required")]
        public string VehicleInsuranceProvider { get; set; }

        [Required(ErrorMessage = "Vehicle Insurance Expiry Date is required")]
        public DateTime VehicleInsuranceExpiryDate { get; set; }

        [Required(ErrorMessage = "Insurance Policy Number is required")]
        public string InsurancePolicyNumber { get; set; }
    }
}
