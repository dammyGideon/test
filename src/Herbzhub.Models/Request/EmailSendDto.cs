using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbzhub.Models.Request
{
    public class EmailSendDtoRequest
    {
        public EmailSendDtoRequest(string to,string subject ,string body) {
            To = to;
            Subject = subject;
            Body = body;
        }

        public string To { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
    }
}
