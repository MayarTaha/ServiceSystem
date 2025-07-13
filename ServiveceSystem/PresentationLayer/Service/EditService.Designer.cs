namespace ServiveceSystem.PresentationLayer.Service
{
    partial class EditService
    {
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.SpinEdit spinPrice;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtName = new DevExpress.XtraEditors.TextEdit();
            txtDescription = new DevExpress.XtraEditors.MemoEdit();
            spinPrice = new DevExpress.XtraEditors.SpinEdit();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinPrice.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(103, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 22);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(103, 52);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(171, 52);
            txtDescription.TabIndex = 1;
            // 
            // spinPrice
            // 
            spinPrice.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinPrice.Location = new Point(103, 121);
            spinPrice.Name = "spinPrice";
            spinPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinPrice.Properties.MaxValue = new decimal(new int[] { 1000000, 0, 0, 0 });
            spinPrice.Size = new Size(171, 22);
            spinPrice.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(103, 156);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 26);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(8, 119);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(82, 21);
            labelControl4.TabIndex = 27;
            labelControl4.Text = "Service Price";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(7, 67);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(78, 21);
            labelControl3.TabIndex = 26;
            labelControl3.Text = "Description";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(7, 18);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(90, 21);
            labelControl2.TabIndex = 25;
            labelControl2.Text = "Service Name";
            // 
            // EditService
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 199);
            Controls.Add(labelControl4);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(txtName);
            Controls.Add(txtDescription);
            Controls.Add(spinPrice);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditService";
            Text = "Edit Service";
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinPrice.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
} 