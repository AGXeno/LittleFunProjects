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
            this.Name = "PomoWork";
            this.Text = "PomoWork";
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
    }
}