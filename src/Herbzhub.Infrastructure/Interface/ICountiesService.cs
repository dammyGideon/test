using Herbzhub.Infrastructure.Helper;
using Herbzhub.Models.Response;

namespace Herbzhub.Infrastructure.Interface
{
    public interface ICountiesService
    {
        Task<BaseResponse<List<GenericNameResponse>>> GetCounties();
        Task<BaseResponse<List<GenericNameResponse>>> State();
        Task<BaseResponse<List<GenericNameResponse>>> RoleType();
    }
}
