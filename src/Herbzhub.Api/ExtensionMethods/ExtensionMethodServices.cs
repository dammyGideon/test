using Herbzhub.Data;
using Herbzhub.Infrastructure.Helper;
using Herbzhub.Infrastructure.Interface;
using Herbzhub.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Herbzhub.Api.ExtensionMethods
{
    public static class ExtensionMethodServices
    {
        public static void AddDbContextService(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<DbApplicationContext>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });

        }
        public static void AddAuthenticationService(this IServiceCollection services,IConfiguration configuration)
        {
            // Configure JWT authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration.GetValue<string>("JwtCredentials:Issuer"),
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetValue<string>("JwtCredentials:Secret")))
                };
            });
        }
        

        public static void AddCorService(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });
        }
    
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICountiesService, CountiesServices>();
            services.AddScoped<ILoggerManager, LoggerManager>();
            services.AddTransient<CreateTokenService>();
            services.AddScoped<IAuthenticationService,AuthenticationService>();
            services.AddScoped<IManufacturerService,ManufacturerService>();
            services.AddScoped<EmailService>();
        }

        public static void AddCustomConfiguration(this IConfigurationBuilder builder, IHostEnvironment env)
        {
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                   .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                   .AddEnvironmentVariables();
        }
    }
}
