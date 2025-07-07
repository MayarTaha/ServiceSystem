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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtName = new DevExpress.XtraEditors.TextEdit();
            spinRatio = new DevExpress.XtraEditors.SpinEdit();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinRatio.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(195, 28);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(102, 30);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Add Taxes";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(102, 97);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(89, 25);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Tax Name";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(102, 144);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(83, 25);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "Tax Ratio";
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(132, 20);
            txtName.TabIndex = 3;
            // 
            // spinRatio
            // 
            spinRatio.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinRatio.Location = new Point(218, 149);
            spinRatio.Name = "spinRatio";
            spinRatio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinRatio.Size = new Size(132, 20);
            spinRatio.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Location = new Point(136, 224);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 36);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(275, 224);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 36);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // AddTaxes
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 368);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(spinRatio);
            Controls.Add(txtName);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Name = "AddTaxes";
            Text = "AddTaxes";
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinRatio.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SpinEdit spinRatio;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}