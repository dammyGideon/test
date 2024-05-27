using System.ComponentModel.DataAnnotations.Schema;

namespace Herbzhub.Data.Models
{
    public class CustomerPreferencesNotes : BaseEntity
    {
        // Preferences
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string? ProductPreferences { get; set; } // e.g., vegan, organic products
        public string? LifestylePreferences { get; set; }
        public string? AdditionalNotes { get; set; }
    }
}
