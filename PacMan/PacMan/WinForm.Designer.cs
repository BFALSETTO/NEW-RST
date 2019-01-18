namespace PacMan
{
    partial class frmWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWin));
            this.lblYouWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYouWin
            // 
            this.lblYouWin.AutoSize = true;
            this.lblYouWin.Font = new System.Drawing.Font("OCR A Extended", 8.25F);
            this.lblYouWin.ForeColor = System.Drawing.Color.Yellow;
            this.lblYouWin.Location = new System.Drawing.Point(247, 181);
            this.lblYouWin.Name = "lblYouWin";
            this.lblYouWin.Size = new System.Drawing.Size(47, 12);
            this.lblYouWin.TabIndex = 0;
            this.lblYouWin.Text = "label1";
            // 
            // frmWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(509, 290);
            this.Controls.Add(this.lblYouWin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYouWin;
    }
}