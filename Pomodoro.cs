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
    public partial class Pomodoro : Form
    {
        int ticker
        public Pomodoro()
        {
            InitializeComponent();
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e) { this.Close(); }

        private void countdown_Tick(object sender, EventArgs e)
        {
            string mystr = ticker.ToString();

            ticker = ticker + 1;

        }
    }
}
