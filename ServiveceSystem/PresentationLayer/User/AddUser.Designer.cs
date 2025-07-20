namespace ServiveceSystem.PresentationLayer.User
{
    partial class AddUser
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
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            txtPermission = new DevExpress.XtraEditors.TextEdit();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPermission.Properties).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Location = new Point(12, 129);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(315, 27);
            btnSave.TabIndex = 12;
            btnSave.Text = "Add";
            btnSave.Click += btnSave_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(96, 26);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(202, 22);
            txtUsername.TabIndex = 10;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 12F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(6, 54);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(70, 21);
            labelControl3.TabIndex = 9;
            labelControl3.Text = "Password:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 12F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(6, 23);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(77, 21);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "UserName:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(96, 54);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(202, 22);
            txtPassword.TabIndex = 14;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI", 12F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(6, 83);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(80, 21);
            labelControl4.TabIndex = 15;
            labelControl4.Text = "Permission:";
            // 
            // txtPermission
            // 
            txtPermission.EditValue = "";
            txtPermission.Location = new Point(96, 88);
            txtPermission.Name = "txtPermission";
            txtPermission.Size = new Size(202, 22);
            txtPermission.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelControl2);
            groupBox1.Controls.Add(txtPermission);
            groupBox1.Controls.Add(labelControl3);
            groupBox1.Controls.Add(labelControl4);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Location = new Point(12, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 122);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 161);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPermission.Properties).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPermission;
        private GroupBox groupBox1;
    }
}