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
            lblContactNumber.Location = new Point(8, 50);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(87, 13);
            lblContactNumber.TabIndex = 2;
            lblContactNumber.Text = "Contact Number:";
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(116, 47);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(200, 22);
            txtContactNumber.TabIndex = 3;
            // 
            // lblContactEmail
            // 
            lblContactEmail.Location = new Point(8, 76);
            lblContactEmail.Name = "lblContactEmail";
            lblContactEmail.Size = new Size(73, 13);
            lblContactEmail.TabIndex = 4;
            lblContactEmail.Text = "Contact Email:";
            // 
            // txtContactEmail
            // 
            txtContactEmail.Location = new Point(116, 73);
            txtContactEmail.Name = "txtContactEmail";
            txtContactEmail.Size = new Size(200, 22);
            txtContactEmail.TabIndex = 5;
            // 
            // lblClinic
            // 
            lblClinic.Location = new Point(8, 102);
            lblClinic.Name = "lblClinic";
            lblClinic.Size = new Size(31, 13);
            lblClinic.TabIndex = 6;
            lblClinic.Text = "Clinic:";
            // 
            // cmbClinic
            // 
            cmbClinic.Location = new Point(116, 99);
            cmbClinic.Name = "cmbClinic";
            cmbClinic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbClinic.Size = new Size(200, 22);
            cmbClinic.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 132);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(321, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Update";
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
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
            groupBox1.Size = new Size(321, 123);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // EditContactPerson
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 161);
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
    }
} 