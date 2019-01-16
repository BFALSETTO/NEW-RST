namespace PacMan
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.lblClickToStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClickToStart
            // 
            this.lblClickToStart.AutoSize = true;
            this.lblClickToStart.BackColor = System.Drawing.Color.Transparent;
            this.lblClickToStart.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickToStart.ForeColor = System.Drawing.Color.Yellow;
            this.lblClickToStart.Location = new System.Drawing.Point(46, 150);
            this.lblClickToStart.Name = "lblClickToStart";
            this.lblClickToStart.Size = new System.Drawing.Size(365, 29);
            this.lblClickToStart.TabIndex = 1;
            this.lblClickToStart.Text = "PRESS ANY KEY TO START";
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 317);
            this.Controls.Add(this.lblClickToStart);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreenForm";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSplashScreen_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClickToStart;
    }
}