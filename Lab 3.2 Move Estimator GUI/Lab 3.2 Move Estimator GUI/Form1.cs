using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3._2_Move_Estimator_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double miles = Convert.ToDouble(mileBox.Text) * 2,
                   hours = Convert.ToDouble(hourBox.Text) * 150;

            double cost = miles + hours + 200;
            string costFormat = cost.ToString("C2");

            outputLabel.Text = $"Move will cost : {costFormat}";
        }
    }
}
