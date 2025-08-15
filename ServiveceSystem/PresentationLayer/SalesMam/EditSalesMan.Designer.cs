namespace ServiceSystem.PresentationLayer.SalesMam
{
    partial class EditSalesMan
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

        private void InitializeComponent()
        {
            txtName = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            labelNameError = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(99, 26);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(265, 22);
            txtName.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(23, 29);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(33, 13);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Name:";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(289, 65);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // labelNameError
            // 
            labelNameError.Appearance.ForeColor = System.Drawing.Color.Red;
            labelNameError.Location = new System.Drawing.Point(99, 54);
            labelNameError.Name = "labelNameError";
            labelNameError.Size = new System.Drawing.Size(0, 13);
            labelNameError.TabIndex = 3;
            labelNameError.Visible = false;
            // 
            // EditSalesMan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(386, 108);
            Controls.Add(labelNameError);
            Controls.Add(btnSave);
            Controls.Add(labelControl1);
            Controls.Add(txtName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditSalesMan";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Edit Salesman";
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelNameError;
    }
}


