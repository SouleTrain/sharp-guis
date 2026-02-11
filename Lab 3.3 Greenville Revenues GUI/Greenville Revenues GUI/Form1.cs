using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenville_Revenues_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int thisYearContestants = Convert.ToInt32(thisYearBox.Text),
                lastYearContestants = Convert.ToInt32(lastYearBox.Text),
                thisYearRevenue = thisYearContestants * 25,
                lastYearRevenue = lastYearContestants * 25;
            string formatThisYearRev = thisYearRevenue.ToString("C"),
                   formatLastYearRev = lastYearRevenue.ToString("C");
            thisYearRev.Text = $"Expecting {thisYearContestants} contestants and {formatThisYearRev} this Year!";
            lastYearRev.Text = $"There were {lastYearContestants} contestants and {formatLastYearRev} last Year!";

            if (thisYearContestants > lastYearContestants)
            {
                compareLabel.Text = $"Expecting more contestants this year!";
            }

            if (thisYearContestants == lastYearContestants)
            {
                compareLabel.Text = $"Expecting the same amount of contestants as last year!";
            }

            else
            {
                compareLabel.Text = $"There were more contestants last year!";
            }


                    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
