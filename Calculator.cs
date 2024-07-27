using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFunProjects
{
    public partial class Calculator : Form
    {
        // To keep track of calculation
        private string currentCalculation = "";

        public Calculator()
        {
            InitializeComponent();
        }

        // Task bar functionality for the main menu
        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = currentCalculation;
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            /*
             * sender is the button that was clicked
             * (sender as Button).Text gets the text of the clicked button
             */
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = currentCalculation;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = currentCalculation;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = currentCalculation;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = currentCalculation;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = currentCalculation;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = currentCalculation;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = currentCalculation;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = currentCalculation;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = currentCalculation;
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = currentCalculation;
        }
    }
}
