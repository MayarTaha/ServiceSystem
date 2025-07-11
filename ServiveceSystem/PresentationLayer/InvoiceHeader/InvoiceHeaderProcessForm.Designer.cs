namespace ServiveceSystem.PresentationLayer.InvoiceHeader
{
    partial class InvoiceHeaderProcessForm
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
            Clinic = new DevExpress.XtraEditors.LabelControl();
            ClinicNamelookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            paymentmethodlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            paidtextEdit = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ContactNamelookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            DiscounttextEdit = new DevExpress.XtraEditors.TextEdit();
            DiscountTypelookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            addclinicButton = new DevExpress.XtraEditors.SimpleButton();
            AddInvoiceButton = new DevExpress.XtraEditors.SimpleButton();
            AddContactButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)ClinicNamelookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentmethodlookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paidtextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContactNamelookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiscounttextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiscountTypelookUpEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // Clinic
            // 
            Clinic.Appearance.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clinic.Appearance.ForeColor = Color.Black;
            Clinic.Appearance.Options.UseFont = true;
            Clinic.Appearance.Options.UseForeColor = true;
            Clinic.Location = new Point(38, 63);
            Clinic.Name = "Clinic";
            Clinic.Size = new Size(132, 30);
            Clinic.TabIndex = 0;
            Clinic.Text = "Clinic Name : ";
            // 
            // ClinicNamelookUpEdit
            // 
            ClinicNamelookUpEdit.Location = new Point(262, 67);
            ClinicNamelookUpEdit.Name = "ClinicNamelookUpEdit";
            ClinicNamelookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ClinicNamelookUpEdit.Size = new Size(250, 28);
            ClinicNamelookUpEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = Color.Black;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(38, 117);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(184, 30);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Payment Method : ";
            // 
            // paymentmethodlookUpEdit
            // 
            paymentmethodlookUpEdit.Location = new Point(262, 121);
            paymentmethodlookUpEdit.Name = "paymentmethodlookUpEdit";
            paymentmethodlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            paymentmethodlookUpEdit.Size = new Size(250, 28);
            paymentmethodlookUpEdit.TabIndex = 3;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = Color.Black;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(38, 214);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(59, 30);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "paid : ";
            // 
            // paidtextEdit
            // 
            paidtextEdit.Location = new Point(262, 211);
            paidtextEdit.Name = "paidtextEdit";
            paidtextEdit.Size = new Size(250, 28);
            paidtextEdit.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl3.Appearance.ForeColor = Color.Black;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(38, 164);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(155, 30);
            labelControl3.TabIndex = 6;
            labelControl3.Text = "Contact Name : ";
            // 
            // ContactNamelookUpEdit
            // 
            ContactNamelookUpEdit.Location = new Point(262, 166);
            ContactNamelookUpEdit.Name = "ContactNamelookUpEdit";
            ContactNamelookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ContactNamelookUpEdit.Size = new Size(250, 28);
            ContactNamelookUpEdit.TabIndex = 7;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl5.Appearance.ForeColor = Color.Black;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseForeColor = true;
            labelControl5.Location = new Point(38, 318);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(94, 30);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "Discount :";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl6.Appearance.ForeColor = Color.Black;
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Appearance.Options.UseForeColor = true;
            labelControl6.Location = new Point(38, 271);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(154, 30);
            labelControl6.TabIndex = 11;
            labelControl6.Text = "Discount Type : ";
            // 
            // DiscounttextEdit
            // 
            DiscounttextEdit.Location = new Point(262, 322);
            DiscounttextEdit.Name = "DiscounttextEdit";
            DiscounttextEdit.Size = new Size(250, 28);
            DiscounttextEdit.TabIndex = 12;
            // 
            // DiscountTypelookUpEdit
            // 
            DiscountTypelookUpEdit.Location = new Point(262, 273);
            DiscountTypelookUpEdit.Name = "DiscountTypelookUpEdit";
            DiscountTypelookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DiscountTypelookUpEdit.Size = new Size(250, 28);
            DiscountTypelookUpEdit.TabIndex = 13;
            // 
            // addclinicButton
            // 
            addclinicButton.Location = new Point(556, 64);
            addclinicButton.Name = "addclinicButton";
            addclinicButton.Size = new Size(164, 32);
            addclinicButton.TabIndex = 14;
            addclinicButton.Text = "Add Clinic";
            // 
            // AddInvoiceButton
            // 
            AddInvoiceButton.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddInvoiceButton.Appearance.ForeColor = Color.FromArgb(0, 64, 0);
            AddInvoiceButton.Appearance.Options.UseFont = true;
            AddInvoiceButton.Appearance.Options.UseForeColor = true;
            AddInvoiceButton.Location = new Point(419, 398);
            AddInvoiceButton.Name = "AddInvoiceButton";
            AddInvoiceButton.Size = new Size(190, 55);
            AddInvoiceButton.TabIndex = 15;
            AddInvoiceButton.Text = "Add Invoice";
            AddInvoiceButton.Click += AddInvoiceButton_Click;
            // 
            // AddContactButton
            // 
            AddContactButton.Location = new Point(556, 162);
            AddContactButton.Name = "AddContactButton";
            AddContactButton.Size = new Size(164, 32);
            AddContactButton.TabIndex = 16;
            AddContactButton.Text = "Add Contact";
            // 
            // InvoiceHeaderProcessForm
            // 
            Appearance.ForeColor = Color.Green;
            Appearance.Options.UseFont = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = AddInvoiceButton;
            ClientSize = new Size(1020, 517);
            Controls.Add(AddContactButton);
            Controls.Add(AddInvoiceButton);
            Controls.Add(addclinicButton);
            Controls.Add(DiscountTypelookUpEdit);
            Controls.Add(DiscounttextEdit);
            Controls.Add(labelControl6);
            Controls.Add(labelControl5);
            Controls.Add(ContactNamelookUpEdit);
            Controls.Add(labelControl3);
            Controls.Add(paidtextEdit);
            Controls.Add(labelControl2);
            Controls.Add(paymentmethodlookUpEdit);
            Controls.Add(labelControl1);
            Controls.Add(ClinicNamelookUpEdit);
            Controls.Add(Clinic);
            Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "InvoiceHeaderProcessForm";
            Text = "InvoiceHeaderProcessForm";
            ((System.ComponentModel.ISupportInitialize)ClinicNamelookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentmethodlookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)paidtextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContactNamelookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiscounttextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiscountTypelookUpEdit.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Clinic;
        private DevExpress.XtraEditors.LookUpEdit ClinicNamelookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit paymentmethodlookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit paidtextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit ContactNamelookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit DiscounttextEdit;
        private DevExpress.XtraEditors.LookUpEdit DiscountTypelookUpEdit;
        private DevExpress.XtraEditors.SimpleButton addclinicButton;
        private DevExpress.XtraEditors.SimpleButton AddInvoiceButton;
        private DevExpress.XtraEditors.SimpleButton AddContactButton;
    }
}