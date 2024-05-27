namespace Herbzhub.Models.Request
{
    public record UserDetails
    {
        public string Username { get; set; }
        public ResentPasswordRequest PasswordDetails {  get; set; }
    }
}
    