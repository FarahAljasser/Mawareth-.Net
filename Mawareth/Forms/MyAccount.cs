using Mawareth.Classes;
using Mawareth.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mawareth.Forms
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }    

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Issue issue = new Issue();
            Hide();
            issue.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            Hide();
            profile.ShowDialog();
        }

        private void btnPrivacy_Click(object sender, EventArgs e)
        {
            Reset reset = new Reset();
            Hide();
            reset.ShowDialog();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("تم تسجيل الخروج بنجاح.", "تسجيل الخروج", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void MyAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
