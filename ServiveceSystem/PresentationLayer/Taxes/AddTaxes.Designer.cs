namespace ServiveceSystem.PresentationLayer.Taxes
{
    partial class AddTaxes
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
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtName = new DevExpress.XtraEditors.TextEdit();
            spinRatio = new DevExpress.XtraEditors.SpinEdit();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinRatio.Properties).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 12F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(12, 21);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(72, 21);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Tax Name:";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 12F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(12, 45);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(66, 21);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "Tax Ratio:";
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(188, 22);
            txtName.TabIndex = 3;
            // 
            // spinRatio
            // 
            spinRatio.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinRatio.Location = new Point(90, 47);
            spinRatio.Name = "spinRatio";
            spinRatio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinRatio.Size = new Size(188, 22);
            spinRatio.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Location = new Point(9, 91);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(289, 27);
            btnSave.TabIndex = 5;
            btnSave.Text = "Add";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(labelControl2);
            groupBox1.Controls.Add(spinRatio);
            groupBox1.Controls.Add(labelControl3);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(9, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 82);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // AddTaxes
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 125);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTaxes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Taxes";
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinRatio.Properties).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SpinEdit spinRatio;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private GroupBox groupBox1;
    }
}