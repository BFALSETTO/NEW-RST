using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PacMan
{
    public partial class frmCredits : Form
    {
        private SoundPlayer SplashSound = new SoundPlayer("pacman_beginning.wav");
        SoundPlayer BackSound = new SoundPlayer("Background Theme.wav");

        
        public frmCredits()
        {
            InitializeComponent();
        }

        private void radCharacters_CheckedChanged(object sender, EventArgs e)
        {
            if (radCharacters.Checked == true)
            {
                picCredit1.Width = 45;
                picCredit1.Height = 70;
                picCredit1.Image = Properties.Resources.Mohammed;

                picCredit2.Width = 67;
                picCredit2.Height = 70;
                picCredit2.Image = Properties.Resources.zachdown;

                picCredit3.Width = 67;
                picCredit3.Height = 70;
                picCredit3.Image = Properties.Resources.Right;
            }
            else if (radCharacters.Checked == false)
            {
                picCredit1.Image = null;
                picCredit2.Image = null;
                picCredit3.Image = null;
            }
        }

        private void lblQToClose_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void radEnemies_CheckedChanged(object sender, EventArgs e)
        {
            if (radEnemies.Checked == true)
            {
                picCredit1.Width = 50;
                picCredit1.Height = 53;
                picCredit1.Image = Properties.Resources.ghost1;

                picCredit2.Width = 50;
                picCredit2.Height = 53;
                picCredit2.Image = Properties.Resources.ghost2;

                picCredit3.Width = 50;
                picCredit3.Height = 53;
                picCredit3.Image = Properties.Resources.Waluigi;
            }
            else if (radEnemies.Checked == false)
            {
                picCredit1.Image = null;
                picCredit2.Image = null;
                picCredit3.Image = null;
            }
        }

        private void radCoin_CheckedChanged(object sender, EventArgs e)
        {
            if (radCoin.Checked == true)
            {
                picCredit1.Width = 50;
                picCredit1.Height = 50;
                picCredit1.Image = Properties.Resources.cccc;

                picCredit2.Width = 50;
                picCredit2.Height = 50;
                picCredit2.Image = Properties.Resources.coint2;

                picCredit3.Width = 50;
                picCredit3.Height = 50;
                picCredit3.Image = Properties.Resources.YeetCoin1;
            }
            else if (radCoin.Checked == false)
            {
                picCredit1.Image = null;
                picCredit2.Image = null;
                picCredit3.Image = null;
            }
        }

        private void radSplashSound_CheckedChanged(object sender, EventArgs e)
        {
            if (radSplashSound.Checked == true)
            {
                SplashSound.PlayLooping();
            }
            else if (radSplashSound.Checked == false)
            {
                SplashSound.Stop();
            }
        }

        private void radBackMus_CheckedChanged(object sender, EventArgs e)
        {
            if (radBackMus.Checked == true)
            {
                BackSound.PlayLooping();
            }
            else if (radBackMus.Checked ==  false)
            {
                BackSound.Stop();
            }
        }
    }
}