using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenville_CH4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int thisYearRevenue = Convert.ToInt32(thisYearBox.Text) * 25,
                lastYearRevenue = Convert.ToInt32(lastYearBox.Text) * 25;

            string formatThisYear = thisYearRevenue.ToString("C"),
                   formatLastYear = lastYearRevenue.ToString("C");

            int thisYearContestants = Convert.ToInt32(thisYearBox.Text),
                lastYearContestants = Convert.ToInt32(lastYearBox.Text);

            if (thisYearContestants > (lastYearContestants * 2))
            {
                outputLabel.Text = $"The competition is more than twice as big this year!";
                revenueLabel.Text = $"{formatThisYear} this year! And {formatLastYear} last year!";
            }
            else if (thisYearContestants > lastYearContestants)
            {
                outputLabel.Text = $"The competition is bigger than ever!";
                revenueLabel.Text = $"{formatThisYear} this year! And {formatLastYear} last year!";
            }
            else if (thisYearContestants < lastYearContestants)  
            {
                outputLabel.Text = $"A tighter race this year! Come out and cast your vote!";
                revenueLabel.Text = $"{formatThisYear} this year! And {formatLastYear} last year!";
            }
        }
    }
}
