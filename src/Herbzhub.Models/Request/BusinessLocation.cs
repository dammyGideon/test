namespace Herbzhub.Models.Request
{
    public record BusinessLocation
    {
        public string BusinessAddress { get; set; }
        public string BusinessCity {  get; set; }
        public string BusinessState {  get; set; }
        public string BusinessCountry { get; set; }
        public string BusinessPostalCode { get; set;}
        public string BusinessPhoneNumber {  get; set; }
        public string BusinessEmail {get; set; }
        public string? WebsiteUrl {  get; set; }
        public string? SocialMedialUrl {  get; set; }
        
    }
}
    