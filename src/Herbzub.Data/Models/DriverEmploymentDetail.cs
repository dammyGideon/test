using System.ComponentModel.DataAnnotations;

namespace Herbzhub.Data.Models
{
    public class DriverEmploymentDetail : BaseEntity
    {
        [Required(ErrorMessage = "Employment Status is required")]
        public string EmploymentStatus { get; set; }

        [Required(ErrorMessage = "Hire Date is required")]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "Employee ID is required")]
        //[UniqueEmployeeID(ErrorMessage = "Employee ID must be unique")]
        public string EmployeeID { get; set; }

        [Required(ErrorMessage = "Employment Contract Type is required")]
        public string EmploymentContractType { get; set; }

        [Required(ErrorMessage = "Background Check Status is required")]
        public string BackgroundCheckStatus { get; set; }

        [Required(ErrorMessage = "Health Clearance Status is required")]
        public string HealthClearanceStatus { get; set; }

        public string TrainingRecords { get; set; }

        [Required(ErrorMessage = "Delivery Zone is required")]
        public string DeliveryZone { get; set; }

        public string AvailableHours { get; set; }
    }
}
