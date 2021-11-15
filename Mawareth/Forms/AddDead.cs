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
    public partial class AddDead : Form
    {
        public static string DeadName;
        public static double Value;
        public AddDead()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFName.Text))
            {
                lblFName.Text = "الأسم الأول حقل مطلوب.";
                txtFName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtLName.Text))
            {
                lblFName.Text = string.Empty;
                lblLName.Text = "الأسم الأخير حقل مطلوب.";
                txtLName.Focus();
                return;
            }
            if (numValue.Value <= 0)
            {
                lblFName.Text = lblLName.Text = string.Empty;
                lblValue.Text = "المبلغ المتروك حقل مطلوب.";
                numValue.Focus();
                return;
            }
            lblFName.Text = lblLName.Text = lblValue.Text = string.Empty;
            DeadName = $"{txtFName.Text} {txtLName.Text}";
            Value = (double)numValue.Value;
            if (Login.IsVisitor)
            {
                Operations operations = new Operations();
                Hide();
                operations.ShowDialog();
            }
            using (MawarethContext context = new MawarethContext())
            {
                if (IssueAdd.IssueId > 0)
                {
                    var dead = new Dead
                    {
                        FirstName = txtFName.Text,
                        LastName = txtLName.Text,
                        Gender = cmbGender.SelectedItem.ToString(),
                        Value = (double)numValue.Value,
                        IssueId = IssueAdd.IssueId
                    };
                    context.Deads.Add(dead);
                    context.SaveChanges();
                    Operations operations = new Operations();
                    Hide();
                    operations.ShowDialog();
                }
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddDead_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
            txtIssue.Text = IssueAdd.IssueName;
        }

        private void AddDead_FormClosed(object sender, FormClosedEventArgs e)
        {
            Issue issue = new Issue();
            issue.Show();
        }
    }
}
