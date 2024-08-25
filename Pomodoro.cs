using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;


namespace LittleFunProjects
{
    public partial class Pomodoro : Form
    {
        private int defaultSeconds = 30;
        private int defaultMinutes = 15;

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

            Sound_Alarm();

        }

        // when countdown hits 0:00, let user know
        private void EndSession()
        {

        }

        // sound when timer hits 0:00
        private void Sound_Alarm()
        {
            string mp3FilePath = "soft_jazz_bell_02.mp3";
            try
            {
                using (var audioFile = new AudioFileReader(mp3FilePath))
                {
                    using (var outputDevice = new WaveOutEvent())
                    {
                        outputDevice.Init(audioFile);
                        outputDevice.Play(); // play mp3

                        outputDevice.Stop();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        private void ShortBreakBtn_CheckedChanged(object sender, EventArgs e)
        {
            MinuteDisplay.Text = "7 Minutes";
            SecondDisplay.Text = "30 Seconds";

            defaultMinutes = 7;
            defaultSeconds = 30;

        }

        // default settings for short break (forgot to change the name)
        // check if settings have changed
        private void shortBreakBtn(object sender, EventArgs e)
        {
            MinuteDisplay.Text = "7 Minutes";
            SecondDisplay.Text = "30 Seconds";

            defaultMinutes = 7;
            defaultSeconds = 30;
        }

        // default settings for radio button long break (forgot to change the name)
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MinuteDisplay.Text = "12 Minutes";
            SecondDisplay.Text = "30 Seconds";

            defaultMinutes = 12;
            defaultSeconds = 30;
        }

        // default settings for radio button pomodoro timer
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

        // helper function for pomoSettingsToolStripMenuItem_Click
        private void CheckValue(string value, Label labelType, string valueType, string name)
        {
            if (!String.IsNullOrEmpty(value))
            {
                // convert value from string into int
                try
                {
                    int checkValue = Int32.Parse(value);

                    // check if seconds is under 60
                    if (checkValue < 2)
                    {
                        labelType.Text = $"{value} {valueType}";
                    }
                    else
                    {
                        labelType.Text = $"{value} {valueType}s";
                    }

                }

                catch (FormatException ex)
                {
                    MessageBox.Show($"An error occured for setting {name}: Please type in a number to set the timer.",
                        "Issue Setting Timer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pomoSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PomoSettings pomoSettings = new PomoSettings();
            pomoSettings.FormClosed += new FormClosedEventHandler(Pomo_SettingClosed);
            this.Hide();


            // check if values are int before loading into timer
            if (pomoSettings.ShowDialog() == DialogResult.OK)
            {
                // Pomodoro settings
                CheckValue(pomoSettings.pomoMinutes, MinuteDisplay, "minute", "pomo minutes");
                CheckValue(pomoSettings.pomoSeconds, SecondDisplay, "second", "pomo seconds");

                // Short timer settings
                CheckValue(pomoSettings.shortMinutes, MinuteDisplay, "minute", "short minutes");
                CheckValue(pomoSettings.shortSeconds, SecondDisplay, "second", "short seconds");

                CheckValue(pomoSettings.longMinutes, MinuteDisplay, "minute", "long minutes");
                CheckValue(pomoSettings.longSeconds, SecondDisplay, "second", "long seconds");

            }
        }
        private void Pomo_SettingClosed(object sender, EventArgs e) { this.Show(); }

    } 
}
