using Herbzhub.Infrastructure.Interface;
using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbzhub.Infrastructure.Helper
{
    public class EmailService
    {
        public IConfiguration _configuration;
        private readonly ILoggerManager _loggerManager;
        private readonly IWebHostEnvironment _env;
        public EmailService(IConfiguration configuration, ILoggerManager loggerManager,IWebHostEnvironment env) {
            _configuration = configuration;
            _loggerManager = loggerManager;
            _env = env;
        }


        public async Task SendResentAsync(string email, string userName, string resetToken)
        {
            try
            {
                var apiKey = _configuration["MailJet:ApiKey"];
                var secretKey = _configuration["MailJet:SecretKey"];
                var fromEmail = _configuration["Email:From"];
                var applicationName = _configuration["Email:ApplicationName"];
                var resetPasswordPath = _configuration["Email:ResetPasswordPath"];

                // Validate configuration values
                if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(secretKey))
                {
                    _loggerManager.LogError("MailJet API keys are not configured properly.");
                    throw new Exception("MailJet API keys are missing.");
                }
                if (string.IsNullOrEmpty(fromEmail) || string.IsNullOrEmpty(applicationName) || string.IsNullOrEmpty(resetPasswordPath))
                {
                    _loggerManager.LogError("Email configuration values are missing.");
                    throw new Exception("Email configuration values are missing.");
                }

                MailjetClient client = new MailjetClient(apiKey, secretKey);

                string resetUrl = $"https://your-domain.com/{resetPasswordPath}?token={resetToken}";
                var templatePath = Path.Combine(_env.ContentRootPath, "Resource", "ForgetPasswordTemplate.html");

                if (!File.Exists(templatePath))
                {
                    _loggerManager.LogError($"Email template not found: {templatePath}");
                    throw new FileNotFoundException("Email template not found", templatePath);
                }

                string emailBody = await File.ReadAllTextAsync(templatePath);
                emailBody = emailBody.Replace("[User Name]", userName)
                                     .Replace("[link-to-your-password-reset-page]", resetUrl);

                MailjetRequest request = new MailjetRequest
                {
                    Resource = Send.Resource,
                }
                .Property(Send.FromEmail, fromEmail)
                .Property(Send.FromName, applicationName)
                .Property(Send.Subject, "Reset Your Password")
                .Property(Send.HtmlPart, emailBody)
                .Property(Send.Recipients, new JArray {
                     new JObject {
                            {"Email", email }
                        }
                });

                MailjetResponse response = await client.PostAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    _loggerManager.LogError($"Failed to send email: {response.StatusCode} - {response.GetErrorMessage()}");
                    throw new Exception($"Failed to send password reset email: {response.StatusCode} - {response.GetErrorMessage()}");
                }
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Exception in SendResentAsync: {ex.Message}");
                throw;
            }
        }



    }
}
