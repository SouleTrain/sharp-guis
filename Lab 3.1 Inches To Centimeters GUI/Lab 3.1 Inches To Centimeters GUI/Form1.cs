using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3._1_Inches_To_Centimeters_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inchesBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double inches = Convert.ToDouble(inchesBox.Text);
            double centimeters = inches * 2.54;

            outputLabel.Text = $"{inches} Inches = {centimeters} Centimeters!";
        }
    }
}
