﻿namespace LittleFunProjects
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.dfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Start_SessionBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(262, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pomo Timer!";
            // 
            // dfToolStripMenuItem
            // 
            this.dfToolStripMenuItem.Name = "dfToolStripMenuItem";
            this.dfToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.dfToolStripMenuItem.Text = "Return to Main Menu";
            // 
            // Start_SessionBtn
            // 
            this.Start_SessionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_SessionBtn.Location = new System.Drawing.Point(68, 96);
            this.Start_SessionBtn.Name = "Start_SessionBtn";
            this.Start_SessionBtn.Size = new System.Drawing.Size(119, 34);
            this.Start_SessionBtn.TabIndex = 3;
            this.Start_SessionBtn.Text = "Start Session";
            this.Start_SessionBtn.UseVisualStyleBackColor = true;
            this.Start_SessionBtn.Click += new System.EventHandler(this.Start_SessionBtn_Click);
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 203);
            this.Controls.Add(this.Start_SessionBtn);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem dfToolStripMenuItem;
        private System.Windows.Forms.Button Start_SessionBtn;
    }
}