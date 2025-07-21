namespace ServiveceSystem.PresentationLayer.User
{
    partial class EditUser
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
            lblUsername = new DevExpress.XtraEditors.LabelControl();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            lblRole = new DevExpress.XtraEditors.LabelControl();
            txtRole = new DevExpress.XtraEditors.TextEdit();
            lblPassword = new DevExpress.XtraEditors.LabelControl();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRole.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Appearance.Font = new Font("Segoe UI", 12F);
            lblUsername.Appearance.Options.UseFont = true;
            lblUsername.Location = new Point(6, 21);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(74, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(139, 20);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 22);
            txtUsername.TabIndex = 1;
            // 
            // lblRole
            // 
            lblRole.Appearance.Font = new Font("Segoe UI", 12F);
            lblRole.Appearance.Options.UseFont = true;
            lblRole.Location = new Point(6, 79);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(80, 21);
            lblRole.TabIndex = 4;
            lblRole.Text = "Permission:";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(139, 84);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(200, 22);
            txtRole.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.Appearance.Font = new Font("Segoe UI", 12F);
            lblPassword.Appearance.Options.UseFont = true;
            lblPassword.Location = new Point(6, 52);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(127, 21);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Change Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(139, 51);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.UseSystemPasswordChar = true;
            txtPassword.Size = new Size(200, 22);
            txtPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 127);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(349, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Update";
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(lblRole);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(txtRole);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 118);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 161);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit User";
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRole.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl lblRole;
        private DevExpress.XtraEditors.TextEdit txtRole;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private GroupBox groupBox1;
    }
} 