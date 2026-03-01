using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurricane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int mph = Convert.ToInt32(textBox1.Text);

            if ( mph < 74 )
            {
                output.Text = $"Not a hurricane, relax dude";
            }
            else if ((mph >= 74) && (mph < 96))
            {
                output.Text = $"Hurricane is catagory 1";
            }
            else if ( (mph >= 96) && (mph < 111) )
            {
                output.Text = $"Hurricane is catagory 2"; 
            }
            else if ( (mph >= 111) && (mph < 130) )
            {
                output.Text = $"Hurricane is catagory 3";
            }
            else if ( (mph >= 130) && (mph < 156) )
            {
                output.Text = $"Hurricane is catagory 4";
            }
            else
            {
                output.Text = $"Hurricante is catagory 5";
            }
        }
    }
}
