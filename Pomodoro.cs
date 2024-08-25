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

        // default settings for short break (forgot to change the name)
        // check if settings have changed
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

        private void pomoSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PomoSettings pomoSettings = new PomoSettings();
            pomoSettings.FormClosed += new FormClosedEventHandler(Pomo_SettingClosed);
            this.Hide();


            // check if values are int before loading into timer
            if (pomoSettings.ShowDialog() == DialogResult.OK)
            {
                if (!String.IsNullOrEmpty(pomoSettings.pomoMinutes))
                {
                    try
                    {
                        int checkMinute = Int32.Parse(pomoSettings.pomoMinutes);
                        if (checkMinute < 2)
                        {
                            MinuteDisplay.Text = $"{pomoSettings.pomoMinutes} minute";
                        }
                        else
                        {
                            MinuteDisplay.Text = $"{pomoSettings.pomoMinutes} minutes";
                        }

                    }

                    catch (FormatException ex)
                    {
                        MessageBox.Show($"An error occured for setting Pomo minutes: {ex.Message}", "Issue Loading Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (!String.IsNullOrEmpty(pomoSettings.pomoSeconds))
                {
                    try
                    {
                        int checkSecond = Int32.Parse(pomoSettings.pomoSeconds);
                        if (checkSecond == 1)
                        {
                            SecondDisplay.Text = $"{pomoSettings.pomoSeconds} second";
                        }
                        else
                        {
                            SecondDisplay.Text = $"{pomoSettings.pomoSeconds} seconds";
                        }

                    }

                    catch (FormatException ex)
                    {
                        MessageBox.Show($"An error occured for setting Pomo seconds: {ex.Message}", "Issue Loading Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (!String.IsNullOrEmpty(pomoSettings.shortMinutes))
                {
                    try
                    {
                        int checkMinute = Int32.Parse(pomoSettings.shortMinutes);
                        if (checkMinute == 1)
                        {
                            SecondDisplay.Text = $"{pomoSettings.shortMinutes} minute";
                        }
                        else
                        {
                            SecondDisplay.Text = $"{pomoSettings.shortMinutes} minutes";
                        }

                    }

                    catch (FormatException ex)
                    {
                        MessageBox.Show($"An error occured for setting short minutes: {ex.Message}", "Issue Loading Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (!String.IsNullOrEmpty(pomoSettings.shortSeconds))
                {
                    try
                    {
                        int checkMinute = Int32.Parse(pomoSettings.shortSeconds);
                        if (checkMinute == 1)
                        {
                            SecondDisplay.Text = $"{pomoSettings.shortSeconds} second";
                        }
                        else
                        {
                            SecondDisplay.Text = $"{pomoSettings.shortSeconds} seconds";
                        }

                    }

                    catch (FormatException ex)
                    {
                        MessageBox.Show($"An error occured for setting short seconds: {ex.Message}", "Issue Loading Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (!String.IsNullOrEmpty(pomoSettings.longMinutes))
                {
                    try
                    {
                        int checkMinute = Int32.Parse(pomoSettings.longMinutes);
                        if (checkMinute == 1)
                        {
                            SecondDisplay.Text = $"{pomoSettings.longMinutes} minute";
                        }
                        else
                        {
                            SecondDisplay.Text = $"{pomoSettings.longMinutes} minutes";
                        }

                    }

                    catch (FormatException ex)
                    {
                        MessageBox.Show($"An error occured for setting long minutes: {ex.Message}", "Issue Loading Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (!String.IsNullOrEmpty(pomoSettings.longSeconds))
                    {
                        try
                        {
                            int checkMinute = Int32.Parse(pomoSettings.longSeconds);
                            if (checkMinute == 1)
                            {
                                SecondDisplay.Text = $"{pomoSettings.longSeconds} second";
                            }
                            else
                            {
                                SecondDisplay.Text = $"{pomoSettings.longSeconds} seconds";
                            }

                        }

                        catch (FormatException ex)
                        {
                            MessageBox.Show($"An error occured for setting long seconds: {ex.Message}", "Issue Loading Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void Pomo_SettingClosed(object sender, EventArgs e) { this.Show(); }
    } 
}
