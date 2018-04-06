using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTPClient
{
    public partial class AuthenticationForm : Form
    {
        private RequestForm _requestForm;

        public AuthenticationForm(RequestForm requestForm)
        {
            InitializeComponent();
            _requestForm = requestForm;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            _requestForm.Credentials = textbox_username.Text + ":" + textbox_password.Text;

            Close();
        }
    }
}
