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
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            txtName = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            spinPrice = new DevExpress.XtraEditors.SpinEdit();
            this.groupBoxAddService = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinPrice.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(12, 143);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(112, 25);
            labelControl4.TabIndex = 24;
            labelControl4.Text = "Service Price";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(162, 93);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(132, 22);
            txtDescription.TabIndex = 23;
            // 
            // btnSave
            // 
            btnSave.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Location = new Point(114, 196);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 36);
            btnSave.TabIndex = 21;
            btnSave.Text = "Add";
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(162, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(132, 22);
            txtName.TabIndex = 20;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(12, 88);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(102, 25);
            labelControl3.TabIndex = 19;
            labelControl3.Text = "Description";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(12, 30);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(120, 25);
            labelControl2.TabIndex = 18;
            labelControl2.Text = "Service Name";
            // 
            // spinPrice
            // 
            spinPrice.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinPrice.Location = new Point(162, 148);
            spinPrice.Name = "spinPrice";
            spinPrice.Properties.Appearance.Options.UseTextOptions = true;
            spinPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            spinPrice.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            spinPrice.Size = new Size(132, 22);
            spinPrice.TabIndex = 25;
            // 
            // groupBoxAddService
            // 
            this.groupBoxAddService.Text = "Add Service";
            this.groupBoxAddService.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.groupBoxAddService.Location = new Point(6, 6);
            this.groupBoxAddService.Size = new Size(306, 243);
            this.groupBoxAddService.TabIndex = 100;
            this.groupBoxAddService.TabStop = false;
            this.groupBoxAddService.ForeColor = System.Drawing.Color.White;
            // Add controls to group box
            this.groupBoxAddService.Controls.Add(labelControl2);
            this.groupBoxAddService.Controls.Add(txtName);
            this.groupBoxAddService.Controls.Add(labelControl3);
            this.groupBoxAddService.Controls.Add(txtDescription);
            this.groupBoxAddService.Controls.Add(labelControl4);
            this.groupBoxAddService.Controls.Add(spinPrice);
            this.groupBoxAddService.Controls.Add(btnSave);
            // Adjust controls' locations to be relative to group box
            labelControl2.Location = new Point(12, 30);
            txtName.Location = new Point(162, 36);
            labelControl3.Location = new Point(12, 88);
            txtDescription.Location = new Point(162, 93);
            labelControl4.Location = new Point(12, 143);
            spinPrice.Location = new Point(162, 148);
            btnSave.Location = new Point(114, 196);
            // 
            // AddService (form)
            // 
            this.Controls.Clear();
            this.Controls.Add(groupBoxAddService);
            this.ClientSize = new Size(318, 255);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddService";
            this.Text = "AddService";
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinPrice.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinPrice;
        private System.Windows.Forms.GroupBox groupBoxAddService;
    }
}