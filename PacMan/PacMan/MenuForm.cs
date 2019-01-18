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

namespace PacMan
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        //when btnLevel1 is clicked, open the level 1 form
        private void btnLevel1_Click(object sender, EventArgs e)
        {
            Form frmCharacterSelect = new frmCharacterSelect(1);
            this.Hide();
            frmCharacterSelect.ShowDialog();
            this.Close();
        }

        //when btnCredits is clicked, open the credits form
        private void btnCredits_Click(object sender, EventArgs e)
        {
            Form frmCredits = new frmCredits();
            this.Hide();
            frmCredits.ShowDialog();
            this.Close();
        }
    }
}