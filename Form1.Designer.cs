namespace LittleFunProjects
{
    partial class Form1
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
            this.mainMenuTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.quitMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuTitle
            // 
            this.mainMenuTitle.AutoSize = true;
            this.mainMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuTitle.Location = new System.Drawing.Point(90, 28);
            this.mainMenuTitle.Name = "mainMenuTitle";
            this.mainMenuTitle.Size = new System.Drawing.Size(163, 36);
            this.mainMenuTitle.TabIndex = 0;
            this.mainMenuTitle.Text = "Main Menu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // quitMenuBtn
            // 
            this.quitMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitMenuBtn.Location = new System.Drawing.Point(123, 213);
            this.quitMenuBtn.Name = "quitMenuBtn";
            this.quitMenuBtn.Size = new System.Drawing.Size(94, 36);
            this.quitMenuBtn.TabIndex = 2;
            this.quitMenuBtn.Text = "Exit";
            this.quitMenuBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.quitMenuBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainMenuTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button quitMenuBtn;
    }
}

