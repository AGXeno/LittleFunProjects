namespace LittleFunProjects
{
    partial class MoodTracker
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
            this.MoodTrackerLabel = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.HappyBtn = new System.Windows.Forms.RadioButton();
            this.MoodLbl = new System.Windows.Forms.Label();
            this.DepressedBtn = new System.Windows.Forms.RadioButton();
            this.AngryUpsetBtn = new System.Windows.Forms.RadioButton();
            this.NeutralBtn = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NotesLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoodTrackerLabel
            // 
            this.MoodTrackerLabel.AutoSize = true;
            this.MoodTrackerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoodTrackerLabel.Location = new System.Drawing.Point(108, 33);
            this.MoodTrackerLabel.Name = "MoodTrackerLabel";
            this.MoodTrackerLabel.Size = new System.Drawing.Size(181, 31);
            this.MoodTrackerLabel.TabIndex = 0;
            this.MoodTrackerLabel.Text = "Mood Tracker";
            this.MoodTrackerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(402, 24);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // returnToMainMenuToolStripMenuItem
            // 
            this.returnToMainMenuToolStripMenuItem.Name = "returnToMainMenuToolStripMenuItem";
            this.returnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.returnToMainMenuToolStripMenuItem.Text = "Return to Main Menu";
            this.returnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.returnToMainMenuToolStripMenuItem_Click);
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.Location = new System.Drawing.Point(29, 93);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(108, 20);
            this.DateLbl.TabIndex = 2;
            this.DateLbl.Text = "Today\'s Entry:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // HappyBtn
            // 
            this.HappyBtn.AutoSize = true;
            this.HappyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HappyBtn.Location = new System.Drawing.Point(176, 133);
            this.HappyBtn.Name = "HappyBtn";
            this.HappyBtn.Size = new System.Drawing.Size(73, 24);
            this.HappyBtn.TabIndex = 5;
            this.HappyBtn.TabStop = true;
            this.HappyBtn.Text = "Happy";
            this.HappyBtn.UseVisualStyleBackColor = true;
            // 
            // MoodLbl
            // 
            this.MoodLbl.AutoSize = true;
            this.MoodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoodLbl.Location = new System.Drawing.Point(32, 133);
            this.MoodLbl.Name = "MoodLbl";
            this.MoodLbl.Size = new System.Drawing.Size(105, 20);
            this.MoodLbl.TabIndex = 6;
            this.MoodLbl.Text = "Overall Mood:";
            // 
            // DepressedBtn
            // 
            this.DepressedBtn.AutoSize = true;
            this.DepressedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepressedBtn.Location = new System.Drawing.Point(176, 163);
            this.DepressedBtn.Name = "DepressedBtn";
            this.DepressedBtn.Size = new System.Drawing.Size(105, 24);
            this.DepressedBtn.TabIndex = 7;
            this.DepressedBtn.TabStop = true;
            this.DepressedBtn.Text = "Depressed";
            this.DepressedBtn.UseVisualStyleBackColor = true;
            // 
            // AngryUpsetBtn
            // 
            this.AngryUpsetBtn.AutoSize = true;
            this.AngryUpsetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AngryUpsetBtn.Location = new System.Drawing.Point(176, 193);
            this.AngryUpsetBtn.Name = "AngryUpsetBtn";
            this.AngryUpsetBtn.Size = new System.Drawing.Size(115, 24);
            this.AngryUpsetBtn.TabIndex = 8;
            this.AngryUpsetBtn.TabStop = true;
            this.AngryUpsetBtn.Text = "Angry/Upset";
            this.AngryUpsetBtn.UseVisualStyleBackColor = true;
            // 
            // NeutralBtn
            // 
            this.NeutralBtn.AutoSize = true;
            this.NeutralBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeutralBtn.Location = new System.Drawing.Point(176, 223);
            this.NeutralBtn.Name = "NeutralBtn";
            this.NeutralBtn.Size = new System.Drawing.Size(78, 24);
            this.NeutralBtn.TabIndex = 9;
            this.NeutralBtn.TabStop = true;
            this.NeutralBtn.Text = "Neutral";
            this.NeutralBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 267);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 111);
            this.textBox1.TabIndex = 10;
            // 
            // NotesLbl
            // 
            this.NotesLbl.AutoSize = true;
            this.NotesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLbl.Location = new System.Drawing.Point(82, 265);
            this.NotesLbl.Name = "NotesLbl";
            this.NotesLbl.Size = new System.Drawing.Size(55, 20);
            this.NotesLbl.TabIndex = 11;
            this.NotesLbl.Text = "Notes:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(145, 404);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(122, 37);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Save Entry";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // MoodTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 453);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NotesLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NeutralBtn);
            this.Controls.Add(this.AngryUpsetBtn);
            this.Controls.Add(this.DepressedBtn);
            this.Controls.Add(this.MoodLbl);
            this.Controls.Add(this.HappyBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.MoodTrackerLabel);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MoodTracker";
            this.Text = "MoodTracker";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MoodTrackerLabel;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton HappyBtn;
        private System.Windows.Forms.Label MoodLbl;
        private System.Windows.Forms.RadioButton DepressedBtn;
        private System.Windows.Forms.RadioButton AngryUpsetBtn;
        private System.Windows.Forms.RadioButton NeutralBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NotesLbl;
        private System.Windows.Forms.Button SaveBtn;
    }
}