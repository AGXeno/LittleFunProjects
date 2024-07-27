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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ShowDialog() opens form as a modal dialog, which blocks the original form until the new form is closed
        // When you close the modal form, the original form resumes its execution

        // modal form  = type of window in a GUI that requires the user to interact with it
        // before returning to operating the parent application. ShowDialog() opens form as a modal dialog.
        // Use case: for requiring user input or confirmation that needs to be completed before proceeding
        private void calculatorBtn_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.FormClosed += new FormClosedEventHandler(Calc_FormClosed);
            this.Hide(); // hide MainMenu
            calculator.ShowDialog(); // Show Calculator
        }

        private void Calc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
