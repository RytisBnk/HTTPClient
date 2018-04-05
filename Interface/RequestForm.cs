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

namespace HTTPClient
{
    public partial class RequestForm : Form
    {
        private Response _response;
        private string _rawResponse;

        public RequestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var httpRequest = new Request(Method.GET, "httpbin.org", "/get")
            {
                Headers = new List<Header>()
                {
                    new Header("Content-Length", "0")
                }
            };

            var httpConnection = new Connection("httpbin.org", 80);
            var rawResponse = httpConnection.ExecuteRequest(httpRequest);
            _rawResponse = rawResponse;

            var response = new Response(rawResponse);
            _response = response;

            richTextBox1.Text = response.Body;
        }

        private void RequestTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_showBody_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _response.Body;
        }

        private void button_showHeaders_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _response.HeadersText;
        }

        private void button_showRawView_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _rawResponse;
        }
    }
}
