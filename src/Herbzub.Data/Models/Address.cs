namespace Herbzhub.Data.Models
{
    public class Address : BaseEntity
    {
        public int PersonalIdentificationId { get; set; }
        public PersonalIdentification PersonalIdentification { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
      

        public int StateId { get; set; }
        public State State { get; set; }

        public string ZipCode { get; set; }
        public int CountiesId { get; set; }
        public Counties Counties { get; set; }

    }
}
