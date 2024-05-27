using Herbzhub.Data;
using Herbzhub.Infrastructure.Helper;
using Herbzhub.Infrastructure.Interface;
using Herbzhub.Models.Request;
using Herbzhub.Models.Response;
using Microsoft.EntityFrameworkCore;


namespace Herbzhub.Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly DbApplicationContext _context;
        private readonly ILoggerManager _loggerManager;
        private readonly CreateTokenService _createTokenService;
        private readonly EmailService _emailService;


        public AuthenticationService(DbApplicationContext context,ILoggerManager loggerManager, 
            CreateTokenService createTokenService, EmailService emailService)
        {
            _context = context;
            _loggerManager = loggerManager;
            _createTokenService = createTokenService;
            _emailService = emailService;
        }

        public async Task<BaseResponse<GenericNameResponse>> ForgotPassword(ForgotPasswordRequest request)
        {
            if (string.IsNullOrEmpty(request.Email))
            {
                _loggerManager.LogError("Invalid Email");
                return new BaseResponse<GenericNameResponse>
                {
                    Success = false,
                    Message = "Invalid Email"
                };
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
            {
                _loggerManager.LogError("This Email Address has not been registered yet");
                return new BaseResponse<GenericNameResponse>
                {
                    Success = false,
                    Message = "This Email Address has not been registered yet"
                };
            }

            // Generate reset token (this is a simple example, you might want to use more secure token generation)
            var resetToken = Guid.NewGuid().ToString();

            // Save the reset token and the expiration date to the user's record
            user.PasswordResetToken = resetToken;
            user.ResetTokenExpiry = DateTime.UtcNow.AddHours(1); // Token valid for 1 hour
            await _context.SaveChangesAsync();

            // Send the reset email
            await _emailService.SendResentAsync(user.Email, user.Username, resetToken);

            return new BaseResponse<GenericNameResponse>
            {
                Success = true,
                Message = "Password reset email sent successfully."
            };
        }

        public async Task<BaseResponse<GenericNameResponse>> ResetPassword(ResentPasswordRequest request) {
            if (string.IsNullOrEmpty(request.Email)) throw new ArgumentNullException("Email does not Exist");
            var user = await _context.Users.FirstOrDefaultAsync(d => d.Email == request.Email);
            if (user == null) throw new ArgumentNullException("");

            throw new Exception();
        
        }
        public async Task<BaseResponse<AuthResponses>> Login(AuthenticationRequest request)
        {
            var userExist = await _context.Users.
                Include(u=>u.UserRole).
                ThenInclude(u=>u.Role).
                FirstOrDefaultAsync(d=>d.Email == request.Email);
            if (userExist == null) _loggerManager.LogError($"This User Does Not Exist");

            var passwordMatch = PasswordHandler.VerifyPassword(request.Password, userExist.HashPassword);
            if (!passwordMatch) _loggerManager.LogError($"Password And UserName Wrong");

            var roles = userExist.UserRole.Select(ur => ur.Role.RoleName);
            var tokenResponse = await _createTokenService.CreateToken(userExist.Id.ToString(), userExist.Email, roles);

            AuthResponses response = new()
            {
                Token = tokenResponse,
            };
            return new BaseResponse<AuthResponses>
            {
                Success =true,
                Message="Login Successful",
                Data = response
            };

        }
    
        
    }
}
