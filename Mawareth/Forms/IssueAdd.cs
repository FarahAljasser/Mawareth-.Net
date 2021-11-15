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
    public partial class IssueAdd : Form
    {
        public static int IssueId;
        public static string IssueName;
        public IssueAdd()
        {
            InitializeComponent();
        }

        private int AddIssue(string name)
        {
            using (MawarethContext context = new MawarethContext())
            {
                var problem = new Data.Issue
                {
                    Name = name,
                    UserId = Login.UserId
                };
                context.Issues.Add(problem);
                context.SaveChanges();
                return problem.Id;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIssue.Text))
            {
                lblIssue.Text = "اسم المسألة حقل مطلوب.";
                txtIssue.Focus();
                return;
            }
            if (!Login.IsVisitor)
            {
                IssueId = AddIssue(txtIssue.Text);
            }
            if (IssueId > 0 || Login.IsVisitor)
            {
                IssueName = txtIssue.Text;
                AddDead addDead = new AddDead();
                Hide();
                addDead.ShowDialog();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (Login.IsVisitor)
            {
                DialogResult dialog = MessageBox.Show("لايمكنك إتمام هذه العملية، لابد من تسجيل الدخول.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    Login login = new Login();
                    Hide();
                    login.ShowDialog();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtIssue.Text))
                {
                    lblIssue.Text = "اسم المسألة حقل مطلوب.";
                    txtIssue.Focus();
                    return;
                }
                IssueId = AddIssue(txtIssue.Text);
                txtIssue.Text = lblIssue.Text = string.Empty;
            }
        }

        private void ProblemAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Issue issue = new Issue();
            issue.Show();
        }
    }
}
