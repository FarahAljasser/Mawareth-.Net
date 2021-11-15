using Mawareth.Classes;
using Mawareth.Data;
using Mawareth.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mawareth.Forms
{
    public partial class Reset : Form
    {
        private readonly Random _random = new Random();
        private static int Code = 0;
        public Reset()
        {
            InitializeComponent();
        }

        public int RandomNumber()
        {
            return _random.Next(11111, 99999);
        }

        private void btnReset_Click(object sender, EventArgs e)
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
            using (MawarethContext context = new MawarethContext())
            {
                lblEmail.Text = string.Empty;
                var user = context.Users.SingleOrDefault(u => u.Email.ToLower().Equals(txtEmail.Text.ToLower()));
                if (user == null)
                {
                    lblEmail.Text = "هذا البريد الإلكتروني غير موجود.";
                    txtEmail.Focus();
                    return;
                }
                string messageBody = string.Empty;
                using (var sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "reset.html"))
                {
                    messageBody = sr.ReadToEnd();
                }
                messageBody = messageBody.Replace("{0}", user.Username);
                Code = RandomNumber();
                messageBody = messageBody.Replace("{1}", Code.ToString());
                var isSent = EmailSender.Send(txtEmail.Text, messageBody);
                if (isSent)
                {
                    MessageBox.Show("تم الإرسال بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("خطأ، يرجى المحاولة مرة أخرى.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.ShowDialog();
        }

        private void Reset_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                lblCode.Text = "الرمز حقل مطلوب.";
                return;
            }
            lblCode.Text = string.Empty;
            if (Code.ToString().Equals(txtCode.Text))
            {
                ChangePassword changePassword = new ChangePassword();
                Hide();
                changePassword.ShowDialog();
            }
            else
            {
                lblCode.Text = "الرمز المدخل غير صحيح.";
                return;
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            Hide();
            myAccount.ShowDialog();
        }
    }
}
