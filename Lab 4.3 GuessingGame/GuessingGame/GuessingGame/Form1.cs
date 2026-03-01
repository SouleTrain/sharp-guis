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

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void guessButton_Click(object sender, EventArgs e)
        {
            // CPU
            Random solutionRandom = new Random();
            int solution = solutionRandom.Next(1, 11);

            // Player
            int guess = Convert.ToInt32(inputBox.Text);

            if ( (guess > 10) || (guess < 1) )
            {
                outputLabel.Text = $"Stop trying to break things!";
            }
            else if (guess > solution)
            {
                outputLabel.Text = $"{guess} was too high!\n{solution} was the number";
            }
            else if (guess < solution)
            {
                outputLabel.Text = $"{guess} was too low!\n{solution} was the number!";
            }
            else if (guess == solution) 
            {
                outputLabel.Text = $"{guess} is correct!";
            }



        }
    }
}
