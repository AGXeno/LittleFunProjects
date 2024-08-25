namespace LittleFunProjects
{
    partial class Pomodoro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PomoBtn = new System.Windows.Forms.RadioButton();
            this.ShortBreakBtn = new System.Windows.Forms.RadioButton();
            this.LongBreakBtn = new System.Windows.Forms.RadioButton();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.MinuteDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondDisplay = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem,
            this.pomoSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // returnToMainMenuToolStripMenuItem
            // 
            this.returnToMainMenuToolStripMenuItem.Name = "returnToMainMenuToolStripMenuItem";
            this.returnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.returnToMainMenuToolStripMenuItem.Text = "Return to Main Menu";
            this.returnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.returnToMainMenuToolStripMenuItem_Click);
            // 
            // pomoSettingsToolStripMenuItem
            // 
            this.pomoSettingsToolStripMenuItem.Name = "pomoSettingsToolStripMenuItem";
            this.pomoSettingsToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.pomoSettingsToolStripMenuItem.Text = "Pomo Settings";
            this.pomoSettingsToolStripMenuItem.Click += new System.EventHandler(this.pomoSettingsToolStripMenuItem_Click);
            // 
            // PomoBtn
            // 
            this.PomoBtn.AutoSize = true;
            this.PomoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PomoBtn.Location = new System.Drawing.Point(47, 55);
            this.PomoBtn.Name = "PomoBtn";
            this.PomoBtn.Size = new System.Drawing.Size(120, 29);
            this.PomoBtn.TabIndex = 1;
            this.PomoBtn.TabStop = true;
            this.PomoBtn.Text = "Pomodoro";
            this.PomoBtn.UseVisualStyleBackColor = true;
            this.PomoBtn.CheckedChanged += new System.EventHandler(this.PomoBtn_CheckedChanged);
            // 
            // ShortBreakBtn
            // 
            this.ShortBreakBtn.AutoSize = true;
            this.ShortBreakBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortBreakBtn.Location = new System.Drawing.Point(229, 55);
            this.ShortBreakBtn.Name = "ShortBreakBtn";
            this.ShortBreakBtn.Size = new System.Drawing.Size(133, 29);
            this.ShortBreakBtn.TabIndex = 2;
            this.ShortBreakBtn.TabStop = true;
            this.ShortBreakBtn.Text = "Short Break";
            this.ShortBreakBtn.UseVisualStyleBackColor = true;
            this.ShortBreakBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // LongBreakBtn
            // 
            this.LongBreakBtn.AutoSize = true;
            this.LongBreakBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongBreakBtn.Location = new System.Drawing.Point(428, 55);
            this.LongBreakBtn.Name = "LongBreakBtn";
            this.LongBreakBtn.Size = new System.Drawing.Size(130, 29);
            this.LongBreakBtn.TabIndex = 3;
            this.LongBreakBtn.TabStop = true;
            this.LongBreakBtn.Text = "Long Break";
            this.LongBreakBtn.UseVisualStyleBackColor = true;
            this.LongBreakBtn.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(47, 205);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(120, 35);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(229, 205);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(133, 35);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(428, 205);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(130, 35);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // countdown
            // 
            this.countdown.Interval = 1000;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // MinuteDisplay
            // 
            this.MinuteDisplay.AutoSize = true;
            this.MinuteDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteDisplay.Location = new System.Drawing.Point(67, 118);
            this.MinuteDisplay.Name = "MinuteDisplay";
            this.MinuteDisplay.Size = new System.Drawing.Size(183, 39);
            this.MinuteDisplay.TabIndex = 7;
            this.MinuteDisplay.Text = "25 Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "|";
            // 
            // SecondDisplay
            // 
            this.SecondDisplay.AutoSize = true;
            this.SecondDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondDisplay.Location = new System.Drawing.Point(356, 118);
            this.SecondDisplay.Name = "SecondDisplay";
            this.SecondDisplay.Size = new System.Drawing.Size(178, 39);
            this.SecondDisplay.TabIndex = 9;
            this.SecondDisplay.Text = "0 Seconds";
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 276);
            this.Controls.Add(this.SecondDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinuteDisplay);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.LongBreakBtn);
            this.Controls.Add(this.ShortBreakBtn);
            this.Controls.Add(this.PomoBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pomodoro";
            this.Text = "Pomodoro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.RadioButton PomoBtn;
        private System.Windows.Forms.RadioButton ShortBreakBtn;
        private System.Windows.Forms.RadioButton LongBreakBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.Label MinuteDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SecondDisplay;
        private System.Windows.Forms.ToolStripMenuItem pomoSettingsToolStripMenuItem;
    }
}