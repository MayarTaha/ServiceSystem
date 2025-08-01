﻿namespace ServiceSystem.PresentationLayer.Quotation
{
    partial class QuotationForm
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
            savebutton = new DevExpress.XtraEditors.SimpleButton();
            Invoice = new GroupBox();
            prioritycomboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            totaltextEdit = new DevExpress.XtraEditors.TextEdit();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            quotationNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            textEditDiscountHeader = new DevExpress.XtraEditors.TextEdit();
            comboBoxDiscountType = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            initialDateEdit = new DevExpress.XtraEditors.DateEdit();
            expireDateEdit = new DevExpress.XtraEditors.DateEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            comboBoxStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            noteRichTextBox = new RichTextBox();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            groupBox1 = new GroupBox();
            contactLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            locationTextEdit = new DevExpress.XtraEditors.TextEdit();
            phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            labelControl15 = new DevExpress.XtraEditors.LabelControl();
            labelControl14 = new DevExpress.XtraEditors.LabelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            clinicLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prioritycomboBoxEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totaltextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotationNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditDiscountHeader.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxDiscountType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialDateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expireDateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expireDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxStatus.Properties).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contactLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emailTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)locationTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phoneTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clinicLookUpEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // savebutton
            // 
            savebutton.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savebutton.Appearance.Options.UseFont = true;
            savebutton.Location = new Point(480, 307);
            savebutton.Margin = new Padding(3, 4, 3, 4);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(726, 35);
            savebutton.TabIndex = 38;
            savebutton.Text = "Save";
            savebutton.Click += savebutton_Click;
            // 
            // Invoice
            // 
            Invoice.Controls.Add(prioritycomboBoxEdit);
            Invoice.Controls.Add(totaltextEdit);
            Invoice.Controls.Add(labelControl10);
            Invoice.Controls.Add(labelControl6);
            Invoice.Controls.Add(quotationNameTextEdit);
            Invoice.Controls.Add(labelControl12);
            Invoice.Controls.Add(labelControl5);
            Invoice.Controls.Add(textEditDiscountHeader);
            Invoice.Controls.Add(comboBoxDiscountType);
            Invoice.Controls.Add(labelControl8);
            Invoice.Controls.Add(labelControl7);
            Invoice.Controls.Add(initialDateEdit);
            Invoice.Controls.Add(expireDateEdit);
            Invoice.Controls.Add(labelControl3);
            Invoice.Controls.Add(comboBoxStatus);
            Invoice.Controls.Add(labelControl11);
            Invoice.Controls.Add(noteRichTextBox);
            Invoice.Controls.Add(labelControl2);
            Invoice.Controls.Add(labelControl4);
            Invoice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Invoice.Location = new Point(459, 12);
            Invoice.Name = "Invoice";
            Invoice.Size = new Size(742, 288);
            Invoice.TabIndex = 37;
            Invoice.TabStop = false;
            Invoice.Text = "Quotation";
            // 
            // prioritycomboBoxEdit
            // 
            prioritycomboBoxEdit.Location = new Point(514, 33);
            prioritycomboBoxEdit.Margin = new Padding(4, 6, 4, 6);
            prioritycomboBoxEdit.Name = "prioritycomboBoxEdit";
            prioritycomboBoxEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            prioritycomboBoxEdit.Properties.Appearance.Options.UseFont = true;
            prioritycomboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            prioritycomboBoxEdit.Size = new Size(221, 32);
            prioritycomboBoxEdit.TabIndex = 45;
            // 
            // totaltextEdit
            // 
            totaltextEdit.Location = new Point(514, 206);
            totaltextEdit.Margin = new Padding(4, 6, 4, 6);
            totaltextEdit.Name = "totaltextEdit";
            totaltextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totaltextEdit.Properties.Appearance.Options.UseFont = true;
            totaltextEdit.Properties.Appearance.Options.UseTextOptions = true;
            totaltextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            totaltextEdit.Size = new Size(225, 46);
            totaltextEdit.TabIndex = 44;
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Location = new Point(535, 168);
            labelControl10.Margin = new Padding(3, 4, 3, 4);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(90, 37);
            labelControl10.TabIndex = 43;
            labelControl10.Text = "Total :";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(409, 34);
            labelControl6.Margin = new Padding(3, 4, 3, 4);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(65, 24);
            labelControl6.TabIndex = 41;
            labelControl6.Text = "priority :";
            // 
            // quotationNameTextEdit
            // 
            quotationNameTextEdit.Location = new Point(162, 28);
            quotationNameTextEdit.Margin = new Padding(4, 6, 4, 6);
            quotationNameTextEdit.Name = "quotationNameTextEdit";
            quotationNameTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            quotationNameTextEdit.Properties.Appearance.Options.UseFont = true;
            quotationNameTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            quotationNameTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            quotationNameTextEdit.Size = new Size(225, 32);
            quotationNameTextEdit.TabIndex = 40;
            // 
            // labelControl12
            // 
            labelControl12.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl12.Appearance.Options.UseFont = true;
            labelControl12.Location = new Point(263, 125);
            labelControl12.Margin = new Padding(4, 6, 4, 6);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new Size(78, 24);
            labelControl12.TabIndex = 39;
            labelControl12.Text = "Discount:";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(18, 129);
            labelControl5.Margin = new Padding(4, 6, 4, 6);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(126, 24);
            labelControl5.TabIndex = 38;
            labelControl5.Text = "Discount Type:";
            // 
            // textEditDiscountHeader
            // 
            textEditDiscountHeader.Location = new Point(232, 155);
            textEditDiscountHeader.Margin = new Padding(4, 6, 4, 6);
            textEditDiscountHeader.Name = "textEditDiscountHeader";
            textEditDiscountHeader.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            textEditDiscountHeader.Properties.Appearance.Options.UseFont = true;
            textEditDiscountHeader.Properties.Appearance.Options.UseTextOptions = true;
            textEditDiscountHeader.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            textEditDiscountHeader.Size = new Size(160, 32);
            textEditDiscountHeader.TabIndex = 37;
            textEditDiscountHeader.EditValueChanged += textEditDiscountHeader_EditValueChanged;
            // 
            // comboBoxDiscountType
            // 
            comboBoxDiscountType.Location = new Point(12, 155);
            comboBoxDiscountType.Margin = new Padding(4, 6, 4, 6);
            comboBoxDiscountType.Name = "comboBoxDiscountType";
            comboBoxDiscountType.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            comboBoxDiscountType.Properties.Appearance.Options.UseFont = true;
            comboBoxDiscountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxDiscountType.Size = new Size(194, 32);
            comboBoxDiscountType.TabIndex = 36;
            comboBoxDiscountType.SelectedIndexChanged += comboBoxDiscountType_SelectedIndexChanged;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(405, 116);
            labelControl8.Margin = new Padding(4, 6, 4, 6);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(103, 24);
            labelControl8.TabIndex = 35;
            labelControl8.Text = "Expire Date:";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(405, 72);
            labelControl7.Margin = new Padding(4, 6, 4, 6);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(89, 24);
            labelControl7.TabIndex = 34;
            labelControl7.Text = "Initial Date:";
            // 
            // initialDateEdit
            // 
            initialDateEdit.EditValue = null;
            initialDateEdit.Location = new Point(516, 72);
            initialDateEdit.Margin = new Padding(4, 6, 4, 6);
            initialDateEdit.Name = "initialDateEdit";
            initialDateEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            initialDateEdit.Properties.Appearance.Options.UseFont = true;
            initialDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            initialDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            initialDateEdit.Size = new Size(221, 32);
            initialDateEdit.TabIndex = 32;
            // 
            // expireDateEdit
            // 
            expireDateEdit.EditValue = null;
            expireDateEdit.Location = new Point(516, 112);
            expireDateEdit.Margin = new Padding(4, 6, 4, 6);
            expireDateEdit.Name = "expireDateEdit";
            expireDateEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            expireDateEdit.Properties.Appearance.Options.UseFont = true;
            expireDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            expireDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            expireDateEdit.Size = new Size(221, 32);
            expireDateEdit.TabIndex = 33;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(13, 63);
            labelControl3.Margin = new Padding(4, 6, 4, 6);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(55, 24);
            labelControl3.TabIndex = 31;
            labelControl3.Text = "Status:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Location = new Point(162, 68);
            comboBoxStatus.Margin = new Padding(4, 6, 4, 6);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            comboBoxStatus.Properties.Appearance.Options.UseFont = true;
            comboBoxStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxStatus.Size = new Size(225, 32);
            comboBoxStatus.TabIndex = 30;
            // 
            // labelControl11
            // 
            labelControl11.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl11.Appearance.Options.UseFont = true;
            labelControl11.Location = new Point(13, 29);
            labelControl11.Margin = new Padding(3, 4, 3, 4);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new Size(147, 24);
            labelControl11.TabIndex = 29;
            labelControl11.Text = "Quotation Name :";
            // 
            // noteRichTextBox
            // 
            noteRichTextBox.Font = new Font("Microsoft Sans Serif", 14.25F);
            noteRichTextBox.Location = new Point(91, 198);
            noteRichTextBox.Name = "noteRichTextBox";
            noteRichTextBox.Size = new Size(250, 70);
            noteRichTextBox.TabIndex = 28;
            noteRichTextBox.Text = "";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(21, 210);
            labelControl2.Margin = new Padding(3, 4, 3, 4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(50, 24);
            labelControl2.TabIndex = 27;
            labelControl2.Text = "Note :";
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(0, 0);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(0, 13);
            labelControl4.TabIndex = 26;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(contactLookUpEdit);
            groupBox1.Controls.Add(labelControl13);
            groupBox1.Controls.Add(emailTextEdit);
            groupBox1.Controls.Add(locationTextEdit);
            groupBox1.Controls.Add(phoneTextEdit);
            groupBox1.Controls.Add(labelControl15);
            groupBox1.Controls.Add(labelControl14);
            groupBox1.Controls.Add(labelControl9);
            groupBox1.Controls.Add(labelControl1);
            groupBox1.Controls.Add(clinicLookUpEdit);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(5, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 288);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client";
            // 
            // contactLookUpEdit
            // 
            contactLookUpEdit.Location = new Point(149, 234);
            contactLookUpEdit.Margin = new Padding(3, 4, 3, 4);
            contactLookUpEdit.Name = "contactLookUpEdit";
            contactLookUpEdit.Properties.Appearance.Font = new Font("Segoe UI", 14.25F);
            contactLookUpEdit.Properties.Appearance.ForeColor = Color.Silver;
            contactLookUpEdit.Properties.Appearance.Options.UseFont = true;
            contactLookUpEdit.Properties.Appearance.Options.UseForeColor = true;
            contactLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            contactLookUpEdit.Properties.NullText = "Select Contact";
            contactLookUpEdit.Size = new Size(250, 34);
            contactLookUpEdit.TabIndex = 30;
            // 
            // labelControl13
            // 
            labelControl13.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl13.Appearance.Options.UseFont = true;
            labelControl13.Location = new Point(15, 238);
            labelControl13.Margin = new Padding(3, 4, 3, 4);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new Size(73, 24);
            labelControl13.TabIndex = 29;
            labelControl13.Text = "Contact :";
            // 
            // emailTextEdit
            // 
            emailTextEdit.Location = new Point(149, 78);
            emailTextEdit.Margin = new Padding(3, 4, 3, 4);
            emailTextEdit.Name = "emailTextEdit";
            emailTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 14.25F);
            emailTextEdit.Properties.Appearance.Options.UseFont = true;
            emailTextEdit.Size = new Size(250, 34);
            emailTextEdit.TabIndex = 28;
            // 
            // locationTextEdit
            // 
            locationTextEdit.Location = new Point(149, 178);
            locationTextEdit.Margin = new Padding(3, 4, 3, 4);
            locationTextEdit.Name = "locationTextEdit";
            locationTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 14.25F);
            locationTextEdit.Properties.Appearance.Options.UseFont = true;
            locationTextEdit.Size = new Size(250, 34);
            locationTextEdit.TabIndex = 27;
            // 
            // phoneTextEdit
            // 
            phoneTextEdit.Location = new Point(149, 130);
            phoneTextEdit.Margin = new Padding(3, 4, 3, 4);
            phoneTextEdit.Name = "phoneTextEdit";
            phoneTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 14.25F);
            phoneTextEdit.Properties.Appearance.Options.UseFont = true;
            phoneTextEdit.Size = new Size(250, 34);
            phoneTextEdit.TabIndex = 26;
            // 
            // labelControl15
            // 
            labelControl15.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl15.Appearance.Options.UseFont = true;
            labelControl15.Location = new Point(17, 133);
            labelControl15.Margin = new Padding(3, 4, 3, 4);
            labelControl15.Name = "labelControl15";
            labelControl15.Size = new Size(65, 24);
            labelControl15.TabIndex = 25;
            labelControl15.Text = "phone :";
            // 
            // labelControl14
            // 
            labelControl14.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl14.Appearance.Options.UseFont = true;
            labelControl14.Location = new Point(15, 181);
            labelControl14.Margin = new Padding(3, 4, 3, 4);
            labelControl14.Name = "labelControl14";
            labelControl14.Size = new Size(81, 24);
            labelControl14.TabIndex = 24;
            labelControl14.Text = "Location :";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new Point(17, 85);
            labelControl9.Margin = new Padding(3, 4, 3, 4);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(57, 24);
            labelControl9.TabIndex = 23;
            labelControl9.Text = "Email :";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 14.25F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(17, 34);
            labelControl1.Margin = new Padding(3, 4, 3, 4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(112, 24);
            labelControl1.TabIndex = 15;
            labelControl1.Text = "Clinic Name :";
            // 
            // clinicLookUpEdit
            // 
            clinicLookUpEdit.Location = new Point(149, 31);
            clinicLookUpEdit.Margin = new Padding(3, 4, 3, 4);
            clinicLookUpEdit.Name = "clinicLookUpEdit";
            clinicLookUpEdit.Properties.Appearance.Font = new Font("Segoe UI", 14.25F);
            clinicLookUpEdit.Properties.Appearance.ForeColor = Color.Silver;
            clinicLookUpEdit.Properties.Appearance.Options.UseFont = true;
            clinicLookUpEdit.Properties.Appearance.Options.UseForeColor = true;
            clinicLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            clinicLookUpEdit.Properties.NullText = "Select Clinic";
            clinicLookUpEdit.Size = new Size(250, 34);
            clinicLookUpEdit.TabIndex = 1;
            clinicLookUpEdit.EditValueChanged += clinicLookUpEdit_EditValueChanged;
            // 
            // QuotationForm
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 355);
            Controls.Add(savebutton);
            Controls.Add(Invoice);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 8F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "QuotationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "QuotationForm";
            Invoice.ResumeLayout(false);
            Invoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prioritycomboBoxEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totaltextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotationNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditDiscountHeader.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxDiscountType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)initialDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)initialDateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)expireDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)expireDateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxStatus.Properties).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contactLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)emailTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)locationTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)phoneTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)clinicLookUpEdit.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton savebutton;
        private GroupBox Invoice;
        private DevExpress.XtraEditors.TextEdit totaltextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit quotationNameTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEditDiscountHeader;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxDiscountTypeHeader;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit initialDateEdit;
        private DevExpress.XtraEditors.DateEdit expireDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxStatus;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private RichTextBox noteRichTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit contactLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.TextEdit locationTextEdit;
        private DevExpress.XtraEditors.TextEdit phoneTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit clinicLookUpEdit;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxDiscountType;
        private DevExpress.XtraEditors.ComboBoxEdit prioritycomboBoxEdit;
    }
}