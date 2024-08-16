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
        private string userInput = ""; // string storing user input
        private string operand1 = "";           // string storing first operand
        private string operand2 = "";           // string storing second operand
        char operation;                         // char for operation                         
        double result = 0.0;                    // calculated result

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
            userInput += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = userInput;
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            /*
             * sender is the button that was clicked
             * (sender as Button).Text gets the text of the clicked button
             */
            userInput += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = userInput;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            userInput += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = userInput;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            userInput += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = userInput;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            userInput += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = userInput;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            userInput += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = userInput;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            userInput += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = userInput;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            userInput += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = userInput;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            userInput += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = userInput;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            userInput += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = userInput;
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            // Adds number to the string calculation
            userInput += (sender as Button).Text;

            // Display the current calculation back to the user
            outputScreen.Text = userInput;
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            operand1 = userInput;
            operation = '/';
            userInput = string.Empty;
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            operand1 = userInput;
            operation = '*';
            userInput = string.Empty;
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            operand1 = userInput;
            operation = '-';
            userInput = string.Empty;
        }

        private void additionBtn_Click(object sender, EventArgs e)
        {
            operand1 = userInput;
            operation = '+';
            userInput = string.Empty;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "0";
            this.userInput = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            operand2 = userInput; // 
            double num1, num2; // convert string to double
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                outputScreen.Text = result.ToString();
            }

            else if (operation == '-')
            {
                result = num1 - num2;
                outputScreen.Text = result.ToString();
            }

            else if (operation == '*')
            {
                result = num1 * num2;
                outputScreen.Text = result.ToString();
            }

            else if (operation == '/')
            {
                result = num1 / num2;
                outputScreen.Text = result.ToString();
            }

        }

    }
}
