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
using System.Media;

namespace PacMan
{
    public partial class frmSplashScreen : Form
    {
        private SoundPlayer Sound = new SoundPlayer("pacman_beginning.wav");

        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form Loaded");
            Sound.Play();
        }

        private void LoadNextForm()
        {
            Form frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void frmSplashScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Sound.Stop();
            LoadNextForm();
        }
    }
}