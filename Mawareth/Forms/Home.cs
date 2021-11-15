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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }    

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (MawarethContext context = new MawarethContext())
                {
                    var contactUs = new Data.ContactUs
                    {
                        Name = txtName.Text,
                        Email = txtEmail.Text,
                        PhoneNumber = txtPhone.Text,
                        Message = txtMessage.Text,
                    };
                    context.ContactUs.Add(contactUs);
                    int i = context.SaveChanges();
                    if (i > 0)
                    {
                        MessageBox.Show("تم الإرسال بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("خطأ، حاول لاحقاً.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProviderContactUs.SetError(txtName, "الاسم حقل مطلوب.");
            }
            else
            {
                e.Cancel = false;
                errorProviderContactUs.SetError(txtName, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProviderContactUs.SetError(txtEmail, "البريد الإلكتروني حقل مطلوب.");
            }
            else if (!Helpers.IsValidEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProviderContactUs.SetError(txtEmail, "صيغة البريد الإلكتروني يجب أن تكون مثل abc@xyz.com");
            }
            else
            {
                e.Cancel = false;
                errorProviderContactUs.SetError(txtEmail, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProviderContactUs.SetError(txtPhone, "رقم الجوال حقل مطلوب.");
            }
            else if (!int.TryParse(txtPhone.Text, out _))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProviderContactUs.SetError(txtPhone, "رقم الجوال يجب أن يحتوي على أرقام فقط.");
            }
            else
            {
                e.Cancel = false;
                errorProviderContactUs.SetError(txtPhone, "");
            }
        }

        private void txtMessage_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                e.Cancel = true;
                txtMessage.Focus();
                errorProviderContactUs.SetError(txtMessage, "الرسالة حقل مطلوب.");
            }
            else
            {
                e.Cancel = false;
                errorProviderContactUs.SetError(txtMessage, "");
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Hide();
            main.ShowDialog();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
