using Microsoft.AspNetCore.Http;

namespace Herbzhub.Models.Request
{
    public record LicensingRequest
    {
      public string FederalLicense {  get; set; }
      public string StateLicense {  get; set; }
      public DateOnly ExpiringDate { get; set; }

      public IFormFile UploadLicense { get; set; }
    }
}
    