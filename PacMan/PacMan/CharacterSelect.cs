using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class frmCharacterSelect : Form
    {
        public frmCharacterSelect()
        {
            InitializeComponent();
        }

        private void picZach_Click(object sender, EventArgs e)
        {
            //pacman is only used for the starting position
            bool pacman = false;

            //opening the level 1 form and passing it the character images it needs
            Form frmLevel1 = new frmLevel1(pacman, Properties.Resources.zachup, Properties.Resources.zachright,
                Properties.Resources.zachdown, Properties.Resources.zachleft);
            this.Hide();
            frmLevel1.ShowDialog();
            this.Close();
        }

        private void picMissPacMan_Click(object sender, EventArgs e)
        {
            bool pacman = true;
            Image characterDown = Properties.Resources.down;

            //opening the level 1 form and passing it the character images it needs
            Form frmLevel1 = new frmLevel1(pacman, characterDown, Properties.Resources.Right,
                Properties.Resources.down, Properties.Resources.Left);
            this.Hide();
            frmLevel1.ShowDialog();
            this.Close();
        }

        private void picMohammed_Click(object sender, EventArgs e)
        {
            bool pacman = false;
            //opening the level 1 form and passing it the character images it needs
            Form frmLevel1 = new frmLevel1(pacman, Properties.Resources.Mohammed, Properties.Resources.Mohammed,
                Properties.Resources.Mohammed, Properties.Resources.Mohammed);
            this.Hide();
            frmLevel1.ShowDialog();
            this.Close();
        }
    }
}