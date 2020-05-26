using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blizzard
{
    public partial class BlizzardLogin : Form
    {
        public BlizzardLogin()
        {
            InitializeComponent();
        }

        private void getKey_Click(object sender, EventArgs e)
        {
            Process.Start("https://invite.gg/t3chyy");
        }


        private void login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Blizzard2020")
            {
                MessageBox.Show("Login successful. Thank you for choosing Blizzard.", "Blizzard", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BlizzardWindow BlizzardWindow = new BlizzardWindow();
                BlizzardWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong key!", "Blizzard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
