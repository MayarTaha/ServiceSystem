namespace ServiveceSystem.PresentationLayer.ContactPerson
{
    partial class AddContactPerson
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
            labelemailerror = new DevExpress.XtraEditors.LabelControl();
            labelPhoneError = new DevExpress.XtraEditors.LabelControl();
            labelNameError = new DevExpress.XtraEditors.LabelControl();
            CancelButton = new DevExpress.XtraEditors.SimpleButton();
            SaveContactButton = new DevExpress.XtraEditors.SimpleButton();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            EmailtextEdit = new DevExpress.XtraEditors.TextEdit();
            PhonetextEdit = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            nametextEdit = new DevExpress.XtraEditors.TextEdit();
            ClinicLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ClinicLookUpEditErrorlabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)EmailtextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhonetextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nametextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClinicLookUpEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelemailerror
            // 
            labelemailerror.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelemailerror.Appearance.ForeColor = Color.Red;
            labelemailerror.Appearance.Options.UseFont = true;
            labelemailerror.Appearance.Options.UseForeColor = true;
            labelemailerror.Location = new Point(352, 342);
            labelemailerror.Name = "labelemailerror";
            labelemailerror.Size = new Size(104, 21);
            labelemailerror.TabIndex = 34;
            labelemailerror.Text = "labelControl7";
            labelemailerror.Visible = false;
            // 
            // labelPhoneError
            // 
            labelPhoneError.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelPhoneError.Appearance.ForeColor = Color.Red;
            labelPhoneError.Appearance.Options.UseFont = true;
            labelPhoneError.Appearance.Options.UseForeColor = true;
            labelPhoneError.Location = new Point(352, 254);
            labelPhoneError.Name = "labelPhoneError";
            labelPhoneError.Size = new Size(104, 21);
            labelPhoneError.TabIndex = 33;
            labelPhoneError.Text = "labelControl7";
            labelPhoneError.Visible = false;
            // 
            // labelNameError
            // 
            labelNameError.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNameError.Appearance.ForeColor = Color.Red;
            labelNameError.Appearance.Options.UseFont = true;
            labelNameError.Appearance.Options.UseForeColor = true;
            labelNameError.Location = new Point(352, 167);
            labelNameError.Name = "labelNameError";
            labelNameError.Size = new Size(104, 21);
            labelNameError.TabIndex = 31;
            labelNameError.Text = "labelControl7";
            labelNameError.Visible = false;
            // 
            // CancelButton
            // 
            CancelButton.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.Appearance.Options.UseFont = true;
            CancelButton.Location = new Point(363, 486);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(168, 51);
            CancelButton.TabIndex = 30;
            CancelButton.Text = "Cancel";
            // 
            // SaveContactButton
            // 
            SaveContactButton.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveContactButton.Appearance.Options.UseFont = true;
            SaveContactButton.Location = new Point(162, 486);
            SaveContactButton.Name = "SaveContactButton";
            SaveContactButton.Size = new Size(168, 51);
            SaveContactButton.TabIndex = 29;
            SaveContactButton.Text = "Save";
            SaveContactButton.Click += SaveContactButton_Click;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl5.Appearance.ForeColor = Color.Black;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseForeColor = true;
            labelControl5.Location = new Point(142, 295);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(52, 28);
            labelControl5.TabIndex = 27;
            labelControl5.Text = "Email";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl4.Appearance.ForeColor = Color.Black;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.Location = new Point(142, 208);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(59, 28);
            labelControl4.TabIndex = 26;
            labelControl4.Text = "Phone";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = Color.Black;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(142, 133);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(56, 28);
            labelControl2.TabIndex = 24;
            labelControl2.Text = "Name";
            // 
            // EmailtextEdit
            // 
            EmailtextEdit.Location = new Point(342, 298);
            EmailtextEdit.Name = "EmailtextEdit";
            EmailtextEdit.Size = new Size(225, 28);
            EmailtextEdit.TabIndex = 21;
            // 
            // PhonetextEdit
            // 
            PhonetextEdit.Location = new Point(342, 211);
            PhonetextEdit.Name = "PhonetextEdit";
            PhonetextEdit.Size = new Size(225, 28);
            PhonetextEdit.TabIndex = 20;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = Color.Black;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(241, 36);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(171, 38);
            labelControl1.TabIndex = 19;
            labelControl1.Text = "Add Contact ";
            // 
            // nametextEdit
            // 
            nametextEdit.Location = new Point(342, 133);
            nametextEdit.Name = "nametextEdit";
            nametextEdit.Size = new Size(225, 28);
            nametextEdit.TabIndex = 18;
            // 
            // ClinicLookUpEdit
            // 
            ClinicLookUpEdit.Location = new Point(342, 384);
            ClinicLookUpEdit.Name = "ClinicLookUpEdit";
            ClinicLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ClinicLookUpEdit.Size = new Size(225, 28);
            ClinicLookUpEdit.TabIndex = 35;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl3.Appearance.ForeColor = Color.Black;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(142, 381);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(114, 28);
            labelControl3.TabIndex = 36;
            labelControl3.Text = "Clinic Name";
            // 
            // ClinicLookUpEditErrorlabel
            // 
            ClinicLookUpEditErrorlabel.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            ClinicLookUpEditErrorlabel.Appearance.ForeColor = Color.Red;
            ClinicLookUpEditErrorlabel.Appearance.Options.UseFont = true;
            ClinicLookUpEditErrorlabel.Appearance.Options.UseForeColor = true;
            ClinicLookUpEditErrorlabel.Location = new Point(352, 418);
            ClinicLookUpEditErrorlabel.Name = "ClinicLookUpEditErrorlabel";
            ClinicLookUpEditErrorlabel.Size = new Size(104, 21);
            ClinicLookUpEditErrorlabel.TabIndex = 37;
            ClinicLookUpEditErrorlabel.Text = "labelControl7";
            ClinicLookUpEditErrorlabel.Visible = false;
            // 
            // AddContactPerson
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 577);
            Controls.Add(ClinicLookUpEditErrorlabel);
            Controls.Add(labelControl3);
            Controls.Add(ClinicLookUpEdit);
            Controls.Add(labelemailerror);
            Controls.Add(labelPhoneError);
            Controls.Add(labelNameError);
            Controls.Add(CancelButton);
            Controls.Add(SaveContactButton);
            Controls.Add(labelControl5);
            Controls.Add(labelControl4);
            Controls.Add(labelControl2);
            Controls.Add(EmailtextEdit);
            Controls.Add(PhonetextEdit);
            Controls.Add(labelControl1);
            Controls.Add(nametextEdit);
            Name = "AddContactPerson";
            Text = "AddContactPerson";
            ((System.ComponentModel.ISupportInitialize)EmailtextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhonetextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)nametextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClinicLookUpEdit.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelemailerror;
        private DevExpress.XtraEditors.LabelControl labelPhoneError;
        private DevExpress.XtraEditors.LabelControl labelNameError;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.SimpleButton SaveContactButton;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit EmailtextEdit;
        private DevExpress.XtraEditors.TextEdit PhonetextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit nametextEdit;
        private DevExpress.XtraEditors.LookUpEdit ClinicLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl ClinicLookUpEditErrorlabel;
    }
}