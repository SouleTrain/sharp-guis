using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumFiveInts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            numList.Items.Add(numBox.Text);
            if (numList.Items.Count == 6)
            {
                numList.Items.Remove(numList.Items[0]);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                numList.Items.RemoveAt(numList.SelectedIndex);
            }
            catch
            {
            
            }
            
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            try
            {
                int sumNumbers1 = Convert.ToInt32(numList.Items[0]);
                int sumNumbers2 = Convert.ToInt32(numList.Items[1]);
                int sumNumbers3 = Convert.ToInt32(numList.Items[2]);
                int sumNumbers4 = Convert.ToInt32(numList.Items[3]);
                int sumNumbers5 = Convert.ToInt32(numList.Items[4]);
                int total = sumNumbers1 + sumNumbers2 + sumNumbers3 + sumNumbers4 + sumNumbers5;
            
                solutionLabel.Text = total.ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("error");
            }
            //I tried getting fancy with this and it ended up being a little beyond my abilities in this language
            //at the moment, however putting in any 5 numbers will sum correctly.
            //putting in any less than 5 numbers will do nothing


        }
    }
}
