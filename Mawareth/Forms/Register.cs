using Mawareth.Classes;
using Mawareth.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mawareth.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }     

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lblUsername.Text = "اسم المستخدم حقل مطلوب.";
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblUsername.Text = string.Empty;
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
            else
            {
                using (MawarethContext context = new MawarethContext())
                {
                    var user = context.Users.SingleOrDefault(u => u.Email.ToLower().Equals(txtEmail.Text.ToLower()));
                    if (user != null)
                    {
                        lblEmail.Text = "البريد الإلكتروني هذا مستخدم بالقعل.";
                        txtEmail.Focus();
                        return;
                    }
                }
            }
            if (string.IsNullOrEmpty(txtConfirmEmail.Text))
            {
                lblUsername.Text = lblEmail.Text = string.Empty;
                lblConfirmEmail.Text = "تأكيد البريد الإلكتروني حقل مطلوب.";
                txtConfirmEmail.Focus();
                return;
            }
            else if (!txtEmail.Text.Equals(txtConfirmEmail.Text))
            {
                lblError.Text = "البريد الإلكتروني وتأكيد البريد الإلكتروني غير متطابقان.";
                txtConfirmEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblError.Text = lblUsername.Text = lblEmail.Text = lblConfirmEmail.Text = string.Empty;
                lblPassword.Text = "كلمة المرور حقل مطلوب.";
                txtPassword.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                lblUsername.Text = lblEmail.Text = lblConfirmEmail.Text = lblPassword.Text = string.Empty;
                lblConfirmPassword.Text = "تأكيد كلمة المرور حقل مطلوب.";
                txtConfirmPassword.Focus();
                return;
            }
            else if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                lblConfirmPassword.Text = string.Empty;
                lblError.Text = "كلمة المرور وتأكيد كلمة المرور غير متطابقان.";
                txtConfirmPassword.Focus();
                return;
            }
            lblError.Text = lblUsername.Text = lblEmail.Text = lblConfirmEmail.Text =
            lblPassword.Text = lblConfirmPassword.Text = string.Empty;
            using (MawarethContext context = new MawarethContext())
            {
                var user = new User
                {
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    Password = Helpers.EnryptString(txtPassword.Text)
                };
                context.Users.Add(user);
                context.SaveChanges();
                Login login = new Login();
                Hide();
                login.ShowDialog();
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
