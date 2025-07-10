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
            this.lblContactName = new DevExpress.XtraEditors.LabelControl();
            this.txtContactName = new DevExpress.XtraEditors.TextEdit();
            this.lblContactNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtContactNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblContactEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtContactEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblClinic = new DevExpress.XtraEditors.LabelControl();
            this.cmbClinic = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClinic.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContactName
            // 
            this.lblContactName.Location = new System.Drawing.Point(12, 15);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(75, 13);
            this.lblContactName.TabIndex = 0;
            this.lblContactName.Text = "Contact Name:";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(120, 12);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(200, 20);
            this.txtContactName.TabIndex = 1;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.Location = new System.Drawing.Point(12, 41);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(82, 13);
            this.lblContactNumber.TabIndex = 2;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(120, 38);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(200, 20);
            this.txtContactNumber.TabIndex = 3;
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.Location = new System.Drawing.Point(12, 67);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(70, 13);
            this.lblContactEmail.TabIndex = 4;
            this.lblContactEmail.Text = "Contact Email:";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(120, 64);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(200, 20);
            this.txtContactEmail.TabIndex = 5;
            // 
            // lblClinic
            // 
            this.lblClinic.Location = new System.Drawing.Point(12, 93);
            this.lblClinic.Name = "lblClinic";
            this.lblClinic.Size = new System.Drawing.Size(30, 13);
            this.lblClinic.TabIndex = 6;
            this.lblClinic.Text = "Clinic:";
            // 
            // cmbClinic
            // 
            this.cmbClinic.Location = new System.Drawing.Point(120, 90);
            this.cmbClinic.Name = "cmbClinic";
            this.cmbClinic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbClinic.Size = new System.Drawing.Size(200, 20);
            this.cmbClinic.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Update";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditContactPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 157);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbClinic);
            this.Controls.Add(this.lblClinic);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.lblContactEmail);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.lblContactName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "EditContactPerson";
            this.Text = "Edit Contact Person";
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClinic.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
} 