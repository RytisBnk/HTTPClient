using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HTTP
{
    public class Response
    {
        public int StatusCode { get; private set; }
        public string StatusMessage { get; private set; }
        public List<Header> Headers { get; private set; }
        public string Body { get; private set; }
        public string HeadersText { get; private set; }

        public Response(string responseText)
        {
            var bodyPosition =  Regex.Match(responseText, "\r\n\r\n").Index + 4;
            Body = responseText.Substring(bodyPosition);

            var headerStartPosition = Regex.Match(responseText, "\r\n").Index;
            var headersText = responseText.Substring(headerStartPosition + 2, bodyPosition - 4 - headerStartPosition);
            HeadersText = headersText;

            List<Header> headers = new List<Header>();
            while (headersText.Length > 2)
            {
                var columnPosition = Regex.Match(headersText, ":").Index;
                var headerName = headersText.Substring(0, columnPosition);

                var endLinePosition = Regex.Match(headersText, "\r\n").Index;
                var headerValue = headersText.Substring(columnPosition + 2, endLinePosition - 2 - columnPosition);

                var header = new Header(headerName, headerValue);
                headers.Add(header);

                headersText = headersText.Substring(endLinePosition + 2);
            }
            Headers = headers;

            var statusCodeStartPosition = Regex.Match(responseText, "[0-9]{3}").Index;
            var statusCodeEndPosition = Regex.Match(responseText, "\r\n").Index;
            StatusCode = int.Parse(responseText.Substring(statusCodeStartPosition, 3));

            GetStatusMessage();
        }

        private void GetStatusMessage()
        {

        }
    }
}
