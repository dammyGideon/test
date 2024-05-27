using Herbzhub.Models.Request;
using Mailjet.Client;
using Mailjet.Client.TransactionalEmails;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbzhub.Infrastructure.Services
{
    public class EmailServices
    {
        private readonly IConfiguration _configuration;
        public EmailServices(IConfiguration configuration) {
            _configuration = configuration;
        }

        public async Task<bool> SendEmail (EmailSendDtoRequest request)
        {
            var client = new MailjetClient(_configuration["MailJet:ApiKey"], _configuration["MailJet:SecretKey"]);
            var email = new TransactionalEmailBuilder()
                    .WithFrom(new SendContact(_configuration[""]))
                    .WithSubject(request.Subject)
                    .WithHtmlPart(request.Body)
                    .WithTo(new SendContact(request.To))
                    .Build();

            var response = await client.SendTransactionalEmailAsync(email);
            if(response.Messages != null)
            {
                if (response.Messages[0].Status == "success")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
