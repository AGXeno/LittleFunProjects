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
        private int defaultSeconds = 3;
        private int defaultMinutes = 25;

        private int currentMinutes;
        private int currentSeconds;

        private int iteration = 0;
        public Pomodoro()
        {
            InitializeComponent();
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e) { this.Close(); }

        // fires this function with every tick
        private void countdown_Tick(object sender, EventArgs e)
        {
            // count seconds all the way down to zero
            if (defaultSeconds > 0)
            {
                defaultSeconds--;
                SecondDisplay.Text = defaultSeconds + " seconds";
            }

            // decrement minutes, reset seconds to 59
            else if (defaultSeconds == 0)
            {
                defaultMinutes--;
                MinuteDisplay.Text = defaultMinutes + " minutes";
                defaultSeconds = 59;
                SecondDisplay.Text = defaultSeconds + " seconds";
            }

        }

        // when countdown hits 0:00, let user know
        private void EndSession()
        {

        }

        // default settings for short break (forgot to change the name)
        private void radioButton2_CheckedChanged(object sender, EventArgs e) 
        { 
            MinuteDisplay.Text = "7 Minutes"; 
            SecondDisplay.Text = "30 Seconds";

            defaultMinutes = 7;
            defaultSeconds = 30;
        }

        // default settings for long break (forgot to change the name)
        private void radioButton3_CheckedChanged(object sender, EventArgs e) 
        { 
            MinuteDisplay.Text = "12 Minutes"; 
            SecondDisplay.Text = "30 Seconds";

            defaultMinutes = 12;
            defaultSeconds = 30;
        }

        // default settings for pomodoro timer
        private void PomoBtn_CheckedChanged(object sender, EventArgs e) 
        { 
            MinuteDisplay.Text = "15 Minutes"; 
            SecondDisplay.Text = "30 Seconds";

            defaultMinutes = 15;
            defaultSeconds = 30;
        }

        private void startBtn_Click(object sender, EventArgs e) { countdown.Start(); }

        private void stopBtn_Click(object sender, EventArgs e) { countdown.Stop(); }

        // check which radio button is selected and reset time depending on which button is selected
        private void resetBtn_Click(object sender, EventArgs e) 
        {
            countdown.Stop();
            
            if (PomoBtn.Checked)
            {
                MinuteDisplay.Text = "15 Minutes"; SecondDisplay.Text = "30 Seconds";
            }

            else if (ShortBreakBtn.Checked) 
            {
                MinuteDisplay.Text = "7 Minutes";
                SecondDisplay.Text = "30 Seconds";

                defaultMinutes = 7;
                defaultSeconds = 30;

            }

            else if (LongBreakBtn.Checked) 
            {
                MinuteDisplay.Text = "12 Minutes";
                SecondDisplay.Text = "30 Seconds";

                defaultMinutes = 12;
                defaultSeconds = 30;
            }

            else if (PomoBtn.Checked)
            {
                MinuteDisplay.Text = "15 Minutes";
                SecondDisplay.Text = "30 Seconds";

                defaultMinutes = 15;
                defaultSeconds = 30;
            }
        }
    }
}
