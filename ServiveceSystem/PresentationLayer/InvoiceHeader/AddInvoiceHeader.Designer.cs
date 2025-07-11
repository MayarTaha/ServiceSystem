namespace ServiveceSystem.PresentationLayer.InvoiceHeader
{
    partial class AddInvoiceHeader
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
            ServicelookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            ProcessButton = new DevExpress.XtraEditors.SimpleButton();
            QuantitytextEdit = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ServicePricetextEdit = new DevExpress.XtraEditors.TextEdit();
            txtQuotationId = new DevExpress.XtraEditors.TextEdit();
            InvoicegridControl = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)ServicelookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuantitytextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServicePricetextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuotationId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoicegridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = Color.Black;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(714, 39);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(107, 45);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Invoice";
            // 
            // ServicelookUpEdit
            // 
            ServicelookUpEdit.Location = new Point(735, 107);
            ServicelookUpEdit.Name = "ServicelookUpEdit";
            ServicelookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ServicelookUpEdit.Size = new Size(225, 28);
            ServicelookUpEdit.TabIndex = 2;
            ServicelookUpEdit.EditValueChanged += ServicelookUpEdit_EditValueChanged;
            // 
            // ProcessButton
            // 
            ProcessButton.Appearance.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ProcessButton.Appearance.ForeColor = Color.Green;
            ProcessButton.Appearance.Options.UseFont = true;
            ProcessButton.Appearance.Options.UseForeColor = true;
            ProcessButton.Location = new Point(667, 354);
            ProcessButton.Name = "ProcessButton";
            ProcessButton.Size = new Size(168, 51);
            ProcessButton.TabIndex = 3;
            ProcessButton.Text = "Process";
            ProcessButton.Click += ProcessButton_Click;
            // 
            // QuantitytextEdit
            // 
            QuantitytextEdit.Location = new Point(735, 178);
            QuantitytextEdit.Name = "QuantitytextEdit";
            QuantitytextEdit.Size = new Size(225, 28);
            QuantitytextEdit.TabIndex = 4;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = Color.Black;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(577, 103);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(86, 30);
            labelControl2.TabIndex = 5;
            labelControl2.Text = "Service :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl3.Appearance.ForeColor = Color.Black;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(577, 249);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(144, 30);
            labelControl3.TabIndex = 6;
            labelControl3.Text = "Service Price :";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl4.Appearance.ForeColor = Color.Black;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.Location = new Point(577, 174);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(103, 30);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "Quantity :";
            // 
            // ServicePricetextEdit
            // 
            ServicePricetextEdit.Location = new Point(735, 253);
            ServicePricetextEdit.Name = "ServicePricetextEdit";
            ServicePricetextEdit.Size = new Size(225, 28);
            ServicePricetextEdit.TabIndex = 8;
            // 
            // txtQuotationId
            // 
            txtQuotationId.Location = new Point(735, 302);
            txtQuotationId.Name = "txtQuotationId";
            txtQuotationId.Size = new Size(225, 28);
            txtQuotationId.TabIndex = 9;
            // 
            // InvoicegridControl
            // 
            InvoicegridControl.Location = new Point(12, 30);
            InvoicegridControl.MainView = gridView1;
            InvoicegridControl.Name = "InvoicegridControl";
            InvoicegridControl.Size = new Size(548, 300);
            InvoicegridControl.TabIndex = 10;
            InvoicegridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = InvoicegridControl;
            gridView1.Name = "gridView1";
            // 
            // AddInvoiceHeader
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 653);
            Controls.Add(InvoicegridControl);
            Controls.Add(txtQuotationId);
            Controls.Add(ServicePricetextEdit);
            Controls.Add(labelControl4);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(QuantitytextEdit);
            Controls.Add(ProcessButton);
            Controls.Add(ServicelookUpEdit);
            Controls.Add(labelControl1);
            Name = "AddInvoiceHeader";
            Text = "AddInvoiceHeader";
            ((System.ComponentModel.ISupportInitialize)ServicelookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuantitytextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServicePricetextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuotationId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoicegridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit ServicelookUpEdit;
        private DevExpress.XtraEditors.SimpleButton ProcessButton;
        private DevExpress.XtraEditors.TextEdit QuantitytextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit ServicePricetextEdit;
        private DevExpress.XtraEditors.TextEdit txtQuotationId;
        private DevExpress.XtraGrid.GridControl InvoicegridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}