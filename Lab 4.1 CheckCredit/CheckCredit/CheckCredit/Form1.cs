using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckCredit
{
    public partial class CheckCredit : Form
    {
        public CheckCredit()
        {
            InitializeComponent();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            int credit = Convert.ToInt32(creditBox.Text);
            if (credit > 8000)
            {
                label.Text = $"Error, Credit Declined";
            }
            else
            {
                label.Text = $"Approved";
            }
        }
    }
}
