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
    public partial class Main : Form
    {
        public static bool IsLoggedIn;
        public Main()
        {
            InitializeComponent();
        }    

        private void btnContact_Click(object sender, EventArgs e)
        {
            Home contactUs = new Home();
            Hide();
            contactUs.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (IsLoggedIn)
            {
                MyAccount myAccount = new MyAccount();
                Hide();
                myAccount.ShowDialog();
            }
            else
            {
                Login login = new Login();
                Hide();
                login.ShowDialog();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            Hide();
            about.ShowDialog();
        }

        private void btnPrivacy_Click(object sender, EventArgs e)
        {
            Privacy privacy = new Privacy();
            Hide();
            privacy.ShowDialog();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            Rate rate = new Rate();
            Hide();
            rate.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
    }
}
