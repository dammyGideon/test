namespace Herbzhub.Data.Models
{
    public partial class SecurityMeasures : BaseEntity
    {
        public int DispensaryId { get; set; }
        public Dispensary Dispensary {  get; set; }
        public string? SecurityMeasuresDetails { get; set; }
        public string? EmergencyResponsePlan {  get; set; }
        public string? HealthSafetyRecords { get; set; }
    
    }
}
