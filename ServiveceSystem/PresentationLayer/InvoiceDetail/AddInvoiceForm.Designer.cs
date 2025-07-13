namespace ServiveceSystem.PresentationLayer.InvoiceDetail
{
    partial class AddInvoiceForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            lookUpClinic = new DevExpress.XtraEditors.LookUpEdit();
            lookUpQuotation = new DevExpress.XtraEditors.LookUpEdit();
            serviceLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            discountValueTextEdit = new DevExpress.XtraEditors.TextEdit();
            textEditServicePrice = new DevExpress.XtraEditors.TextEdit();
            quantityTextEdit = new DevExpress.XtraEditors.TextEdit();
            totalServiceTextEdit = new DevExpress.XtraEditors.TextEdit();
            btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            Invoice = new GroupBox();
            dateEditInvoiceDate = new DevExpress.XtraEditors.DateEdit();
            lookUpContact = new DevExpress.XtraEditors.LookUpEdit();
            textEditReminder = new DevExpress.XtraEditors.TextEdit();
            lookUpPaymentMethod = new DevExpress.XtraEditors.LookUpEdit();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            groupBox1 = new GroupBox();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            txtLocation = new DevExpress.XtraEditors.TextEdit();
            txtPhone = new DevExpress.XtraEditors.TextEdit();
            labelControl15 = new DevExpress.XtraEditors.LabelControl();
            labelControl14 = new DevExpress.XtraEditors.LabelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            groupBox2 = new GroupBox();
            comboBoxDiscountType = new DevExpress.XtraEditors.ComboBoxEdit();
            gridcontrolDetails = new DevExpress.XtraGrid.GridControl();
            gridViewdet = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)lookUpClinic.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpQuotation.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountValueTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditServicePrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalServiceTextEdit.Properties).BeginInit();
            Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateEditInvoiceDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditInvoiceDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpContact.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditReminder.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpPaymentMethod.Properties).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLocation.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPhone.Properties).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxDiscountType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridcontrolDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewdet).BeginInit();
            SuspendLayout();
            // 
            // lookUpClinic
            // 
            lookUpClinic.Location = new Point(149, 31);
            lookUpClinic.Margin = new Padding(3, 4, 3, 4);
            lookUpClinic.Name = "lookUpClinic";
            lookUpClinic.Properties.Appearance.ForeColor = Color.Silver;
            lookUpClinic.Properties.Appearance.Options.UseForeColor = true;
            lookUpClinic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpClinic.Properties.NullText = "Select Clinic";
            lookUpClinic.Size = new Size(250, 28);
            lookUpClinic.TabIndex = 1;
            lookUpClinic.EditValueChanged += clinicLookUpEdit_EditValueChanged;
            // 
            // lookUpQuotation
            // 
            lookUpQuotation.Location = new Point(203, 46);
            lookUpQuotation.Margin = new Padding(3, 4, 3, 4);
            lookUpQuotation.Name = "lookUpQuotation";
            lookUpQuotation.Properties.Appearance.ForeColor = Color.Silver;
            lookUpQuotation.Properties.Appearance.Options.UseForeColor = true;
            lookUpQuotation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpQuotation.Properties.NullText = "Select Quotation";
            lookUpQuotation.Size = new Size(250, 28);
            lookUpQuotation.TabIndex = 2;
            // 
            // serviceLookUpEdit
            // 
            serviceLookUpEdit.Location = new Point(150, 28);
            serviceLookUpEdit.Margin = new Padding(3, 4, 3, 4);
            serviceLookUpEdit.Name = "serviceLookUpEdit";
            serviceLookUpEdit.Properties.Appearance.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceLookUpEdit.Properties.Appearance.ForeColor = Color.Silver;
            serviceLookUpEdit.Properties.Appearance.Options.UseFont = true;
            serviceLookUpEdit.Properties.Appearance.Options.UseForeColor = true;
            serviceLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            serviceLookUpEdit.Properties.NullText = "Select Service";
            serviceLookUpEdit.Size = new Size(250, 28);
            serviceLookUpEdit.TabIndex = 4;
            serviceLookUpEdit.EditValueChanged += serviceLookUpEdit_EditValueChanged;
            // 
            // discountValueTextEdit
            // 
            discountValueTextEdit.Location = new Point(663, 64);
            discountValueTextEdit.Margin = new Padding(3, 4, 3, 4);
            discountValueTextEdit.Name = "discountValueTextEdit";
            discountValueTextEdit.Size = new Size(250, 28);
            discountValueTextEdit.TabIndex = 5;
            // 
            // textEditServicePrice
            // 
            textEditServicePrice.Location = new Point(663, 28);
            textEditServicePrice.Margin = new Padding(3, 4, 3, 4);
            textEditServicePrice.Name = "textEditServicePrice";
            textEditServicePrice.Size = new Size(250, 28);
            textEditServicePrice.TabIndex = 6;
            // 
            // quantityTextEdit
            // 
            quantityTextEdit.Location = new Point(150, 96);
            quantityTextEdit.Margin = new Padding(3, 4, 3, 4);
            quantityTextEdit.Name = "quantityTextEdit";
            quantityTextEdit.Size = new Size(250, 28);
            quantityTextEdit.TabIndex = 7;
            // 
            // totalServiceTextEdit
            // 
            totalServiceTextEdit.Location = new Point(663, 101);
            totalServiceTextEdit.Margin = new Padding(3, 4, 3, 4);
            totalServiceTextEdit.Name = "totalServiceTextEdit";
            totalServiceTextEdit.Size = new Size(250, 28);
            totalServiceTextEdit.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(1348, 275);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(117, 35);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Add";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(8, 34);
            labelControl1.Margin = new Padding(3, 4, 3, 4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(102, 25);
            labelControl1.TabIndex = 15;
            labelControl1.Text = "Clinic Name :";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(9, 64);
            labelControl2.Margin = new Padding(3, 4, 3, 4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(122, 25);
            labelControl2.TabIndex = 16;
            labelControl2.Text = "Discount Type :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(9, 95);
            labelControl3.Margin = new Padding(3, 4, 3, 4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(77, 25);
            labelControl3.TabIndex = 17;
            labelControl3.Text = "Quantity :";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(20, 46);
            labelControl4.Margin = new Padding(3, 4, 3, 4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(142, 25);
            labelControl4.TabIndex = 18;
            labelControl4.Text = "Quotation Name :";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(499, 61);
            labelControl5.Margin = new Padding(3, 4, 3, 4);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(79, 25);
            labelControl5.TabIndex = 19;
            labelControl5.Text = "Discount :";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(498, 94);
            labelControl6.Margin = new Padding(3, 4, 3, 4);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(108, 25);
            labelControl6.TabIndex = 20;
            labelControl6.Text = "Total Service :";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(9, 31);
            labelControl7.Margin = new Padding(3, 4, 3, 4);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(64, 25);
            labelControl7.TabIndex = 21;
            labelControl7.Text = "Service :";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(498, 28);
            labelControl8.Margin = new Padding(3, 4, 3, 4);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(106, 25);
            labelControl8.TabIndex = 22;
            labelControl8.Text = "Service Price :";
            // 
            // Invoice
            // 
            Invoice.Controls.Add(dateEditInvoiceDate);
            Invoice.Controls.Add(lookUpContact);
            Invoice.Controls.Add(textEditReminder);
            Invoice.Controls.Add(lookUpPaymentMethod);
            Invoice.Controls.Add(labelControl13);
            Invoice.Controls.Add(labelControl12);
            Invoice.Controls.Add(labelControl11);
            Invoice.Controls.Add(labelControl10);
            Invoice.Controls.Add(labelControl4);
            Invoice.Controls.Add(lookUpQuotation);
            Invoice.Location = new Point(980, 12);
            Invoice.Name = "Invoice";
            Invoice.Size = new Size(485, 256);
            Invoice.TabIndex = 24;
            Invoice.TabStop = false;
            Invoice.Text = "Invoice";
            // 
            // dateEditInvoiceDate
            // 
            dateEditInvoiceDate.EditValue = null;
            dateEditInvoiceDate.Location = new Point(203, 81);
            dateEditInvoiceDate.Name = "dateEditInvoiceDate";
            dateEditInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditInvoiceDate.Size = new Size(250, 28);
            dateEditInvoiceDate.TabIndex = 25;
            // 
            // lookUpContact
            // 
            lookUpContact.Location = new Point(203, 199);
            lookUpContact.Margin = new Padding(3, 4, 3, 4);
            lookUpContact.Name = "lookUpContact";
            lookUpContact.Properties.Appearance.ForeColor = Color.Silver;
            lookUpContact.Properties.Appearance.Options.UseForeColor = true;
            lookUpContact.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpContact.Properties.NullText = "Select Contact";
            lookUpContact.Size = new Size(250, 28);
            lookUpContact.TabIndex = 25;
            // 
            // textEditReminder
            // 
            textEditReminder.Location = new Point(203, 163);
            textEditReminder.Margin = new Padding(3, 4, 3, 4);
            textEditReminder.Name = "textEditReminder";
            textEditReminder.Size = new Size(250, 28);
            textEditReminder.TabIndex = 24;
            // 
            // lookUpPaymentMethod
            // 
            lookUpPaymentMethod.Location = new Point(203, 125);
            lookUpPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            lookUpPaymentMethod.Name = "lookUpPaymentMethod";
            lookUpPaymentMethod.Properties.Appearance.ForeColor = Color.Silver;
            lookUpPaymentMethod.Properties.Appearance.Options.UseForeColor = true;
            lookUpPaymentMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpPaymentMethod.Properties.NullText = "Select Payment Method";
            lookUpPaymentMethod.Size = new Size(250, 28);
            lookUpPaymentMethod.TabIndex = 23;
            // 
            // labelControl13
            // 
            labelControl13.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl13.Appearance.Options.UseFont = true;
            labelControl13.Location = new Point(20, 196);
            labelControl13.Margin = new Padding(3, 4, 3, 4);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new Size(70, 25);
            labelControl13.TabIndex = 22;
            labelControl13.Text = "Contact :";
            // 
            // labelControl12
            // 
            labelControl12.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl12.Appearance.Options.UseFont = true;
            labelControl12.Location = new Point(20, 163);
            labelControl12.Margin = new Padding(3, 4, 3, 4);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new Size(85, 25);
            labelControl12.TabIndex = 21;
            labelControl12.Text = "Reminder :";
            // 
            // labelControl11
            // 
            labelControl11.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl11.Appearance.Options.UseFont = true;
            labelControl11.Location = new Point(20, 121);
            labelControl11.Margin = new Padding(3, 4, 3, 4);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new Size(146, 25);
            labelControl11.TabIndex = 20;
            labelControl11.Text = "Payment Method :";
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Location = new Point(20, 79);
            labelControl10.Margin = new Padding(3, 4, 3, 4);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(107, 25);
            labelControl10.TabIndex = 19;
            labelControl10.Text = "Invoice Date :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtLocation);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(labelControl15);
            groupBox1.Controls.Add(labelControl14);
            groupBox1.Controls.Add(labelControl9);
            groupBox1.Controls.Add(labelControl1);
            groupBox1.Controls.Add(lookUpClinic);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(961, 116);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 81);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 28);
            txtEmail.TabIndex = 28;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(662, 75);
            txtLocation.Margin = new Padding(3, 4, 3, 4);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(250, 28);
            txtLocation.TabIndex = 27;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(662, 31);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 28);
            txtPhone.TabIndex = 26;
            // 
            // labelControl15
            // 
            labelControl15.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl15.Appearance.Options.UseFont = true;
            labelControl15.Location = new Point(498, 37);
            labelControl15.Margin = new Padding(3, 4, 3, 4);
            labelControl15.Name = "labelControl15";
            labelControl15.Size = new Size(60, 25);
            labelControl15.TabIndex = 25;
            labelControl15.Text = "phone :";
            // 
            // labelControl14
            // 
            labelControl14.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl14.Appearance.Options.UseFont = true;
            labelControl14.Location = new Point(497, 78);
            labelControl14.Margin = new Padding(3, 4, 3, 4);
            labelControl14.Name = "labelControl14";
            labelControl14.Size = new Size(76, 25);
            labelControl14.TabIndex = 24;
            labelControl14.Text = "Location :";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new Point(8, 78);
            labelControl9.Margin = new Padding(3, 4, 3, 4);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(51, 25);
            labelControl9.TabIndex = 23;
            labelControl9.Text = "Email :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxDiscountType);
            groupBox2.Controls.Add(labelControl8);
            groupBox2.Controls.Add(textEditServicePrice);
            groupBox2.Controls.Add(labelControl7);
            groupBox2.Controls.Add(labelControl6);
            groupBox2.Controls.Add(serviceLookUpEdit);
            groupBox2.Controls.Add(labelControl5);
            groupBox2.Controls.Add(labelControl3);
            groupBox2.Controls.Add(discountValueTextEdit);
            groupBox2.Controls.Add(labelControl2);
            groupBox2.Controls.Add(quantityTextEdit);
            groupBox2.Controls.Add(totalServiceTextEdit);
            groupBox2.Location = new Point(12, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(962, 142);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Service";
            // 
            // comboBoxDiscountType
            // 
            comboBoxDiscountType.Location = new Point(150, 63);
            comboBoxDiscountType.Name = "comboBoxDiscountType";
            comboBoxDiscountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxDiscountType.Size = new Size(250, 28);
            comboBoxDiscountType.TabIndex = 27;
            // 
            // gridcontrolDetails
            // 
            gridcontrolDetails.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridLevelNode1.RelationName = "Level1";
            gridcontrolDetails.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            gridcontrolDetails.Location = new Point(12, 277);
            gridcontrolDetails.MainView = gridViewdet;
            gridcontrolDetails.Margin = new Padding(3, 4, 3, 4);
            gridcontrolDetails.Name = "gridcontrolDetails";
            gridcontrolDetails.Size = new Size(1329, 412);
            gridcontrolDetails.TabIndex = 0;
            gridcontrolDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewdet });
            gridcontrolDetails.Click += gridcontrolDetails_Click;
            // 
            // gridViewdet
            // 
            gridViewdet.DetailHeight = 417;
            gridViewdet.GridControl = gridcontrolDetails;
            gridViewdet.Name = "gridViewdet";
            // 
            // AddInvoiceForm
            // 
            Appearance.BackColor = SystemColors.InactiveCaption;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 680);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Invoice);
            Controls.Add(btnSubmit);
            Controls.Add(gridcontrolDetails);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddInvoiceForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)lookUpClinic.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpQuotation.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)discountValueTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditServicePrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalServiceTextEdit.Properties).EndInit();
            Invoice.ResumeLayout(false);
            Invoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateEditInvoiceDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditInvoiceDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpContact.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditReminder.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpPaymentMethod.Properties).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLocation.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPhone.Properties).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxDiscountType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridcontrolDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewdet).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit lookUpClinic;
        private DevExpress.XtraEditors.LookUpEdit lookUpQuotation;
        private DevExpress.XtraEditors.LookUpEdit discountLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit serviceLookUpEdit;
        private DevExpress.XtraEditors.TextEdit discountValueTextEdit;
        private DevExpress.XtraEditors.TextEdit textEditServicePrice;
        private DevExpress.XtraEditors.TextEdit quantityTextEdit;
        private DevExpress.XtraEditors.TextEdit totalServiceTextEdit;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private GroupBox Invoice;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit lookUpContact;
        private DevExpress.XtraEditors.TextEdit textEditReminder;
        private DevExpress.XtraEditors.LookUpEdit lookUpPaymentMethod;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.DateEdit dateEditInvoiceDate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtLocation;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetails;
        private DevExpress.XtraGrid.GridControl gridcontrolDetails;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxDiscountType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewdet;
    }
}