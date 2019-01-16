using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//need System.Media for the opening sound
using System.Media;

namespace PacMan
{
    public partial class frmSplashScreen : Form
    {
        //declare and initialize the soundplayer
        SoundPlayer Sound = new SoundPlayer("pacman_beginning.wav");

        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            //on frmSplashScreen_Load, play the opening sound
            Console.WriteLine("Form Loaded");
            Sound.Play();
        }

        private void LoadNextForm()
        {
            //open the menu form
            Form frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void frmSplashScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //as soon as any key is pressed, stop the opening sound and call LoadNextForm()
            Sound.Stop();
            LoadNextForm();
        }
    }
}