using Mawareth.Classes;
using Mawareth.Data;
using Mawareth.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mawareth.Forms
{
    public partial class Issue : Form
    {
        private static int IssueId;
        public Issue()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IssueAdd problemAdd = new IssueAdd();
            Hide();
            problemAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (MawarethContext context = new MawarethContext())
            {
                var problem = context.Issues.Find(IssueId);
                if (problem != null)
                {
                    problem.Name = txtProblem.Text;
                    context.Entry(problem).State = EntityState.Modified;
                    context.SaveChanges();
                    DisplayData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MawarethContext context = new MawarethContext())
            {
                var problem = context.Issues.Find(IssueId);
                if (problem != null)
                {
                    context.Issues.Remove(problem);
                    context.SaveChanges();
                    DisplayData();
                }
            }
        }

        private void DisplayData()
        {
            using (MawarethContext context = new MawarethContext())
            {
                var problems = context.Issues.Select(p => new { p.Id, p.Name });
                dgv.DataSource = problems.ToList();
                dgv.Columns[0].HeaderText = "م";
                dgv.Columns[1].HeaderText = "اسم المسألة";
                //dgv.Width = dgv.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
                //          + (dgv.RowHeadersVisible ? dgv.RowHeadersWidth : 0) + 3;
            }
        }

        private void Problem_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IssueId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtProblem.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void Problem_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            myAccount.Show();
        }
    }
}
