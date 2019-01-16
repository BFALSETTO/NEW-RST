namespace PacMan
{
    partial class frmCredits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCredits));
            this.lblName = new System.Windows.Forms.Label();
            this.lblChooseRad = new System.Windows.Forms.Label();
            this.radCharacters = new System.Windows.Forms.RadioButton();
            this.radEnemies = new System.Windows.Forms.RadioButton();
            this.radCoin = new System.Windows.Forms.RadioButton();
            this.radSplashSound = new System.Windows.Forms.RadioButton();
            this.radBackMus = new System.Windows.Forms.RadioButton();
            this.picCredit1 = new System.Windows.Forms.PictureBox();
            this.picCredit2 = new System.Windows.Forms.PictureBox();
            this.picCredit3 = new System.Windows.Forms.PictureBox();
            this.lblReopenMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCredit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCredit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCredit3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Yellow;
            this.lblName.Location = new System.Drawing.Point(331, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "PAC-MAN";
            // 
            // lblChooseRad
            // 
            this.lblChooseRad.AutoSize = true;
            this.lblChooseRad.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseRad.ForeColor = System.Drawing.Color.Yellow;
            this.lblChooseRad.Location = new System.Drawing.Point(91, 85);
            this.lblChooseRad.Name = "lblChooseRad";
            this.lblChooseRad.Size = new System.Drawing.Size(273, 40);
            this.lblChooseRad.TabIndex = 1;
            this.lblChooseRad.Text = "Choose a category to see\r\nthe resources used";
            // 
            // radCharacters
            // 
            this.radCharacters.AutoSize = true;
            this.radCharacters.ForeColor = System.Drawing.Color.Yellow;
            this.radCharacters.Location = new System.Drawing.Point(95, 157);
            this.radCharacters.Name = "radCharacters";
            this.radCharacters.Size = new System.Drawing.Size(76, 17);
            this.radCharacters.TabIndex = 2;
            this.radCharacters.TabStop = true;
            this.radCharacters.Text = "Characters";
            this.radCharacters.UseVisualStyleBackColor = true;
            this.radCharacters.CheckedChanged += new System.EventHandler(this.radCharacters_CheckedChanged);
            // 
            // radEnemies
            // 
            this.radEnemies.AutoSize = true;
            this.radEnemies.ForeColor = System.Drawing.Color.Yellow;
            this.radEnemies.Location = new System.Drawing.Point(95, 180);
            this.radEnemies.Name = "radEnemies";
            this.radEnemies.Size = new System.Drawing.Size(65, 17);
            this.radEnemies.TabIndex = 3;
            this.radEnemies.TabStop = true;
            this.radEnemies.Text = "Enemies";
            this.radEnemies.UseVisualStyleBackColor = true;
            this.radEnemies.CheckedChanged += new System.EventHandler(this.radEnemies_CheckedChanged);
            // 
            // radCoin
            // 
            this.radCoin.AutoSize = true;
            this.radCoin.ForeColor = System.Drawing.Color.Yellow;
            this.radCoin.Location = new System.Drawing.Point(95, 203);
            this.radCoin.Name = "radCoin";
            this.radCoin.Size = new System.Drawing.Size(46, 17);
            this.radCoin.TabIndex = 4;
            this.radCoin.TabStop = true;
            this.radCoin.Text = "Coin";
            this.radCoin.UseVisualStyleBackColor = true;
            this.radCoin.CheckedChanged += new System.EventHandler(this.radCoin_CheckedChanged);
            // 
            // radSplashSound
            // 
            this.radSplashSound.AutoSize = true;
            this.radSplashSound.ForeColor = System.Drawing.Color.Yellow;
            this.radSplashSound.Location = new System.Drawing.Point(95, 226);
            this.radSplashSound.Name = "radSplashSound";
            this.radSplashSound.Size = new System.Drawing.Size(80, 17);
            this.radSplashSound.TabIndex = 5;
            this.radSplashSound.TabStop = true;
            this.radSplashSound.Text = "Intro Sound";
            this.radSplashSound.UseVisualStyleBackColor = true;
            this.radSplashSound.CheckedChanged += new System.EventHandler(this.radSplashSound_CheckedChanged);
            // 
            // radBackMus
            // 
            this.radBackMus.AutoSize = true;
            this.radBackMus.ForeColor = System.Drawing.Color.Yellow;
            this.radBackMus.Location = new System.Drawing.Point(95, 249);
            this.radBackMus.Name = "radBackMus";
            this.radBackMus.Size = new System.Drawing.Size(114, 17);
            this.radBackMus.TabIndex = 6;
            this.radBackMus.TabStop = true;
            this.radBackMus.Text = "Background Music";
            this.radBackMus.UseVisualStyleBackColor = true;
            this.radBackMus.CheckedChanged += new System.EventHandler(this.radBackMus_CheckedChanged);
            // 
            // picCredit1
            // 
            this.picCredit1.Location = new System.Drawing.Point(295, 157);
            this.picCredit1.Name = "picCredit1";
            this.picCredit1.Size = new System.Drawing.Size(100, 50);
            this.picCredit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCredit1.TabIndex = 7;
            this.picCredit1.TabStop = false;
            // 
            // picCredit2
            // 
            this.picCredit2.Location = new System.Drawing.Point(401, 157);
            this.picCredit2.Name = "picCredit2";
            this.picCredit2.Size = new System.Drawing.Size(100, 50);
            this.picCredit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCredit2.TabIndex = 8;
            this.picCredit2.TabStop = false;
            // 
            // picCredit3
            // 
            this.picCredit3.Location = new System.Drawing.Point(507, 157);
            this.picCredit3.Name = "picCredit3";
            this.picCredit3.Size = new System.Drawing.Size(100, 50);
            this.picCredit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCredit3.TabIndex = 9;
            this.picCredit3.TabStop = false;
            // 
            // lblReopenMenu
            // 
            this.lblReopenMenu.AutoSize = true;
            this.lblReopenMenu.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReopenMenu.ForeColor = System.Drawing.Color.Yellow;
            this.lblReopenMenu.Location = new System.Drawing.Point(460, 85);
            this.lblReopenMenu.Name = "lblReopenMenu";
            this.lblReopenMenu.Size = new System.Drawing.Size(328, 20);
            this.lblReopenMenu.TabIndex = 10;
            this.lblReopenMenu.Text = "Click here to reopen the menu";
            this.lblReopenMenu.Click += new System.EventHandler(this.lblReopenMenu_Click);
            // 
            // frmCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReopenMenu);
            this.Controls.Add(this.picCredit3);
            this.Controls.Add(this.picCredit2);
            this.Controls.Add(this.picCredit1);
            this.Controls.Add(this.radBackMus);
            this.Controls.Add(this.radSplashSound);
            this.Controls.Add(this.radCoin);
            this.Controls.Add(this.radEnemies);
            this.Controls.Add(this.radCharacters);
            this.Controls.Add(this.lblChooseRad);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCredits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits Form";
            ((System.ComponentModel.ISupportInitialize)(this.picCredit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCredit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCredit3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblChooseRad;
        private System.Windows.Forms.RadioButton radCharacters;
        private System.Windows.Forms.RadioButton radEnemies;
        private System.Windows.Forms.RadioButton radCoin;
        private System.Windows.Forms.RadioButton radSplashSound;
        private System.Windows.Forms.RadioButton radBackMus;
        private System.Windows.Forms.PictureBox picCredit1;
        private System.Windows.Forms.PictureBox picCredit2;
        private System.Windows.Forms.PictureBox picCredit3;
        private System.Windows.Forms.Label lblReopenMenu;
    }
}