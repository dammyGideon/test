using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Herbzhub.Infrastructure.Services
{
    public class CreateTokenService
    {
        private readonly IConfiguration _configuration;

        public CreateTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> CreateToken(string userId, string email, IEnumerable<string> roles)
        {
            var secret = _configuration["JwtCredentials:Secret"];
            var signCredentials = GetSigningCredentials(secret);
            var claims = GetClaims(userId, email, roles);

            var tokenOptions = new JwtSecurityToken(
                issuer: _configuration["JwtCredentials:Issuer"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["JwtCredentials:Expiring-Date"])),
                signingCredentials: signCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        private SigningCredentials GetSigningCredentials(string secretKey)
        {
            var key = Encoding.UTF8.GetBytes(secretKey);
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private List<Claim> GetClaims(string userId, string email, IEnumerable<string> roles)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userId),
                new Claim(ClaimTypes.Email, email),
            };

            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            return claims;
        }
    }
}
