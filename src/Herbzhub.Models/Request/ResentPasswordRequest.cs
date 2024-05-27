namespace Herbzhub.Models.Request
{
    public record ResentPasswordRequest
    {
        public string Password {  get; set; }   
        public string Email { get; set; }
        public string Token {  get; set; } 
        public string ComfirmPassword {  get; set; }
    }
}
    