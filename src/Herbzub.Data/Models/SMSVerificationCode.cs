using System.ComponentModel.DataAnnotations.Schema;

namespace Herbzhub.Data.Models
{
    public class SMSVerificationCode : BaseEntity
    {
        [ForeignKey("AuthenticationEntity")]
        public int AuthenticationEntityId {  get; set; }
        public User authenticationEntity { get; set; }

        public string phone_number { get; set; }
        public string verification_code { get; set; }

     
    }
}
