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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            groupBox1 = new GroupBox();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            btnShowPassword = new DevExpress.XtraEditors.SimpleButton();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Appearance.Options.UseFont = true;
            btnLogin.Location = new Point(12, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(284, 36);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelControl2);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(labelControl3);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(btnShowPassword);
            groupBox1.Location = new Point(12, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 141);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(14, 27);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(92, 25);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "UserName";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(131, 71);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(132, 22);
            txtPassword.TabIndex = 14;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(16, 75);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(90, 25);
            labelControl3.TabIndex = 9;
            labelControl3.Text = "Password ";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(131, 32);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(132, 22);
            txtUsername.TabIndex = 10;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Location = new Point(131, 105);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(132, 22);
            btnShowPassword.TabIndex = 15;
            btnShowPassword.Text = "Show Password";
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // pictureEdit1
            // 
            pictureEdit1.BackgroundImage = (Image)resources.GetObject("pictureEdit1.BackgroundImage");
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new Point(12, 12);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit1.Size = new Size(285, 138);
            pictureEdit1.TabIndex = 16;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 370);
            Controls.Add(pictureEdit1);
            Controls.Add(groupBox1);
            Controls.Add(btnLogin);
            Font = new Font("Segoe UI", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnShowPassword;
    }
}