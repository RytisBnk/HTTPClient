using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HTTP;

namespace HTTPClient
{
    public partial class HeadersForm : Form
    {
        private RequestForm _requestForm;

        public HeadersForm(RequestForm requestForm)
        {
            InitializeComponent();
            _requestForm = requestForm;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var headerText = headers_textbox.Text;

            List<Header> headers = new List<Header>();
            while (headerText.Length > 1)
            {
                var columnPosition = Regex.Match(headerText, ":").Index;
                var headerName = headerText.Substring(0, columnPosition);

                var endLinePosition = Regex.Match(headerText, "\n").Index;
                var headerValue = headerText.Substring(columnPosition + 2, endLinePosition - 2 - columnPosition);

                var header = new Header(headerName, headerValue);
                headers.Add(header);

                headerText = headerText.Substring(endLinePosition + 1);
            }
            if (_requestForm.Headers == null)
            {
                _requestForm.Headers = headers;
            }
            else
            {
                _requestForm.Headers.AddRange(headers);
            }

            Close();
        }
    }
}
