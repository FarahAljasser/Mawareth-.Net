
namespace Mawareth.Forms
{
    partial class IssueAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.btnAddCon = new System.Windows.Forms.Button();
            this.lblIssue = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "إنشاء مسألة جديدة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المسألة";
            // 
            // txtIssue
            // 
            this.txtIssue.Location = new System.Drawing.Point(27, 149);
            this.txtIssue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(310, 28);
            this.txtIssue.TabIndex = 2;
            // 
            // btnAddCon
            // 
            this.btnAddCon.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCon.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCon.ForeColor = System.Drawing.Color.White;
            this.btnAddCon.Location = new System.Drawing.Point(27, 227);
            this.btnAddCon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCon.Name = "btnAddCon";
            this.btnAddCon.Size = new System.Drawing.Size(310, 41);
            this.btnAddCon.TabIndex = 3;
            this.btnAddCon.Text = "إضافة واستمرار";
            this.btnAddCon.UseVisualStyleBackColor = false;
            this.btnAddCon.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblIssue
            // 
            this.lblIssue.ForeColor = System.Drawing.Color.Red;
            this.lblIssue.Location = new System.Drawing.Point(27, 182);
            this.lblIssue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIssue.Size = new System.Drawing.Size(310, 21);
            this.lblIssue.TabIndex = 18;
            this.lblIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(27, 278);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(310, 41);
            this.btnAddNew.TabIndex = 19;
            this.btnAddNew.Text = "حفظ وإضافة جديدة";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // IssueAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 350);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.btnAddCon);
            this.Controls.Add(this.txtIssue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(386, 389);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(386, 389);
            this.Name = "IssueAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إنشاء مسألة جديدة";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProblemAdd_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Button btnAddCon;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Button btnAddNew;
    }
}