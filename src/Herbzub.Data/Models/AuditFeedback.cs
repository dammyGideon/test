using System.ComponentModel.DataAnnotations;

namespace Herbzhub.Data.Models
{
    public partial class AuditFeedback
    {
        [Key]
        public int Id { get; set; }
        public int DispensaryId { get; set; }
        public Dispensary Dispensary { get; set; }
        public string? LastInspectionDate { get; set; }
        public DateTime UpdateAt { get; set; } = DateTime.UtcNow;
        public string? ComplianceAuditLog { get; set; }
        public string? CustomerFeedback { get; set; }
        public double? CustomerSatisfactionIndex { get; set; }
        public double? AverageRating { get; set; }

    }
}
