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
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            txtName = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            spinPrice = new DevExpress.XtraEditors.SpinEdit();
            groupBoxAddService = new GroupBox();
            txtDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinPrice.Properties).BeginInit();
            groupBoxAddService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI", 12F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(12, 61);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(88, 21);
            labelControl4.TabIndex = 24;
            labelControl4.Text = "Service Price";
            // 
            // btnSave
            // 
            btnSave.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Location = new Point(6, 166);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(300, 26);
            btnSave.TabIndex = 21;
            btnSave.Text = "Add";
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 22);
            txtName.TabIndex = 0;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 12F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(12, 98);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(79, 21);
            labelControl3.TabIndex = 19;
            labelControl3.Text = "Description";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 12F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(12, 30);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(96, 21);
            labelControl2.TabIndex = 18;
            labelControl2.Text = "Service Name";
            // 
            // spinPrice
            // 
            spinPrice.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinPrice.Location = new Point(123, 60);
            spinPrice.Name = "spinPrice";
            spinPrice.Properties.Appearance.Options.UseTextOptions = true;
            spinPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            spinPrice.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            spinPrice.Size = new Size(164, 22);
            spinPrice.TabIndex = 1;
            // 
            // groupBoxAddService
            // 
            groupBoxAddService.Controls.Add(labelControl2);
            groupBoxAddService.Controls.Add(txtName);
            groupBoxAddService.Controls.Add(labelControl4);
            groupBoxAddService.Controls.Add(labelControl3);
            groupBoxAddService.Controls.Add(spinPrice);
            groupBoxAddService.Controls.Add(txtDescription);
            groupBoxAddService.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxAddService.ForeColor = Color.White;
            groupBoxAddService.Location = new Point(6, 6);
            groupBoxAddService.Name = "groupBoxAddService";
            groupBoxAddService.Size = new Size(300, 154);
            groupBoxAddService.TabIndex = 100;
            groupBoxAddService.TabStop = false;
            groupBoxAddService.Text = "Data";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(123, 88);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(164, 52);
            txtDescription.TabIndex = 2;
            // 
            // AddService
            // 
            Appearance.Options.UseFont = true;
            ClientSize = new Size(304, 192);
            Controls.Add(groupBoxAddService);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddService";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Service";
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinPrice.Properties).EndInit();
            groupBoxAddService.ResumeLayout(false);
            groupBoxAddService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinPrice;
        private System.Windows.Forms.GroupBox groupBoxAddService;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
    }
}