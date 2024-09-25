namespace LittleFunProjects
{
    partial class PomoWork
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
            this.MotivateLbl = new System.Windows.Forms.Label();
            this.WorkTimer = new System.Windows.Forms.Timer(this.components);
            this.StopBtn = new System.Windows.Forms.Button();
            this.WorkMinTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longBreakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortBreakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MotivateLbl
            // 
            this.MotivateLbl.AutoSize = true;
            this.MotivateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotivateLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MotivateLbl.Location = new System.Drawing.Point(46, 30);
            this.MotivateLbl.Name = "MotivateLbl";
            this.MotivateLbl.Size = new System.Drawing.Size(138, 25);
            this.MotivateLbl.TabIndex = 0;
            this.MotivateLbl.Text = "Focus session";
            // 
            // WorkTimer
            // 
            this.WorkTimer.Interval = 1000;
            // 
            // StopBtn
            // 
            this.StopBtn.AccessibleDescription = "Stop button to stop timer";
            this.StopBtn.AccessibleName = "Stop button";
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StopBtn.Location = new System.Drawing.Point(51, 145);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(133, 28);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // WorkMinTimer
            // 
            this.WorkMinTimer.AutoSize = true;
            this.WorkMinTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkMinTimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WorkMinTimer.Location = new System.Drawing.Point(44, 84);
            this.WorkMinTimer.Name = "WorkMinTimer";
            this.WorkMinTimer.Size = new System.Drawing.Size(53, 37);
            this.WorkMinTimer.TabIndex = 2;
            this.WorkMinTimer.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(131, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(101, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(224, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchToToolStripMenuItem,
            this.returnToMainMenuToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // switchToToolStripMenuItem
            // 
            this.switchToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.longBreakToolStripMenuItem,
            this.shortBreakToolStripMenuItem});
            this.switchToToolStripMenuItem.Name = "switchToToolStripMenuItem";
            this.switchToToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.switchToToolStripMenuItem.Text = "Switch to..";
            // 
            // longBreakToolStripMenuItem
            // 
            this.longBreakToolStripMenuItem.Name = "longBreakToolStripMenuItem";
            this.longBreakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.longBreakToolStripMenuItem.Text = "Long break";
            // 
            // shortBreakToolStripMenuItem
            // 
            this.shortBreakToolStripMenuItem.Name = "shortBreakToolStripMenuItem";
            this.shortBreakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shortBreakToolStripMenuItem.Text = "Short break";
            // 
            // returnToMainMenuToolStripMenuItem
            // 
            this.returnToMainMenuToolStripMenuItem.Name = "returnToMainMenuToolStripMenuItem";
            this.returnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.returnToMainMenuToolStripMenuItem.Text = "Return to Main Menu";
            this.returnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.returnToMainMenuToolStripMenuItem_Click);
            // 
            // PomoWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(224, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorkMinTimer);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.MotivateLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PomoWork";
            this.Text = "PomoWork";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MotivateLbl;
        private System.Windows.Forms.Timer WorkTimer;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label WorkMinTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longBreakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortBreakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
    }
}