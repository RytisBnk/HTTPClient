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
    public partial class BodyForm : Form
    {
        private RequestForm _requestForm;

        public BodyForm(RequestForm requestForm)
        {
            InitializeComponent();
            _requestForm = requestForm;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            _requestForm.Data = body_text.Text;

            Close();
        }
    }
}
