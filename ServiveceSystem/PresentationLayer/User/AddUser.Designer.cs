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
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPermission.Properties).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Location = new Point(87, 160);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 36);
            btnSave.TabIndex = 12;
            btnSave.Text = "Add";
            btnSave.Click += btnSave_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(129, 21);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(132, 20);
            txtUsername.TabIndex = 10;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(13, 62);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(85, 25);
            labelControl3.TabIndex = 9;
            labelControl3.Text = "Password";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(13, 16);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(92, 25);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "UserName";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(129, 67);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(132, 20);
            txtPassword.TabIndex = 14;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(13, 108);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(97, 25);
            labelControl4.TabIndex = 15;
            labelControl4.Text = "Permission";
            // 
            // txtPermission
            // 
            txtPermission.EditValue = "";
            txtPermission.Location = new Point(129, 113);
            txtPermission.Name = "txtPermission";
            txtPermission.Size = new Size(132, 20);
            txtPermission.TabIndex = 16;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 215);
            Controls.Add(txtPermission);
            Controls.Add(labelControl4);
            Controls.Add(txtPassword);
            Controls.Add(btnSave);
            Controls.Add(txtUsername);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUser";
            Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPermission.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}