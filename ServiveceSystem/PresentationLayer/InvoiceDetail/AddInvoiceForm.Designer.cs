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
            groupBox2 = new GroupBox();
            comboBoxDiscountType = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            textEditServicePrice = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            serviceLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            discountValueTextEdit = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            quantityTextEdit = new DevExpress.XtraEditors.TextEdit();
            totalServiceTextEdit = new DevExpress.XtraEditors.TextEdit();
            btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            gridcontrolDetails = new DevExpress.XtraGrid.GridControl();
            gridViewdet = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            CompleteprocessButton = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            TotaltextEdit = new DevExpress.XtraEditors.TextEdit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxDiscountType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditServicePrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountValueTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalServiceTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridcontrolDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotaltextEdit.Properties).BeginInit();
            SuspendLayout();
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
            groupBox2.Location = new Point(37, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1004, 181);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Service";
            // 
            // comboBoxDiscountType
            // 
            comboBoxDiscountType.Location = new Point(183, 79);
            comboBoxDiscountType.Name = "comboBoxDiscountType";
            comboBoxDiscountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxDiscountType.Size = new Size(250, 28);
            comboBoxDiscountType.TabIndex = 28;
            comboBoxDiscountType.SelectedIndexChanged += comboBoxDiscountType_SelectedIndexChanged;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(531, 34);
            labelControl8.Margin = new Padding(3, 4, 3, 4);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(106, 25);
            labelControl8.TabIndex = 22;
            labelControl8.Text = "Service Price :";
            // 
            // textEditServicePrice
            // 
            textEditServicePrice.Location = new Point(696, 34);
            textEditServicePrice.Margin = new Padding(3, 4, 3, 4);
            textEditServicePrice.Name = "textEditServicePrice";
            textEditServicePrice.Size = new Size(250, 28);
            textEditServicePrice.TabIndex = 6;
            textEditServicePrice.EditValueChanged += textEditServicePrice_EditValueChanged;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(42, 34);
            labelControl7.Margin = new Padding(3, 4, 3, 4);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(64, 25);
            labelControl7.TabIndex = 21;
            labelControl7.Text = "Service :";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(531, 119);
            labelControl6.Margin = new Padding(3, 4, 3, 4);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(108, 25);
            labelControl6.TabIndex = 20;
            labelControl6.Text = "Total Service :";
            // 
            // serviceLookUpEdit
            // 
            serviceLookUpEdit.Location = new Point(183, 31);
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
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(531, 76);
            labelControl5.Margin = new Padding(3, 4, 3, 4);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(79, 25);
            labelControl5.TabIndex = 19;
            labelControl5.Text = "Discount :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(42, 119);
            labelControl3.Margin = new Padding(3, 4, 3, 4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(77, 25);
            labelControl3.TabIndex = 17;
            labelControl3.Text = "Quantity :";
            // 
            // discountValueTextEdit
            // 
            discountValueTextEdit.Location = new Point(696, 76);
            discountValueTextEdit.Margin = new Padding(3, 4, 3, 4);
            discountValueTextEdit.Name = "discountValueTextEdit";
            discountValueTextEdit.Size = new Size(250, 28);
            discountValueTextEdit.TabIndex = 5;
            discountValueTextEdit.EditValueChanged += discountValueTextEdit_EditValueChanged;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 9F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(42, 79);
            labelControl2.Margin = new Padding(3, 4, 3, 4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(122, 25);
            labelControl2.TabIndex = 16;
            labelControl2.Text = "Discount Type :";
            // 
            // quantityTextEdit
            // 
            quantityTextEdit.Location = new Point(183, 119);
            quantityTextEdit.Margin = new Padding(3, 4, 3, 4);
            quantityTextEdit.Name = "quantityTextEdit";
            quantityTextEdit.Size = new Size(250, 28);
            quantityTextEdit.TabIndex = 7;
            quantityTextEdit.EditValueChanged += quantityTextEdit_EditValueChanged;
            // 
            // totalServiceTextEdit
            // 
            totalServiceTextEdit.Location = new Point(696, 116);
            totalServiceTextEdit.Margin = new Padding(3, 4, 3, 4);
            totalServiceTextEdit.Name = "totalServiceTextEdit";
            totalServiceTextEdit.Size = new Size(250, 28);
            totalServiceTextEdit.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(1065, 203);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(117, 35);
            btnSubmit.TabIndex = 28;
            btnSubmit.Text = "Add";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // gridcontrolDetails
            // 
            gridcontrolDetails.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridLevelNode1.RelationName = "Level1";
            gridcontrolDetails.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            gridcontrolDetails.Location = new Point(22, 281);
            gridcontrolDetails.MainView = gridViewdet;
            gridcontrolDetails.Margin = new Padding(3, 4, 3, 4);
            gridcontrolDetails.Name = "gridcontrolDetails";
            gridcontrolDetails.Size = new Size(1472, 455);
            gridcontrolDetails.TabIndex = 27;
            gridcontrolDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewdet });
            // 
            // gridViewdet
            // 
            gridViewdet.Appearance.GroupPanel.BackColor = Color.Black;
            gridViewdet.Appearance.GroupPanel.ForeColor = Color.FromArgb(64, 64, 64);
            gridViewdet.Appearance.GroupPanel.Options.UseBackColor = true;
            gridViewdet.Appearance.GroupPanel.Options.UseForeColor = true;
            gridViewdet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn3, gridColumn2, gridColumn4, gridColumn5, gridColumn6 });
            gridViewdet.DetailHeight = 417;
            gridViewdet.GridControl = gridcontrolDetails;
            gridViewdet.Name = "gridViewdet";
            // 
            // gridColumn1
            // 
            gridColumn1.AccessibleName = "colServiceId";
            gridColumn1.Caption = "Service";
            gridColumn1.FieldName = "ServiceId";
            gridColumn1.MinWidth = 30;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 112;
            // 
            // gridColumn3
            // 
            gridColumn3.AccessibleName = "colDiscount";
            gridColumn3.Caption = "Discount";
            gridColumn3.FieldName = "Discount";
            gridColumn3.MinWidth = 30;
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 1;
            gridColumn3.Width = 112;
            // 
            // gridColumn2
            // 
            gridColumn2.AccessibleName = "colQuantity";
            gridColumn2.Caption = "Quantity";
            gridColumn2.FieldName = "Quantity";
            gridColumn2.MinWidth = 30;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 2;
            gridColumn2.Width = 112;
            // 
            // gridColumn4
            // 
            gridColumn4.AccessibleName = "colDiscountType";
            gridColumn4.Caption = "DiscountType";
            gridColumn4.FieldName = "DiscountType";
            gridColumn4.MinWidth = 30;
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 112;
            // 
            // gridColumn5
            // 
            gridColumn5.AccessibleName = "colServicePrice";
            gridColumn5.Caption = "ServicePrice";
            gridColumn5.FieldName = "ServicePrice";
            gridColumn5.MinWidth = 30;
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 112;
            // 
            // gridColumn6
            // 
            gridColumn6.AccessibleName = "colTotalService";
            gridColumn6.Caption = "TotalService";
            gridColumn6.FieldName = "TotalService";
            gridColumn6.MinWidth = 30;
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            gridColumn6.Width = 112;
            // 
            // CompleteprocessButton
            // 
            CompleteprocessButton.Location = new Point(1244, 195);
            CompleteprocessButton.Margin = new Padding(3, 4, 3, 4);
            CompleteprocessButton.Name = "CompleteprocessButton";
            CompleteprocessButton.Size = new Size(198, 46);
            CompleteprocessButton.TabIndex = 32;
            CompleteprocessButton.Text = "Complete process";
            CompleteprocessButton.Click += CompleteprocessButton_Click;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(1244, 73);
            labelControl1.Margin = new Padding(3, 4, 3, 4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(91, 38);
            labelControl1.TabIndex = 33;
            labelControl1.Text = "Total  :";
            // 
            // TotaltextEdit
            // 
            TotaltextEdit.Location = new Point(1244, 127);
            TotaltextEdit.Margin = new Padding(3, 4, 3, 4);
            TotaltextEdit.Name = "TotaltextEdit";
            TotaltextEdit.Size = new Size(250, 28);
            TotaltextEdit.TabIndex = 34;
            // 
            // AddInvoiceForm
            // 
            Appearance.BackColor = SystemColors.InactiveCaptionText;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 782);
            Controls.Add(TotaltextEdit);
            Controls.Add(labelControl1);
            Controls.Add(CompleteprocessButton);
            Controls.Add(groupBox2);
            Controls.Add(btnSubmit);
            Controls.Add(gridcontrolDetails);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            LookAndFeel.SkinName = "Office 2019 Black";
            LookAndFeel.UseDefaultLookAndFeel = false;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddInvoiceForm";
            Padding = new Padding(20);
            RightToLeftLayout = true;
            ShowMdiChildCaptionInParentTitle = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxDiscountType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditServicePrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)discountValueTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalServiceTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridcontrolDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotaltextEdit.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit discountLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetails;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEditServicePrice;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit serviceLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit discountValueTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit quantityTextEdit;
        private DevExpress.XtraEditors.TextEdit totalServiceTextEdit;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraGrid.GridControl gridcontrolDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewdet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton CompleteprocessButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TotaltextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxDiscountType;
    }
}