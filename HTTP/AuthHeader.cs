using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HTTP
{
    public class AuthHeader : Header
    {
        public AuthHeader(string loginCredentials) 
            : base()
        {
            // encode to base64 and return an AuthHeader
            var bytes = Encoding.UTF8.GetBytes(loginCredentials);
            var encodedCredentials = System.Convert.ToBase64String(bytes);

            Name = "Authorization";
            Value = "Basic " + encodedCredentials;
        }
    }
}
