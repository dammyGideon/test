namespace Herbzhub.Models.Request
{
    public record ChangePasswordRequest
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
    