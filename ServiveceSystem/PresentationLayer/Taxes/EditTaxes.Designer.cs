namespace ServiveceSystem.PresentationLayer.Taxes
{
    partial class EditTaxes
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
            lblName = new DevExpress.XtraEditors.LabelControl();
            txtName = new DevExpress.XtraEditors.TextEdit();
            lblTaxRate = new DevExpress.XtraEditors.LabelControl();
            txtTaxRate = new DevExpress.XtraEditors.TextEdit();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTaxRate.Properties).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Location = new Point(10, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 13);
            lblName.TabIndex = 0;
            lblName.Text = "Tax Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(83, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 22);
            txtName.TabIndex = 1;
            // 
            // lblTaxRate
            // 
            lblTaxRate.Location = new Point(10, 50);
            lblTaxRate.Name = "lblTaxRate";
            lblTaxRate.Size = new Size(46, 13);
            lblTaxRate.TabIndex = 2;
            lblTaxRate.Text = "Tax Rate:";
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(83, 46);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(200, 22);
            txtTaxRate.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 98);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(293, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Update";
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(txtTaxRate);
            groupBox1.Controls.Add(lblTaxRate);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 80);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // EditTaxes
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 125);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditTaxes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Tax";
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTaxRate.Properties).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblTaxRate;
        private DevExpress.XtraEditors.TextEdit txtTaxRate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private GroupBox groupBox1;
    }
} 