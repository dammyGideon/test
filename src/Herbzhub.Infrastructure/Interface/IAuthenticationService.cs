using Herbzhub.Infrastructure.Helper;
using Herbzhub.Models.Request;
using Herbzhub.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbzhub.Infrastructure.Interface
{
    public interface IAuthenticationService
    {
        Task<BaseResponse<AuthResponses>> Login(AuthenticationRequest request);
        Task<BaseResponse<GenericNameResponse>> ForgotPassword(ForgotPasswordRequest request);
    }
}
