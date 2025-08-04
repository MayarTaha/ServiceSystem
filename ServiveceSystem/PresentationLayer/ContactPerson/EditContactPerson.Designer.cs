namespace ServiveceSystem.PresentationLayer.ContactPerson
{
    partial class EditContactPerson
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
            lblContactName = new DevExpress.XtraEditors.LabelControl();
            txtContactName = new DevExpress.XtraEditors.TextEdit();
            lblContactNumber = new DevExpress.XtraEditors.LabelControl();
            txtContactNumber = new DevExpress.XtraEditors.TextEdit();
            lblContactEmail = new DevExpress.XtraEditors.LabelControl();
            txtContactEmail = new DevExpress.XtraEditors.TextEdit();
            lblClinic = new DevExpress.XtraEditors.LabelControl();
            cmbClinic = new DevExpress.XtraEditors.ComboBoxEdit();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            groupBox1 = new GroupBox();
            ClinicLookUpEditErrorlabel = new DevExpress.XtraEditors.LabelControl();
            labelemailerror = new DevExpress.XtraEditors.LabelControl();
            labelPhoneError = new DevExpress.XtraEditors.LabelControl();
            labelNameError = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtContactName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtContactNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtContactEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbClinic.Properties).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblContactName
            // 
            lblContactName.Location = new Point(8, 24);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(75, 13);
            lblContactName.TabIndex = 0;
            lblContactName.Text = "Contact Name:";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(116, 21);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(200, 22);
            txtContactName.TabIndex = 1;
            // 
            // lblContactNumber
            // 
            lblContactNumber.Location = new Point(8, 67);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(87, 13);
            lblContactNumber.TabIndex = 2;
            lblContactNumber.Text = "Contact Number:";
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(116, 64);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(200, 22);
            txtContactNumber.TabIndex = 3;
            // 
            // lblContactEmail
            // 
            lblContactEmail.Location = new Point(7, 107);
            lblContactEmail.Name = "lblContactEmail";
            lblContactEmail.Size = new Size(73, 13);
            lblContactEmail.TabIndex = 4;
            lblContactEmail.Text = "Contact Email:";
            // 
            // txtContactEmail
            // 
            txtContactEmail.Location = new Point(115, 104);
            txtContactEmail.Name = "txtContactEmail";
            txtContactEmail.Size = new Size(200, 22);
            txtContactEmail.TabIndex = 5;
            // 
            // lblClinic
            // 
            lblClinic.Location = new Point(7, 148);
            lblClinic.Name = "lblClinic";
            lblClinic.Size = new Size(31, 13);
            lblClinic.TabIndex = 6;
            lblClinic.Text = "Clinic:";
            // 
            // cmbClinic
            // 
            cmbClinic.Location = new Point(115, 145);
            cmbClinic.Name = "cmbClinic";
            cmbClinic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbClinic.Size = new Size(200, 22);
            cmbClinic.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 198);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(321, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Update";
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ClinicLookUpEditErrorlabel);
            groupBox1.Controls.Add(labelemailerror);
            groupBox1.Controls.Add(labelPhoneError);
            groupBox1.Controls.Add(labelNameError);
            groupBox1.Controls.Add(txtContactName);
            groupBox1.Controls.Add(lblContactName);
            groupBox1.Controls.Add(cmbClinic);
            groupBox1.Controls.Add(lblContactNumber);
            groupBox1.Controls.Add(lblClinic);
            groupBox1.Controls.Add(txtContactNumber);
            groupBox1.Controls.Add(txtContactEmail);
            groupBox1.Controls.Add(lblContactEmail);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 189);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // ClinicLookUpEditErrorlabel
            // 
            ClinicLookUpEditErrorlabel.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            ClinicLookUpEditErrorlabel.Appearance.ForeColor = Color.Red;
            ClinicLookUpEditErrorlabel.Appearance.Options.UseFont = true;
            ClinicLookUpEditErrorlabel.Appearance.Options.UseForeColor = true;
            ClinicLookUpEditErrorlabel.Location = new Point(128, 171);
            ClinicLookUpEditErrorlabel.Margin = new Padding(2);
            ClinicLookUpEditErrorlabel.Name = "ClinicLookUpEditErrorlabel";
            ClinicLookUpEditErrorlabel.Size = new Size(70, 13);
            ClinicLookUpEditErrorlabel.TabIndex = 38;
            ClinicLookUpEditErrorlabel.Text = "labelControl7";
            ClinicLookUpEditErrorlabel.Visible = false;
            // 
            // labelemailerror
            // 
            labelemailerror.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelemailerror.Appearance.ForeColor = Color.Red;
            labelemailerror.Appearance.Options.UseFont = true;
            labelemailerror.Appearance.Options.UseForeColor = true;
            labelemailerror.Location = new Point(128, 131);
            labelemailerror.Margin = new Padding(2);
            labelemailerror.Name = "labelemailerror";
            labelemailerror.Size = new Size(70, 13);
            labelemailerror.TabIndex = 35;
            labelemailerror.Text = "labelControl7";
            labelemailerror.Visible = false;
            // 
            // labelPhoneError
            // 
            labelPhoneError.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelPhoneError.Appearance.ForeColor = Color.Red;
            labelPhoneError.Appearance.Options.UseFont = true;
            labelPhoneError.Appearance.Options.UseForeColor = true;
            labelPhoneError.Location = new Point(128, 91);
            labelPhoneError.Margin = new Padding(2);
            labelPhoneError.Name = "labelPhoneError";
            labelPhoneError.Size = new Size(70, 13);
            labelPhoneError.TabIndex = 34;
            labelPhoneError.Text = "labelControl7";
            labelPhoneError.Visible = false;
            // 
            // labelNameError
            // 
            labelNameError.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNameError.Appearance.ForeColor = Color.Red;
            labelNameError.Appearance.Options.UseFont = true;
            labelNameError.Appearance.Options.UseForeColor = true;
            labelNameError.Location = new Point(128, 48);
            labelNameError.Margin = new Padding(2);
            labelNameError.Name = "labelNameError";
            labelNameError.Size = new Size(70, 13);
            labelNameError.TabIndex = 32;
            labelNameError.Text = "labelControl7";
            labelNameError.Visible = false;
            // 
            // EditContactPerson
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 224);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditContactPerson";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Contact Person";
            ((System.ComponentModel.ISupportInitialize)txtContactName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtContactNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtContactEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbClinic.Properties).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblContactName;
        private DevExpress.XtraEditors.TextEdit txtContactName;
        private DevExpress.XtraEditors.LabelControl lblContactNumber;
        private DevExpress.XtraEditors.TextEdit txtContactNumber;
        private DevExpress.XtraEditors.LabelControl lblContactEmail;
        private DevExpress.XtraEditors.TextEdit txtContactEmail;
        private DevExpress.XtraEditors.LabelControl lblClinic;
        private DevExpress.XtraEditors.ComboBoxEdit cmbClinic;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelNameError;
        private DevExpress.XtraEditors.LabelControl labelPhoneError;
        private DevExpress.XtraEditors.LabelControl labelemailerror;
        private DevExpress.XtraEditors.LabelControl ClinicLookUpEditErrorlabel;
    }
} 