namespace BotsbalGame
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
            this.components = new System.ComponentModel.Container();
            this.pictBoxBal = new System.Windows.Forms.PictureBox();
            this.pictBoxCPU = new System.Windows.Forms.PictureBox();
            this.pictBoxSpeler = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelSpeelveld = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxSpeler)).BeginInit();
            this.panelSpeelveld.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictBoxBal
            // 
            this.pictBoxBal.BackColor = System.Drawing.Color.Red;
            this.pictBoxBal.Location = new System.Drawing.Point(306, 59);
            this.pictBoxBal.Name = "pictBoxBal";
            this.pictBoxBal.Size = new System.Drawing.Size(30, 30);
            this.pictBoxBal.TabIndex = 0;
            this.pictBoxBal.TabStop = false;
            // 
            // pictBoxCPU
            // 
            this.pictBoxCPU.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictBoxCPU.Location = new System.Drawing.Point(10, 59);
            this.pictBoxCPU.Name = "pictBoxCPU";
            this.pictBoxCPU.Size = new System.Drawing.Size(10, 100);
            this.pictBoxCPU.TabIndex = 1;
            this.pictBoxCPU.TabStop = false;
            // 
            // pictBoxSpeler
            // 
            this.pictBoxSpeler.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictBoxSpeler.Location = new System.Drawing.Point(706, 59);
            this.pictBoxSpeler.Name = "pictBoxSpeler";
            this.pictBoxSpeler.Size = new System.Drawing.Size(10, 100);
            this.pictBoxSpeler.TabIndex = 2;
            this.pictBoxSpeler.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelSpeelveld
            // 
            this.panelSpeelveld.Controls.Add(this.lblScore);
            this.panelSpeelveld.Controls.Add(this.pictBoxSpeler);
            this.panelSpeelveld.Controls.Add(this.pictBoxCPU);
            this.panelSpeelveld.Controls.Add(this.pictBoxBal);
            this.panelSpeelveld.Location = new System.Drawing.Point(1, 0);
            this.panelSpeelveld.Name = "panelSpeelveld";
            this.panelSpeelveld.Size = new System.Drawing.Size(731, 390);
            this.panelSpeelveld.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(303, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(33, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0 - 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 389);
            this.Controls.Add(this.panelSpeelveld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxSpeler)).EndInit();
            this.panelSpeelveld.ResumeLayout(false);
            this.panelSpeelveld.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxBal;
        private System.Windows.Forms.PictureBox pictBoxCPU;
        private System.Windows.Forms.PictureBox pictBoxSpeler;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelSpeelveld;
        private System.Windows.Forms.Label lblScore;
    }
}