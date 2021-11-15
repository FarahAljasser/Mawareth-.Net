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
    public partial class Login : Form
    {
        public static int UserId;
        public static bool IsVisitor = false;
        public Login()
        {
            InitializeComponent();
        }    

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmail.Text = "البريد الإلكتروني حقل مطلوب.";
                txtEmail.Focus();
                return;
            }
            else if (!Helpers.IsValidEmail(txtEmail.Text))
            {
                lblEmail.Text = "صيغة البريد الإلكتروني يجب أن تكون مثل abc@xyz.com";
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblEmail.Text = string.Empty;
                lblPassword.Text = "كلمة المرور حقل مطلوب.";
                txtPassword.Focus();
                return;
            }
            lblPassword.Text = string.Empty;
            using (MawarethContext context = new MawarethContext())
            {
                var user = context.Users.SingleOrDefault(u => u.Email.ToLower().Equals(txtEmail.Text.ToLower()));
                if (user == null)
                {
                    lblError.Text = "خطأ في البريد الإلكتروني أو كلمة المرور.";
                    return;
                }
                UserId = user.Id;
                var decryptedPassword = Helpers.DecryptString(user.Password);
                if (decryptedPassword.Equals(txtPassword.Text))
                {
                    lblError.Text = string.Empty;
                    Main.IsLoggedIn = true;
                    MyAccount myAccount = new MyAccount();
                    Hide();
                    myAccount.ShowDialog();
                }
                else
                {
                    lblError.Text = "خطأ في البريد الإلكتروني أو كلمة المرور.";
                    return;
                }
            }
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            IsVisitor = true;
            IssueAdd issueAdd = new IssueAdd();
            Hide();
            issueAdd.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            Hide();
            register.ShowDialog();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            Reset reset = new Reset();
            Hide();
            reset.ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            myAccount.Show();
        }
    }
}
