namespace Herbzhub.Data.Models
{
    public class Dispensary : BaseEntity
    {
        public int UserId {  get; set; }
        public User User { get; set; }
        public string FederalLicenseNumber {  get; set; }
        public string StateLicenseNumber { get; set; }
        public DateOnly LicenseExpiryDate {  get; set; }
        public string? ComplianceStatus { get; set; }
        public string? EnvironmentalComplianceStatus { get; set; }
        public string LincenseUpload {  get; set; }

        //Business Details 
        public string BusinessName {  get; set; }
        public string BusinessType { get; set; }
        public string OwnerName {get; set;}
        public string OwnerContact {get; set;}
        public string NumberOfEmployees { get; set; }
        public string BusinessRegistrationNumber {  get; set; }
        public string? AnnualRevenue {  get; set; }
        public string? OperatingHours { get; set; }

        public bool DeliveryServiceAvailable { get; set; } 
        public virtual ContactInformation  ContactInformation {  get; set; }
        public virtual InventoryManagement InventoryManagement {  get; set; }
        public virtual FinancialInformation FinancialInformation { get; set;}
        public virtual AuditFeedback AuditFeedback {  get; set; }

        public virtual SecurityMeasures SecurityMeasures { get; set; }
    }


}
