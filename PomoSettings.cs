using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFunProjects { 

    public partial class PomoSettings : Form
    {

        // { get; set; } - used to define properties, which are a way to
        // encapsulate fields and providee controlled access to them

        // 
        public string pomoMinutes { get; private set; }
        public string pomoSeconds { get; private set; }

        public string shortMinutes { get; private set; }
        public string shortSeconds { get; private set; }

        public string longMinutes { get; private set; }
        public string longSeconds { get; private set; }

        public PomoSettings()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            // check if textbox has a value.
            // if not, then leave it be

            if (!string.IsNullOrEmpty(SetPomoMin.Text))
            {
                pomoMinutes = SetPomoMin.Text;
            }

            if (!string.IsNullOrEmpty(SetPomoSec.Text))
            {
                pomoSeconds = SetPomoSec.Text;
            }

            if (!string.IsNullOrEmpty(SetShortMin.Text))
            {
                shortMinutes = SetShortMin.Text;
            }


            if (!string.IsNullOrEmpty(SetShortSec.Text))
            {
                shortSeconds = SetShortSec.Text;
            }

            if (!string.IsNullOrEmpty(SetLongMin.Text))
            {
                longMinutes = SetLongMin.Text;
            }

            if (!string.IsNullOrEmpty(SetLongSec.Text))
            {
                longSeconds = SetLongSec.Text;
            }

            this.DialogResult = DialogResult.OK;

            this.Hide();
        }
    }
}
