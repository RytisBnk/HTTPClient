using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTTP;
using System.Text.RegularExpressions;

namespace HTTPClient
{
    public partial class RequestForm : Form
    {
        public string Data { get; set; }
        public List<Header> Headers { get; set; }

        public string Credentials { get; set; }

        private Response _response;
        private string _rawResponse;
        private string _hostName;
        private string _resource;
        private Request _currentRequest;
        private Request _previousRequest;

        public RequestForm()
        {
            InitializeComponent();
            StatusCodes.GetStatusCodesList();
        }

        private void button_showBody_Click(object sender, EventArgs e)
        {
            if (_response != null)
            {
                richTextBox1.Text = _response.Body;
            }      
        }

        private void button_showHeaders_Click(object sender, EventArgs e)
        {
            if (_response != null)
            {
                richTextBox1.Text = _response.HeadersText;
            }           
        }

        private void button_showRawView_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _rawResponse;
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            _currentRequest = BuildHttpRequest();

            var httpConnection = new Connection(_hostName, 80);
            _rawResponse = httpConnection.ExecuteRequest(_currentRequest);

            _response = new Response(_rawResponse);
            richTextBox1.Text = _response.Body;

            ClearAfterSend();
        }

        private void button_addHeaders_Click(object sender, EventArgs e)
        {
            var headersForm = new HeadersForm(this);
            headersForm.Show();
        }

        private void button_addBody_Click(object sender, EventArgs e)
        {
            var requestBodyForm = new BodyForm(this);
            requestBodyForm.Show();
        }

        private void button_viewRequest_Click(object sender, EventArgs e)
        {
            _currentRequest = BuildHttpRequest();
            var requestViewForm = new RequestCodeForm(_currentRequest);
            requestViewForm.Show();
        }

        private void ClearAfterSend()
        {
            _previousRequest = _currentRequest;
            Data = null;
            Headers = null;
            Credentials = null;
            _currentRequest = null;
        }

        private Request BuildHttpRequest()
        {
            var methodName = method_selector.SelectedItem.ToString();
            var method = MethodResolver.Resolve(methodName);

            var hostNameEndPos = Regex.Match(address_bar.Text, "/").Index;

            _hostName = address_bar.Text.Substring(0, hostNameEndPos);
            _resource = address_bar.Text.Substring(hostNameEndPos, address_bar.Text.Length - hostNameEndPos);

            var httpRequest = new Request(method, _hostName, _resource);
            if (Data != null)
            {
                httpRequest.Body = Data;
                Header contentLength = new Header("Content-Length", Data.Length.ToString());
                if (Headers != null)
                {
                    var zeroContentHeader = Headers.Where(h => h.Name == "Content-Length" && h.Value == "0");
                    if (!Headers.Exists(h => h.Name == "Content-Length"))
                    {
                        Headers.Add(contentLength);
                    }
                    else if (zeroContentHeader.Any())
                    {
                        Headers.Remove(zeroContentHeader.First());
                        Headers.Add(contentLength);
                    }
                }
                else
                {
                    Headers = new List<Header>
                    {
                        contentLength
                    };
                }
            }
            else
            {
                if (Headers != null)
                {
                    if (!Headers.Exists(h => h.Name == "Content-Length"))
                    {
                        Headers.Add(new Header("Content-Length", "0"));
                    }
                }
                else
                {
                    Headers = new List<Header>()
                    {
                        new Header("Content-Length", "0")
                    };
                }
            }
            
            if (Credentials != null)
            {
                var authHeader = new AuthHeader(Credentials);
                var existingHeader = Headers.Where(h => h.Name == "Authorization");
                if (!existingHeader.Any())
                {
                    Headers.Add(authHeader);
                }
                else 
                {
                    Headers.Remove(existingHeader.First());
                    Headers.Add(authHeader);
                }
            }

            httpRequest.Headers = Headers;

            return httpRequest;
        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            var authForm = new AuthenticationForm(this);
            authForm.Show();
        }

        private void button_viewPrevious_Click(object sender, EventArgs e)
        {
            var requestViewForm = new RequestCodeForm(_previousRequest);
            requestViewForm.Show();
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _response.StatusCode + "\r\n" + _response.StatusMessage;
        }
    }
}
