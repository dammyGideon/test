using Microsoft.AspNetCore.Http;

namespace Herbzhub.Models.Request
{
    public record UploadRequest
    {
        public IFormFile File { get; set; }
    }
}
    