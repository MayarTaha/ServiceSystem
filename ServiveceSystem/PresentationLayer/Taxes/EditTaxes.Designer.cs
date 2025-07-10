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
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTaxRate.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Location = new Point(14, 17);
            lblName.Margin = new Padding(4, 3, 4, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(32, 13);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 14);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(233, 20);
            txtName.TabIndex = 1;
            // 
            // lblTaxRate
            // 
            lblTaxRate.Location = new Point(14, 47);
            lblTaxRate.Margin = new Padding(4, 3, 4, 3);
            lblTaxRate.Name = "lblTaxRate";
            lblTaxRate.Size = new Size(46, 13);
            lblTaxRate.TabIndex = 2;
            lblTaxRate.Text = "Tax Rate:";
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(140, 44);
            txtTaxRate.Margin = new Padding(4, 3, 4, 3);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(233, 20);
            txtTaxRate.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(140, 81);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 4;
            btnSave.Text = "Update";
            btnSave.Click += btnSave_Click;
            // 
            // EditTaxes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 121);
            Controls.Add(btnSave);
            Controls.Add(txtTaxRate);
            Controls.Add(lblTaxRate);
            Controls.Add(txtName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditTaxes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Tax";
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTaxRate.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblTaxRate;
        private DevExpress.XtraEditors.TextEdit txtTaxRate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
} 