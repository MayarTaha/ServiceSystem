namespace ServiveceSystem.PresentationLayer.Service
{
    partial class AddService
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
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            txtDescription = new DevExpress.XtraEditors.TextEdit();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            txtName = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            spinPrice = new DevExpress.XtraEditors.SpinEdit();
            SuspendLayout();
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(72, 197);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(112, 25);
            labelControl4.TabIndex = 24;
            labelControl4.Text = "Service Price";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(199, 162);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(132, 20);
            txtDescription.TabIndex = 23;
            // 
            // btnCancel
            // 
            btnCancel.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(256, 256);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 36);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Location = new Point(117, 256);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 36);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(199, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(132, 20);
            txtName.TabIndex = 20;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(72, 156);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(102, 25);
            labelControl3.TabIndex = 19;
            labelControl3.Text = "Description";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(72, 109);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(120, 25);
            labelControl2.TabIndex = 18;
            labelControl2.Text = "Service Name";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(176, 41);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(116, 30);
            labelControl1.TabIndex = 17;
            labelControl1.Text = "Add Service";
            // 
            // spinPrice
            // 
            spinPrice.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinPrice.Location = new Point(199, 203);
            spinPrice.Name = "spinPrice";
            spinPrice.Size = new Size(132, 20);
            spinPrice.TabIndex = 25;
            // 
            // AddService
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 345);
            Controls.Add(spinPrice);
            Controls.Add(labelControl4);
            Controls.Add(txtDescription);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Name = "AddService";
            Text = "AddService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spinPrice;
    }
}