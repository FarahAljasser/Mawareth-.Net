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
    public partial class ChangePassword: Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Hide();
            main.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrPass.Text))
            {
                lblCurrPass.Text = "كلمة المرور الحالية حقل مطلوب.";
                return;
            }
            if (string.IsNullOrEmpty(txtNewPass.Text))
            {
                lblCurrPass.Text = string.Empty;
                lblNewPass.Text = "كلمة المرور الجديدة حقل مطلوب.";
                return;
            }
            if (string.IsNullOrEmpty(txtConfirmNewPass.Text))
            {
                lblCurrPass.Text = txtNewPass.Text = string.Empty;
                txtConfirmNewPass.Text = "تأكيد كلمة المرور الجديدة حقل مطلوب.";
                return;
            }
            lblCurrPass.Text = lblNewPass.Text = lblConfirmNewPass.Text = string.Empty;
            if (!txtNewPass.Text.Equals(txtConfirmNewPass.Text))
            {
                txtConfirmNewPass.Text = "كلمة المرور الجديدة وتأكيدها غير متطابقتان.";
                return;
            }
            lblCurrPass.Text = lblNewPass.Text = lblConfirmNewPass.Text = string.Empty;
            using (MawarethContext context = new MawarethContext())
            {
                var user = context.Users.Find(Login.UserId);
                if (user != null)
                {
                    user.Password = Helpers.EnryptString(txtNewPass.Text);
                    context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    DialogResult dialog = MessageBox.Show("تم تغيير كلمة المرور بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        MyAccount myAccount = new MyAccount();
                        Hide();
                        myAccount.ShowDialog();
                    }
                }
            }
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogConfirm = MessageBox.Show("هل تريد بالفعل حذف حسابك ؟", "حذف الحساب", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (dialogConfirm == DialogResult.OK)
            {
                using (MawarethContext context = new MawarethContext())
                {
                    var user = context.Users.Find(Login.UserId);
                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                        DialogResult dialog = MessageBox.Show("لقد تم حذف حسابك بنجاح.", "حذف الحساب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            Hide();
                            Home home = new Home();
                            home.ShowDialog();
                        }
                    }
                }
            }
        }

        private void ChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            myAccount.Show();
        }
    }
}
