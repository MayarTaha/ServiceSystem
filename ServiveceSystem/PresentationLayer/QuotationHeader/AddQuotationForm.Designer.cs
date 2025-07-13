namespace ServiveceSystem.PresentationLayer.QuotationHeader
{
    partial class AddQuotationForm
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
            lookUpClinic = new DevExpress.XtraEditors.LookUpEdit();
            lookUpContact = new DevExpress.XtraEditors.LookUpEdit();
            comboBoxStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            comboBoxDiscountTypeHeader = new DevExpress.XtraEditors.ComboBoxEdit();
            textEditNote = new DevExpress.XtraEditors.TextEdit();
            textEditDiscountDetail = new DevExpress.XtraEditors.TextEdit();
            dateEditInitialDate = new DevExpress.XtraEditors.DateEdit();
            dateEditExpireDate = new DevExpress.XtraEditors.DateEdit();
            serviceLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            textEditServicePrice = new DevExpress.XtraEditors.TextEdit();
            quantityTextEdit = new DevExpress.XtraEditors.TextEdit();
            textEditDiscountHeader = new DevExpress.XtraEditors.TextEdit();
            totalServiceTextEdit = new DevExpress.XtraEditors.TextEdit();
            gridcontrolDetails = new DevExpress.XtraGrid.GridControl();
            gridViewdet = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            txtPhone = new DevExpress.XtraEditors.TextEdit();
            txtLocation = new DevExpress.XtraEditors.TextEdit();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            labelControl15 = new DevExpress.XtraEditors.LabelControl();
            labelControl16 = new DevExpress.XtraEditors.LabelControl();
            labelControl17 = new DevExpress.XtraEditors.LabelControl();
            labelControl18 = new DevExpress.XtraEditors.LabelControl();
            labelControl19 = new DevExpress.XtraEditors.LabelControl();
            labelControl20 = new DevExpress.XtraEditors.LabelControl();
            groupBox1 = new GroupBox();
            Quotaion = new GroupBox();
            labelControl14 = new DevExpress.XtraEditors.LabelControl();
            comboBoxDiscountTypeDetail = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)lookUpClinic.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpContact.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxDiscountTypeHeader.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditNote.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditDiscountDetail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditInitialDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditInitialDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditExpireDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditExpireDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditServicePrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditDiscountHeader.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalServiceTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridcontrolDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPhone.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLocation.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            groupBox1.SuspendLayout();
            Quotaion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxDiscountTypeDetail.Properties).BeginInit();
            SuspendLayout();
            // 
            // lookUpClinic
            // 
            lookUpClinic.Location = new Point(7, 57);
            lookUpClinic.Margin = new Padding(4, 6, 4, 6);
            lookUpClinic.Name = "lookUpClinic";
            lookUpClinic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpClinic.Properties.NullText = "Select Clinic";
            lookUpClinic.Size = new Size(191, 28);
            lookUpClinic.TabIndex = 0;
            lookUpClinic.EditValueChanged += clinicLookUpEdit_EditValueChanged;
            // 
            // lookUpContact
            // 
            lookUpContact.Location = new Point(7, 126);
            lookUpContact.Margin = new Padding(4, 6, 4, 6);
            lookUpContact.Name = "lookUpContact";
            lookUpContact.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpContact.Properties.NullText = "Select Contact";
            lookUpContact.Size = new Size(191, 28);
            lookUpContact.TabIndex = 1;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Location = new Point(544, 129);
            comboBoxStatus.Margin = new Padding(4, 6, 4, 6);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxStatus.Size = new Size(300, 28);
            comboBoxStatus.TabIndex = 2;
            // 
            // comboBoxDiscountTypeHeader
            // 
            comboBoxDiscountTypeHeader.Location = new Point(415, 188);
            comboBoxDiscountTypeHeader.Margin = new Padding(4, 6, 4, 6);
            comboBoxDiscountTypeHeader.Name = "comboBoxDiscountTypeHeader";
            comboBoxDiscountTypeHeader.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxDiscountTypeHeader.Size = new Size(194, 28);
            comboBoxDiscountTypeHeader.TabIndex = 3;
            // 
            // textEditNote
            // 
            textEditNote.Location = new Point(222, 129);
            textEditNote.Margin = new Padding(4, 6, 4, 6);
            textEditNote.Name = "textEditNote";
            textEditNote.Size = new Size(300, 28);
            textEditNote.TabIndex = 4;
            // 
            // textEditDiscountDetail
            // 
            textEditDiscountDetail.Location = new Point(258, 203);
            textEditDiscountDetail.Margin = new Padding(4, 6, 4, 6);
            textEditDiscountDetail.Name = "textEditDiscountDetail";
            textEditDiscountDetail.Properties.Appearance.Options.UseTextOptions = true;
            textEditDiscountDetail.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            textEditDiscountDetail.Size = new Size(197, 28);
            textEditDiscountDetail.TabIndex = 5;
            // 
            // dateEditInitialDate
            // 
            dateEditInitialDate.EditValue = null;
            dateEditInitialDate.Location = new Point(7, 190);
            dateEditInitialDate.Margin = new Padding(4, 6, 4, 6);
            dateEditInitialDate.Name = "dateEditInitialDate";
            dateEditInitialDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditInitialDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditInitialDate.Size = new Size(184, 28);
            dateEditInitialDate.TabIndex = 6;
            // 
            // dateEditExpireDate
            // 
            dateEditExpireDate.EditValue = null;
            dateEditExpireDate.Location = new Point(213, 191);
            dateEditExpireDate.Margin = new Padding(4, 6, 4, 6);
            dateEditExpireDate.Name = "dateEditExpireDate";
            dateEditExpireDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditExpireDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditExpireDate.Size = new Size(174, 28);
            dateEditExpireDate.TabIndex = 7;
            // 
            // serviceLookUpEdit
            // 
            serviceLookUpEdit.Location = new Point(7, 61);
            serviceLookUpEdit.Margin = new Padding(4, 6, 4, 6);
            serviceLookUpEdit.Name = "serviceLookUpEdit";
            serviceLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            serviceLookUpEdit.Properties.NullText = "Select Service";
            serviceLookUpEdit.Size = new Size(222, 28);
            serviceLookUpEdit.TabIndex = 8;
            serviceLookUpEdit.EditValueChanged += serviceLookUpEdit_EditValueChanged;
            // 
            // textEditServicePrice
            // 
            textEditServicePrice.Location = new Point(258, 62);
            textEditServicePrice.Margin = new Padding(4, 6, 4, 6);
            textEditServicePrice.Name = "textEditServicePrice";
            textEditServicePrice.Properties.Appearance.Options.UseTextOptions = true;
            textEditServicePrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            textEditServicePrice.Size = new Size(197, 28);
            textEditServicePrice.TabIndex = 9;
            // 
            // quantityTextEdit
            // 
            quantityTextEdit.Location = new Point(7, 133);
            quantityTextEdit.Margin = new Padding(4, 6, 4, 6);
            quantityTextEdit.Name = "quantityTextEdit";
            quantityTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            quantityTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            quantityTextEdit.Size = new Size(222, 28);
            quantityTextEdit.TabIndex = 10;
            // 
            // textEditDiscountHeader
            // 
            textEditDiscountHeader.Location = new Point(635, 188);
            textEditDiscountHeader.Margin = new Padding(4, 6, 4, 6);
            textEditDiscountHeader.Name = "textEditDiscountHeader";
            textEditDiscountHeader.Properties.Appearance.Options.UseTextOptions = true;
            textEditDiscountHeader.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            textEditDiscountHeader.Size = new Size(225, 28);
            textEditDiscountHeader.TabIndex = 11;
            // 
            // totalServiceTextEdit
            // 
            totalServiceTextEdit.Location = new Point(7, 202);
            totalServiceTextEdit.Margin = new Padding(4, 6, 4, 6);
            totalServiceTextEdit.Name = "totalServiceTextEdit";
            totalServiceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            totalServiceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            totalServiceTextEdit.Properties.ReadOnly = true;
            totalServiceTextEdit.Size = new Size(222, 28);
            totalServiceTextEdit.TabIndex = 12;
            // 
            // gridcontrolDetails
            // 
            gridcontrolDetails.EmbeddedNavigator.Margin = new Padding(4, 6, 4, 6);
            gridcontrolDetails.Location = new Point(26, 292);
            gridcontrolDetails.MainView = gridViewdet;
            gridcontrolDetails.Margin = new Padding(4, 6, 4, 6);
            gridcontrolDetails.Name = "gridcontrolDetails";
            gridcontrolDetails.Size = new Size(1213, 413);
            gridcontrolDetails.TabIndex = 13;
            gridcontrolDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewdet });
            gridcontrolDetails.Click += gridcontrolDetails_Click;
            // 
            // gridViewdet
            // 
            gridViewdet.Appearance.EvenRow.Options.UseTextOptions = true;
            gridViewdet.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridViewdet.Appearance.Row.Options.UseTextOptions = true;
            gridViewdet.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridViewdet.DetailHeight = 565;
            gridViewdet.GridControl = gridcontrolDetails;
            gridViewdet.Name = "gridViewdet";
            gridViewdet.OptionsBehavior.Editable = false;
            gridViewdet.OptionsEditForm.PopupEditFormWidth = 1200;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(1244, 301);
            btnSubmit.Margin = new Padding(4, 6, 4, 6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 48);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Add";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(222, 60);
            txtPhone.Margin = new Padding(4, 6, 4, 6);
            txtPhone.Name = "txtPhone";
            txtPhone.Properties.ReadOnly = true;
            txtPhone.Size = new Size(184, 28);
            txtPhone.TabIndex = 15;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(415, 61);
            txtLocation.Margin = new Padding(4, 6, 4, 6);
            txtLocation.Name = "txtLocation";
            txtLocation.Properties.ReadOnly = true;
            txtLocation.Size = new Size(196, 28);
            txtLocation.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(619, 61);
            txtEmail.Margin = new Padding(4, 6, 4, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Properties.ReadOnly = true;
            txtEmail.Size = new Size(229, 28);
            txtEmail.TabIndex = 17;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(7, 30);
            labelControl1.Margin = new Padding(4, 6, 4, 6);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(41, 21);
            labelControl1.TabIndex = 18;
            labelControl1.Text = "Clinic:";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(7, 96);
            labelControl2.Margin = new Padding(4, 6, 4, 6);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(56, 21);
            labelControl2.TabIndex = 19;
            labelControl2.Text = "Contact:";
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(544, 99);
            labelControl3.Margin = new Padding(4, 6, 4, 6);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(46, 21);
            labelControl3.TabIndex = 20;
            labelControl3.Text = "Status:";
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(421, 162);
            labelControl4.Margin = new Padding(4, 6, 4, 6);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(101, 21);
            labelControl4.TabIndex = 21;
            labelControl4.Text = "Discount Type:";
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(222, 98);
            labelControl5.Margin = new Padding(4, 6, 4, 6);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(37, 21);
            labelControl5.TabIndex = 22;
            labelControl5.Text = "Note:";
            // 
            // labelControl6
            // 
            labelControl6.Location = new Point(258, 169);
            labelControl6.Margin = new Padding(4, 6, 4, 6);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(64, 21);
            labelControl6.TabIndex = 23;
            labelControl6.Text = "Discount:";
            // 
            // labelControl7
            // 
            labelControl7.Location = new Point(7, 162);
            labelControl7.Margin = new Padding(4, 6, 4, 6);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(77, 21);
            labelControl7.TabIndex = 24;
            labelControl7.Text = "Initial Date:";
            // 
            // labelControl8
            // 
            labelControl8.Location = new Point(213, 167);
            labelControl8.Margin = new Padding(4, 6, 4, 6);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(81, 21);
            labelControl8.TabIndex = 25;
            labelControl8.Text = "Expire Date:";
            // 
            // labelControl9
            // 
            labelControl9.Location = new Point(7, 30);
            labelControl9.Margin = new Padding(4, 6, 4, 6);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(53, 21);
            labelControl9.TabIndex = 26;
            labelControl9.Text = "Service:";
            // 
            // labelControl10
            // 
            labelControl10.Location = new Point(258, 31);
            labelControl10.Margin = new Padding(4, 6, 4, 6);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(70, 21);
            labelControl10.TabIndex = 27;
            labelControl10.Text = "Unit Price:";
            // 
            // labelControl11
            // 
            labelControl11.Location = new Point(7, 102);
            labelControl11.Margin = new Padding(4, 6, 4, 6);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new Size(63, 21);
            labelControl11.TabIndex = 28;
            labelControl11.Text = "Quantity:";
            // 
            // labelControl12
            // 
            labelControl12.Location = new Point(635, 162);
            labelControl12.Margin = new Padding(4, 6, 4, 6);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new Size(64, 21);
            labelControl12.TabIndex = 29;
            labelControl12.Text = "Discount:";
            // 
            // labelControl13
            // 
            labelControl13.Location = new Point(7, 171);
            labelControl13.Margin = new Padding(4, 6, 4, 6);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new Size(37, 21);
            labelControl13.TabIndex = 30;
            labelControl13.Text = "Total:";
            // 
            // labelControl15
            // 
            labelControl15.Location = new Point(222, 30);
            labelControl15.Margin = new Padding(4, 6, 4, 6);
            labelControl15.Name = "labelControl15";
            labelControl15.Size = new Size(47, 21);
            labelControl15.TabIndex = 32;
            labelControl15.Text = "Phone:";
            // 
            // labelControl16
            // 
            labelControl16.Location = new Point(415, 30);
            labelControl16.Margin = new Padding(4, 6, 4, 6);
            labelControl16.Name = "labelControl16";
            labelControl16.Size = new Size(62, 21);
            labelControl16.TabIndex = 33;
            labelControl16.Text = "Location:";
            // 
            // labelControl17
            // 
            labelControl17.Location = new Point(619, 30);
            labelControl17.Margin = new Padding(4, 6, 4, 6);
            labelControl17.Name = "labelControl17";
            labelControl17.Size = new Size(41, 21);
            labelControl17.TabIndex = 34;
            labelControl17.Text = "Email:";
            // 
            // labelControl18
            // 
            labelControl18.Location = new Point(0, 0);
            labelControl18.Name = "labelControl18";
            labelControl18.Size = new Size(112, 21);
            labelControl18.TabIndex = 0;
            // 
            // labelControl19
            // 
            labelControl19.Location = new Point(0, 0);
            labelControl19.Name = "labelControl19";
            labelControl19.Size = new Size(112, 21);
            labelControl19.TabIndex = 0;
            // 
            // labelControl20
            // 
            labelControl20.Location = new Point(0, 0);
            labelControl20.Name = "labelControl20";
            labelControl20.Size = new Size(112, 21);
            labelControl20.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelControl1);
            groupBox1.Controls.Add(labelControl17);
            groupBox1.Controls.Add(lookUpClinic);
            groupBox1.Controls.Add(labelControl12);
            groupBox1.Controls.Add(labelControl16);
            groupBox1.Controls.Add(labelControl15);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(labelControl4);
            groupBox1.Controls.Add(txtLocation);
            groupBox1.Controls.Add(labelControl8);
            groupBox1.Controls.Add(labelControl5);
            groupBox1.Controls.Add(labelControl3);
            groupBox1.Controls.Add(labelControl7);
            groupBox1.Controls.Add(textEditDiscountHeader);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(textEditNote);
            groupBox1.Controls.Add(comboBoxDiscountTypeHeader);
            groupBox1.Controls.Add(labelControl2);
            groupBox1.Controls.Add(lookUpContact);
            groupBox1.Controls.Add(dateEditInitialDate);
            groupBox1.Controls.Add(dateEditExpireDate);
            groupBox1.Controls.Add(comboBoxStatus);
            groupBox1.Location = new Point(527, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(867, 252);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quotaion Header";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Quotaion
            // 
            Quotaion.Controls.Add(labelControl14);
            Quotaion.Controls.Add(comboBoxDiscountTypeDetail);
            Quotaion.Controls.Add(labelControl9);
            Quotaion.Controls.Add(serviceLookUpEdit);
            Quotaion.Controls.Add(labelControl13);
            Quotaion.Controls.Add(labelControl10);
            Quotaion.Controls.Add(labelControl6);
            Quotaion.Controls.Add(totalServiceTextEdit);
            Quotaion.Controls.Add(labelControl11);
            Quotaion.Controls.Add(textEditServicePrice);
            Quotaion.Controls.Add(quantityTextEdit);
            Quotaion.Controls.Add(textEditDiscountDetail);
            Quotaion.Location = new Point(26, 28);
            Quotaion.Name = "Quotaion";
            Quotaion.Size = new Size(483, 256);
            Quotaion.TabIndex = 36;
            Quotaion.TabStop = false;
            Quotaion.Text = "Quotaion Detail";
            // 
            // labelControl14
            // 
            labelControl14.Location = new Point(258, 99);
            labelControl14.Margin = new Padding(4, 6, 4, 6);
            labelControl14.Name = "labelControl14";
            labelControl14.Size = new Size(101, 21);
            labelControl14.TabIndex = 32;
            labelControl14.Text = "Discount Type:";
            // 
            // comboBoxDiscountTypeDetail
            // 
            comboBoxDiscountTypeDetail.Location = new Point(258, 132);
            comboBoxDiscountTypeDetail.Margin = new Padding(4, 6, 4, 6);
            comboBoxDiscountTypeDetail.Name = "comboBoxDiscountTypeDetail";
            comboBoxDiscountTypeDetail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxDiscountTypeDetail.Size = new Size(197, 28);
            comboBoxDiscountTypeDetail.TabIndex = 31;
            // 
            // AddQuotationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 722);
            Controls.Add(Quotaion);
            Controls.Add(groupBox1);
            Controls.Add(btnSubmit);
            Controls.Add(gridcontrolDetails);
            Font = new Font("Segoe UI", 8F);
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddQuotationForm";
            Text = "Quotation";
            Load += AddQuotationForm_Load;
            ((System.ComponentModel.ISupportInitialize)lookUpClinic.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpContact.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxDiscountTypeHeader.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditNote.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditDiscountDetail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditInitialDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditInitialDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditExpireDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditExpireDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditServicePrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditDiscountHeader.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalServiceTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridcontrolDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPhone.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLocation.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Quotaion.ResumeLayout(false);
            Quotaion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxDiscountTypeDetail.Properties).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpClinic;
        private DevExpress.XtraEditors.LookUpEdit lookUpContact;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxStatus;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxDiscountTypeHeader;
        private DevExpress.XtraEditors.TextEdit textEditNote;
        private DevExpress.XtraEditors.TextEdit textEditDiscountDetail;
        private DevExpress.XtraEditors.DateEdit dateEditInitialDate;
        private DevExpress.XtraEditors.DateEdit dateEditExpireDate;
        private DevExpress.XtraEditors.LookUpEdit serviceLookUpEdit;
        private DevExpress.XtraEditors.TextEdit textEditServicePrice;
        private DevExpress.XtraEditors.TextEdit quantityTextEdit;
        private DevExpress.XtraEditors.TextEdit textEditDiscountHeader;
        private DevExpress.XtraEditors.TextEdit totalServiceTextEdit;
        private DevExpress.XtraGrid.GridControl gridcontrolDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewdet;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtLocation;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private GroupBox groupBox1;
        private GroupBox Quotaion;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxDiscountTypeDetail;
    }
} 