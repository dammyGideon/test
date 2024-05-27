namespace Herbzhub.Models.Request
{
    public record AddressRequest
    {
        public string streetAddress { get; set; }
        public string usersCity { get; set; }
        public int usersState { get; set; }
        public string userZipCode { get; set; }
        public int countiesId { get; set; }
    }
}
    