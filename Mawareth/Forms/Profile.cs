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
    public partial class Profile: Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            cmbMaritalStstus.SelectedIndex = 0;
            cmbNationality.SelectedIndex = 0;
            var x = cmbMaritalStstus.Items[0].ToString();
            using (MawarethContext context = new MawarethContext())
            {
                var user = context.Users.Find(Login.UserId);
                if (user != null)
                {
                    txtUserName.Text = user.Username;
                    if (user.MaritalStatus != null)
                    {
                        for (int i = 0; i < cmbMaritalStstus.Items.Count; i++)
                        {
                            if (user.MaritalStatus.Equals(cmbMaritalStstus.Items[i].ToString()))
                            {
                                cmbMaritalStstus.SelectedIndex = i;
                            }
                        }
                    }
                    if (user.Nationality != null)
                    {
                        for (int i = 0; i < cmbNationality.Items.Count; i++)
                        {
                            if (user.Nationality.Equals(cmbNationality.Items[i].ToString()))
                            {
                                cmbNationality.SelectedIndex = i;
                            }
                        }
                    }
                    txtCountry.Text = user.Country;
                    DOB.Value = user.DOB ?? DOB.Value;
                    txtID.Text = user.Identity;
                    if (user.Gender.Equals(radMale.Text))
                    {
                        radMale.Checked = true;
                    }
                    else if (user.Gender.Equals(radFemale.Text))
                    {
                        radFemale.Checked = true;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                lblUsername.Text = "اسم المستخدم حقل مطللوب.";
                return;
            }
            if (!radMale.Checked && !radFemale.Checked)
            {
                lblUsername.Text = string.Empty;
                lblGender.Text = "الجنس حقل مطللوب.";
                return;
            }
            if (string.IsNullOrEmpty(txtCountry.Text))
            {
                lblUsername.Text = lblGender.Text = string.Empty;
                lblCountry.Text = "البلد حقل مطللوب.";
                return;
            }
            if (string.IsNullOrEmpty(txtID.Text))
            {
                lblUsername.Text = lblGender.Text = lblCountry.Text = string.Empty;
                lblID.Text = "رقم الهوية الوطنية حقل مطللوب.";
                return;
            }
            lblUsername.Text = lblGender.Text = lblCountry.Text = lblID.Text = string.Empty;
            string gender = string.Empty;
            if (radMale.Checked)
            {
                gender = radMale.Text;
            }
            else if (radFemale.Checked)
            {
                gender = radFemale.Text;
            }
            using (MawarethContext context = new MawarethContext())
            {
                var user = context.Users.Find(Login.UserId);
                if (user != null)
                {
                    user.Username = txtUserName.Text;
                    user.MaritalStatus = cmbMaritalStstus.Text;
                    user.Gender = gender;
                    user.Nationality = cmbNationality.Text;
                    user.Country = txtCountry.Text;
                    user.DOB = DOB.Value;
                    user.Identity = txtID.Text;
                    context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    MyAccount myAccount = new MyAccount();
                    Hide();
                    myAccount.Show();
                }
            }
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            myAccount.Show();
        }
    }
}
