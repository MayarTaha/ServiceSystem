namespace ServiveceSystem.PresentationLayer.Clinic
{
    partial class EditClinic
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ClinicnametextEdit = new DevExpress.XtraEditors.TextEdit();
            PhonetextEdit = new DevExpress.XtraEditors.TextEdit();
            EmailtextEdit = new DevExpress.XtraEditors.TextEdit();
            LocationtextEdit = new DevExpress.XtraEditors.TextEdit();
            CompanyNametextEdit = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            SaveButton = new DevExpress.XtraEditors.SimpleButton();
            errorProvider1 = new ErrorProvider(components);
            dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            labelClinicNameError = new DevExpress.XtraEditors.LabelControl();
            labelCompanynameError = new DevExpress.XtraEditors.LabelControl();
            labelPhoneError = new DevExpress.XtraEditors.LabelControl();
            labelemailerror = new DevExpress.XtraEditors.LabelControl();
            labelLocationError = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)ClinicnametextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhonetextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailtextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LocationtextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompanyNametextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ClinicnametextEdit
            // 
            ClinicnametextEdit.Location = new Point(155, 26);
            ClinicnametextEdit.Name = "ClinicnametextEdit";
            ClinicnametextEdit.Size = new Size(150, 22);
            ClinicnametextEdit.TabIndex = 0;
            // 
            // PhonetextEdit
            // 
            PhonetextEdit.Location = new Point(155, 105);
            PhonetextEdit.Name = "PhonetextEdit";
            PhonetextEdit.Size = new Size(150, 22);
            PhonetextEdit.TabIndex = 2;
            // 
            // EmailtextEdit
            // 
            EmailtextEdit.Location = new Point(155, 149);
            EmailtextEdit.Name = "EmailtextEdit";
            EmailtextEdit.Size = new Size(150, 22);
            EmailtextEdit.TabIndex = 3;
            // 
            // LocationtextEdit
            // 
            LocationtextEdit.Location = new Point(155, 188);
            LocationtextEdit.Name = "LocationtextEdit";
            LocationtextEdit.Size = new Size(150, 22);
            LocationtextEdit.TabIndex = 4;
            // 
            // CompanyNametextEdit
            // 
            CompanyNametextEdit.Location = new Point(155, 66);
            CompanyNametextEdit.Name = "CompanyNametextEdit";
            CompanyNametextEdit.Size = new Size(150, 22);
            CompanyNametextEdit.TabIndex = 5;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelControl2.Appearance.ForeColor = Color.Black;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(22, 26);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(74, 17);
            labelControl2.TabIndex = 6;
            labelControl2.Text = "Clinic Name";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelControl3.Appearance.ForeColor = Color.Black;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(22, 64);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(98, 17);
            labelControl3.TabIndex = 7;
            labelControl3.Text = "Company Name";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelControl4.Appearance.ForeColor = Color.Black;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.Location = new Point(22, 105);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(39, 17);
            labelControl4.TabIndex = 8;
            labelControl4.Text = "Phone";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelControl5.Appearance.ForeColor = Color.Black;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseForeColor = true;
            labelControl5.Location = new Point(22, 147);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(34, 17);
            labelControl5.TabIndex = 9;
            labelControl5.Text = "Email";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelControl6.Appearance.ForeColor = Color.Black;
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Appearance.Options.UseForeColor = true;
            labelControl6.Location = new Point(22, 186);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(53, 17);
            labelControl6.TabIndex = 10;
            labelControl6.Text = "Location";
            // 
            // SaveButton
            // 
            SaveButton.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            SaveButton.Appearance.Options.UseFont = true;
            SaveButton.Location = new Point(106, 244);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(112, 32);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Save";
            SaveButton.Click += SaveButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dxErrorProvider1
            // 
            dxErrorProvider1.ContainerControl = this;
            // 
            // labelClinicNameError
            // 
            labelClinicNameError.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelClinicNameError.Appearance.ForeColor = Color.Red;
            labelClinicNameError.Appearance.Options.UseFont = true;
            labelClinicNameError.Appearance.Options.UseForeColor = true;
            labelClinicNameError.Location = new Point(162, 47);
            labelClinicNameError.Name = "labelClinicNameError";
            labelClinicNameError.Size = new Size(70, 13);
            labelClinicNameError.TabIndex = 13;
            labelClinicNameError.Text = "labelControl7";
            labelClinicNameError.Visible = false;
            // 
            // labelCompanynameError
            // 
            labelCompanynameError.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelCompanynameError.Appearance.ForeColor = Color.Red;
            labelCompanynameError.Appearance.Options.UseFont = true;
            labelCompanynameError.Appearance.Options.UseForeColor = true;
            labelCompanynameError.Location = new Point(162, 87);
            labelCompanynameError.Name = "labelCompanynameError";
            labelCompanynameError.Size = new Size(70, 13);
            labelCompanynameError.TabIndex = 14;
            labelCompanynameError.Text = "labelControl8";
            labelCompanynameError.Visible = false;
            // 
            // labelPhoneError
            // 
            labelPhoneError.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelPhoneError.Appearance.ForeColor = Color.Red;
            labelPhoneError.Appearance.Options.UseFont = true;
            labelPhoneError.Appearance.Options.UseForeColor = true;
            labelPhoneError.Location = new Point(162, 127);
            labelPhoneError.Name = "labelPhoneError";
            labelPhoneError.Size = new Size(70, 13);
            labelPhoneError.TabIndex = 15;
            labelPhoneError.Text = "labelControl9";
            labelPhoneError.Visible = false;
            // 
            // labelemailerror
            // 
            labelemailerror.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelemailerror.Appearance.ForeColor = Color.Red;
            labelemailerror.Appearance.Options.UseFont = true;
            labelemailerror.Appearance.Options.UseForeColor = true;
            labelemailerror.Location = new Point(162, 171);
            labelemailerror.Name = "labelemailerror";
            labelemailerror.Size = new Size(76, 13);
            labelemailerror.TabIndex = 16;
            labelemailerror.Text = "labelControl10";
            labelemailerror.Visible = false;
            // 
            // labelLocationError
            // 
            labelLocationError.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelLocationError.Appearance.ForeColor = Color.Red;
            labelLocationError.Appearance.Options.UseFont = true;
            labelLocationError.Appearance.Options.UseForeColor = true;
            labelLocationError.Location = new Point(162, 210);
            labelLocationError.Name = "labelLocationError";
            labelLocationError.Size = new Size(76, 13);
            labelLocationError.TabIndex = 17;
            labelLocationError.Text = "labelControl11";
            labelLocationError.Visible = false;
            // 
            // EditClinic
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 285);
            Controls.Add(ClinicnametextEdit);
            Controls.Add(PhonetextEdit);
            Controls.Add(EmailtextEdit);
            Controls.Add(LocationtextEdit);
            Controls.Add(CompanyNametextEdit);
            Controls.Add(labelControl2);
            Controls.Add(labelControl3);
            Controls.Add(labelControl4);
            Controls.Add(labelControl5);
            Controls.Add(labelControl6);
            Controls.Add(SaveButton);
            Controls.Add(labelClinicNameError);
            Controls.Add(labelCompanynameError);
            Controls.Add(labelPhoneError);
            Controls.Add(labelemailerror);
            Controls.Add(labelLocationError);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditClinic";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Clinic";
            ((System.ComponentModel.ISupportInitialize)ClinicnametextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhonetextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailtextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LocationtextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompanyNametextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private DevExpress.XtraEditors.TextEdit ClinicnametextEdit;
        private DevExpress.XtraEditors.TextEdit PhonetextEdit;
        private DevExpress.XtraEditors.TextEdit EmailtextEdit;
        private DevExpress.XtraEditors.TextEdit LocationtextEdit;
        private DevExpress.XtraEditors.TextEdit CompanyNametextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.LabelControl labelClinicNameError;
        private DevExpress.XtraEditors.LabelControl labelCompanynameError;
        private DevExpress.XtraEditors.LabelControl labelPhoneError;
        private DevExpress.XtraEditors.LabelControl labelemailerror;
        private DevExpress.XtraEditors.LabelControl labelLocationError;
    }
} 