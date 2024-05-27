using System.ComponentModel.DataAnnotations;

namespace Herbzhub.Data.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;



    }
}
