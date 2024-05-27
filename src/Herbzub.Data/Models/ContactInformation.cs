using System.ComponentModel.DataAnnotations.Schema;

namespace Herbzhub.Data.Models
{
    public partial class ContactInformation : BaseEntity
    {
        [ForeignKey("Dispensary")]
        public int DispensaryId { get; set; }
        public Dispensary Dispensary { get; set; }
        public string BusinessAddress { get; set; }
        public string BusinessCity { get; set; }
        public string BusinessState { get; set; }
        public string BusinessZipCode { get; set; }
        public string Country { get; set; }
        public string BusinessPhone { get; set; }
        public string BusinessEmail { get; set; }
        public string OperatingHour { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? SocialMediaProfiles { get; set; }


    }

}
