using Herbzhub.Infrastructure.Helper;
using Herbzhub.Models.Request;
using Herbzhub.Models.Response;
using Microsoft.AspNetCore.Http;

namespace Herbzhub.Infrastructure.Interface
{
    public interface IManufacturerService
    {
        Task<BaseResponse<string>> CreateManufacturer(ManufactureRequest request);

    }

   
}
