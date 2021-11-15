
namespace Mawareth.Forms
{
    partial class ChangePassword
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtConfirmNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblConfirmNewPass = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(43, 498);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(275, 51);
            this.label7.TabIndex = 32;
            this.label7.Text = "2- ستحذف كل المعلومات المرتبطة بحسابك ولن تستطيع استعادتها";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(42, 423);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(279, 75);
            this.label6.TabIndex = 31;
            this.label6.Text = "1- سيتم حذف الحساب بعد 15 يوم , سيتم الغاء الحذف في حال قمت بتسجيل الدخول خلال هذ" +
    "ه المدة";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDelete.Location = new System.Drawing.Point(144, 386);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDelete.Size = new System.Drawing.Size(85, 25);
            this.lblDelete.TabIndex = 30;
            this.lblDelete.Text = "حذف حسابي";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // txtConfirmNewPass
            // 
            this.txtConfirmNewPass.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPass.Location = new System.Drawing.Point(47, 278);
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.Size = new System.Drawing.Size(274, 32);
            this.txtConfirmNewPass.TabIndex = 28;
            this.txtConfirmNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(46, 250);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "تأكيد كلمة المرور الجديدة *";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(47, 190);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(274, 32);
            this.txtNewPass.TabIndex = 26;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(46, 162);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "كلمة المرور الجديدة *";
            // 
            // txtCurrPass
            // 
            this.txtCurrPass.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrPass.Location = new System.Drawing.Point(47, 103);
            this.txtCurrPass.Name = "txtCurrPass";
            this.txtCurrPass.Size = new System.Drawing.Size(274, 32);
            this.txtCurrPass.TabIndex = 24;
            this.txtCurrPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(42, 75);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "كلمة المرور الحالية *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(92, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(153, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "تغيير كلمة المرور";
            // 
            // lblCurrPass
            // 
            this.lblCurrPass.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrPass.ForeColor = System.Drawing.Color.Red;
            this.lblCurrPass.Location = new System.Drawing.Point(47, 137);
            this.lblCurrPass.Name = "lblCurrPass";
            this.lblCurrPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrPass.Size = new System.Drawing.Size(274, 19);
            this.lblCurrPass.TabIndex = 55;
            this.lblCurrPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewPass
            // 
            this.lblNewPass.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.ForeColor = System.Drawing.Color.Red;
            this.lblNewPass.Location = new System.Drawing.Point(47, 225);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNewPass.Size = new System.Drawing.Size(274, 19);
            this.lblNewPass.TabIndex = 56;
            this.lblNewPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConfirmNewPass
            // 
            this.lblConfirmNewPass.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPass.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmNewPass.Location = new System.Drawing.Point(47, 313);
            this.lblConfirmNewPass.Name = "lblConfirmNewPass";
            this.lblConfirmNewPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblConfirmNewPass.Size = new System.Drawing.Size(274, 19);
            this.lblConfirmNewPass.TabIndex = 57;
            this.lblConfirmNewPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(47, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(274, 40);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 558);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblConfirmNewPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblCurrPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.txtConfirmNewPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 597);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 597);
            this.Name = "ChangePassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغيير كلمة المرور";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePassword_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtConfirmNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblConfirmNewPass;
        private System.Windows.Forms.Button btnSave;
    }
}

