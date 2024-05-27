using Herbzhub.Infrastructure.Interface;
using Herbzhub.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Herbzhub.Api.Controllers
{
    
    public class AuthenticationController : BaseController
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService) {
            _authenticationService = authenticationService;
        }

        [HttpPost("user-login")]
        public async Task<IActionResult> Login(AuthenticationRequest request)
        {
            var response = await _authenticationService.Login(request);
            return Ok(response);
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest request)
        {
            var response = await _authenticationService.ForgotPassword(request);
            return Ok(response);
        }


    }
}
