namespace ServiveceSystem.PresentationLayer.PaymentMethod
{
    partial class AddPaymentMethod
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
            groupBox1 = new GroupBox();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtPaymentType = new DevExpress.XtraEditors.TextEdit();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPaymentType.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelControl1);
            groupBox1.Controls.Add(txtPaymentType);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelControl1.Appearance.ForeColor = Color.White;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(16, 32);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(109, 21);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Payment Type";
            // 
            // txtPaymentType
            // 
            txtPaymentType.Location = new Point(140, 32);
            txtPaymentType.Name = "txtPaymentType";
            txtPaymentType.Size = new Size(150, 22);
            txtPaymentType.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Location = new Point(12, 105);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(310, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // AddPaymentMethod
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 148);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPaymentMethod";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Payment Method";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPaymentType.Properties).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPaymentType;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
} 