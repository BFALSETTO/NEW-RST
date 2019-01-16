namespace PacMan
{
    partial class frmCharacterSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCharacterSelect));
            this.lblChooseChar = new System.Windows.Forms.Label();
            this.picMohammed = new System.Windows.Forms.PictureBox();
            this.picMissPacMan = new System.Windows.Forms.PictureBox();
            this.picZach = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMohammed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMissPacMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChooseChar
            // 
            this.lblChooseChar.AutoSize = true;
            this.lblChooseChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseChar.ForeColor = System.Drawing.Color.Yellow;
            this.lblChooseChar.Location = new System.Drawing.Point(60, 9);
            this.lblChooseChar.Name = "lblChooseChar";
            this.lblChooseChar.Size = new System.Drawing.Size(299, 31);
            this.lblChooseChar.TabIndex = 0;
            this.lblChooseChar.Text = "Choose Your Character";
            // 
            // picMohammed
            // 
            this.picMohammed.Image = global::PacMan.Properties.Resources.Mohammed;
            this.picMohammed.Location = new System.Drawing.Point(88, 112);
            this.picMohammed.Name = "picMohammed";
            this.picMohammed.Size = new System.Drawing.Size(45, 70);
            this.picMohammed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMohammed.TabIndex = 3;
            this.picMohammed.TabStop = false;
            this.picMohammed.Click += new System.EventHandler(this.picMohammed_Click);
            // 
            // picMissPacMan
            // 
            this.picMissPacMan.Image = global::PacMan.Properties.Resources.Right;
            this.picMissPacMan.Location = new System.Drawing.Point(286, 112);
            this.picMissPacMan.Name = "picMissPacMan";
            this.picMissPacMan.Size = new System.Drawing.Size(67, 70);
            this.picMissPacMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMissPacMan.TabIndex = 2;
            this.picMissPacMan.TabStop = false;
            this.picMissPacMan.Click += new System.EventHandler(this.picMissPacMan_Click);
            // 
            // picZach
            // 
            this.picZach.Image = global::PacMan.Properties.Resources.zachdown;
            this.picZach.Location = new System.Drawing.Point(176, 112);
            this.picZach.Name = "picZach";
            this.picZach.Size = new System.Drawing.Size(67, 70);
            this.picZach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picZach.TabIndex = 1;
            this.picZach.TabStop = false;
            this.picZach.Click += new System.EventHandler(this.picZach_Click);
            // 
            // frmCharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(418, 300);
            this.Controls.Add(this.picMohammed);
            this.Controls.Add(this.picMissPacMan);
            this.Controls.Add(this.picZach);
            this.Controls.Add(this.lblChooseChar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCharacterSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharacterSelect";
            ((System.ComponentModel.ISupportInitialize)(this.picMohammed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMissPacMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseChar;
        private System.Windows.Forms.PictureBox picZach;
        private System.Windows.Forms.PictureBox picMissPacMan;
        private System.Windows.Forms.PictureBox picMohammed;
    }
}