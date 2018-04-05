using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTP
{
    public class Request
    {
        public Method Method { get; set; }
        public string HostName { get; set; }
        public string Resource { get; set; }
        public List<Header> Headers { get; set; }
        public string Body { get; set; }

        private readonly string _protocolVersion = "HTTP/1.1";

        public Request(Method method, string hostName, string resource)
        {
            Method = method;
            HostName = hostName;
            Resource = resource;
        }

        public Request(Method method, string hostName, string resource, string body) 
            : this(method, hostName, resource)
        {
            SetBody(body);
        }

        public Request(Method method, string hostName, string resource, List<Header> headers)
            : this(method, hostName, resource)
        {
            SetHeaders(headers);
        }

        public Request(Method method, string hostName, string resource, List<Header> headers, string body)
            : this(method, hostName, resource)
        {
            SetBody(body);
            SetHeaders(headers);
        }

        private void SetHeaders(List<Header> headers) { Headers = headers; }
        private void SetBody(string body) { Body = body; }

        private void AppendHeaders(StringBuilder requestString)
        {
            if (Headers != null)
            {
                foreach (var header in Headers)
                {
                    requestString.Append(header.Name + ": " + header.Value + "\r\n");
                }
                requestString.Append("\r\n");
            }
            else
            {
                requestString.Append("\r\n");
            }
        }

        public override string ToString()
        {
            var requestString = new StringBuilder(Method + " " + Resource + " " + _protocolVersion + "\r\n");
            requestString.Append("Host: " + HostName + "\r\n");
            AppendHeaders(requestString);
            requestString.Append(Body);

            return requestString.ToString();
        }
    }
}
