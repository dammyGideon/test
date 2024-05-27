namespace Herbzhub.Models.Request
{
    public record BusinessDetails
    {
        public string BusinessName { get; set; }
        public string BusinessType { get; set; }
        public string OwnName { get; set; }
        public string OwnerContact { get; set; }
        public string NumberOfEmployees { get; set; }
        public string BusinessRegistrationNumber { get; set; }

        public string AnnualRevenue {get;set;}
    }
}
    