﻿using System;
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
    public partial class PomoShortBreak : Form
    {
        public PomoShortBreak()
        {
            InitializeComponent();
        }

        private void WorkMinTimer_Click(object sender, EventArgs e)
        {

        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
