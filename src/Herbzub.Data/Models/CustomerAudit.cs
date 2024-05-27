using System.ComponentModel.DataAnnotations.Schema;

namespace Herbzhub.Data.Models
{
    public class CustomerAudit
    {
        public CustomerAudit()
        {
            UpdatedAt = DateTime.UtcNow;
        }
        [Column("CustomerAuditId")]
        public int Id { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public bool AccountVerified { get; set; } = false;
        public DateTime? LastOrderDate { get; set; }
        public DateTime UpdatedAt { get; set; }


    }


}
