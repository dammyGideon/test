using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbzhub.Models.Request
{
    public class AuthenticationRequest
    {
        public string Email {  get; set; }
        public string Password { get; set; }
    }
}
