using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTTP;

namespace HTTPClient
{
    public partial class RequestCodeForm : Form
    {
        public RequestCodeForm(Request request)
        {
            InitializeComponent();
            if (request != null)
            {
                request_text.Text = request.ToString();
            }        
        }
    }
}
