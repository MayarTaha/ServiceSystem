namespace ServiveceSystem.PresentationLayer
{
    partial class LoginForm
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
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(213, 217);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 36);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Appearance.Options.UseFont = true;
            btnLogin.Location = new Point(94, 217);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 36);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(176, 108);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(132, 20);
            txtUsername.TabIndex = 10;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(60, 150);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(90, 25);
            labelControl3.TabIndex = 9;
            labelControl3.Text = "Password ";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(60, 103);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(92, 25);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "UserName";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(153, 34);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(56, 30);
            labelControl1.TabIndex = 7;
            labelControl1.Text = "Login";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(176, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(132, 20);
            txtPassword.TabIndex = 14;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 303);
            Controls.Add(txtPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPassword;
    }
}