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
            this.lblReturnToMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYouWin
            // 
            this.lblYouWin.AutoSize = true;
            this.lblYouWin.Font = new System.Drawing.Font("OCR A Std", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouWin.ForeColor = System.Drawing.Color.Yellow;
            this.lblYouWin.Location = new System.Drawing.Point(172, 53);
            this.lblYouWin.Name = "lblYouWin";
            this.lblYouWin.Size = new System.Drawing.Size(165, 29);
            this.lblYouWin.TabIndex = 0;
            this.lblYouWin.Text = "YOU WIN!";
            // 
            // lblReturnToMenu
            // 
            this.lblReturnToMenu.AutoSize = true;
            this.lblReturnToMenu.Font = new System.Drawing.Font("OCR A Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnToMenu.ForeColor = System.Drawing.Color.Yellow;
            this.lblReturnToMenu.Location = new System.Drawing.Point(146, 209);
            this.lblReturnToMenu.Name = "lblReturnToMenu";
            this.lblReturnToMenu.Size = new System.Drawing.Size(217, 16);
            this.lblReturnToMenu.TabIndex = 1;
            this.lblReturnToMenu.Text = "Return to main menu";
            this.lblReturnToMenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(509, 290);
            this.Controls.Add(this.lblReturnToMenu);
            this.Controls.Add(this.lblYouWin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYouWin;
        private System.Windows.Forms.Label lblReturnToMenu;
    }
}