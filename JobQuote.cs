using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSemesterProject
{
    public partial class JobQuote : Form
    {
        public JobQuote()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TxtCustomerAddress.Text = Form1.ValueForTextAddressOutput;
            this.TxtQuoteAddress.AutoSize = true;
            TxtQuoteAddress.Text = Form1.ValueForTextJobQuote;
        }
    }
}
