namespace LittleFunProjects
{
    partial class MainMenu
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
            this.calculatorBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.mainMenuTitle = new System.Windows.Forms.Label();
            this.pomodoroBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculatorBtn
            // 
            this.calculatorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorBtn.Location = new System.Drawing.Point(64, 67);
            this.calculatorBtn.Name = "calculatorBtn";
            this.calculatorBtn.Size = new System.Drawing.Size(99, 27);
            this.calculatorBtn.TabIndex = 0;
            this.calculatorBtn.Text = "Calculator";
            this.calculatorBtn.UseVisualStyleBackColor = true;
            this.calculatorBtn.Click += new System.EventHandler(this.calculatorBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(64, 209);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(99, 31);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // mainMenuTitle
            // 
            this.mainMenuTitle.AutoSize = true;
            this.mainMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuTitle.Location = new System.Drawing.Point(44, 9);
            this.mainMenuTitle.Name = "mainMenuTitle";
            this.mainMenuTitle.Size = new System.Drawing.Size(146, 31);
            this.mainMenuTitle.TabIndex = 2;
            this.mainMenuTitle.Text = "Main Menu";
            // 
            // pomodoroBtn
            // 
            this.pomodoroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomodoroBtn.Location = new System.Drawing.Point(64, 111);
            this.pomodoroBtn.Name = "pomodoroBtn";
            this.pomodoroBtn.Size = new System.Drawing.Size(99, 24);
            this.pomodoroBtn.TabIndex = 3;
            this.pomodoroBtn.Text = "Pomodoro";
            this.pomodoroBtn.UseVisualStyleBackColor = true;
            this.pomodoroBtn.Click += new System.EventHandler(this.pomodoroBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 265);
            this.Controls.Add(this.pomodoroBtn);
            this.Controls.Add(this.mainMenuTitle);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.calculatorBtn);
            this.Name = "MainMenu";
            this.Text = "Little Projects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculatorBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label mainMenuTitle;
        private System.Windows.Forms.Button pomodoroBtn;
    }
}