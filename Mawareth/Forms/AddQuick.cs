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
    public partial class AddQuick : Form
    {
        public AddQuick()
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
                lblLName.Text = "الأسم الأخير حقل مطلوب.";
                txtLName.Focus();
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
