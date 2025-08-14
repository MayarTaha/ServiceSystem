namespace ServiceSystem.PresentationLayer.QuotationHeader
{
    partial class AllQuotations
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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            topPanel = new DevExpress.XtraEditors.PanelControl();
            btnAddQuotation = new DevExpress.XtraEditors.SimpleButton();
            btnAddInvoice = new DevExpress.XtraEditors.SimpleButton();
            lblFilter = new DevExpress.XtraEditors.LabelControl();
            txtFilter = new DevExpress.XtraEditors.TextEdit();
            btnAddClinic = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topPanel).BeginInit();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtFilter.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.EmbeddedNavigator.Margin = new Padding(4, 5, 4, 5);
            gridControl1.Location = new Point(0, 63);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(4, 6, 4, 6);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1131, 594);
            gridControl1.TabIndex = 6;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 565;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsEditForm.PopupEditFormWidth = 1200;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(btnAddQuotation);
            topPanel.Controls.Add(btnAddInvoice);
            topPanel.Controls.Add(lblFilter);
            topPanel.Controls.Add(txtFilter);
            topPanel.Controls.Add(btnAddClinic);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(4, 6, 4, 6);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1131, 63);
            topPanel.TabIndex = 7;
            // 
            // btnAddQuotation
            // 
            btnAddQuotation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddQuotation.Appearance.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddQuotation.Appearance.Options.UseFont = true;
            btnAddQuotation.Location = new Point(969, 15);
            btnAddQuotation.Margin = new Padding(4, 6, 4, 6);
            btnAddQuotation.Name = "btnAddQuotation";
            btnAddQuotation.Size = new Size(154, 36);
            btnAddQuotation.TabIndex = 7;
            btnAddQuotation.Text = "Add Quotaion";
            btnAddQuotation.Click += btnAddQuotation_Click;
            // 
            // btnAddInvoice
            // 
            btnAddInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddInvoice.Appearance.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddInvoice.Appearance.Options.UseFont = true;
            btnAddInvoice.Location = new Point(2060, 15);
            btnAddInvoice.Margin = new Padding(4, 6, 4, 6);
            btnAddInvoice.Name = "btnAddInvoice";
            btnAddInvoice.Size = new Size(108, 36);
            btnAddInvoice.TabIndex = 6;
            btnAddInvoice.Text = "Add Invoice";
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(8, 24);
            lblFilter.Margin = new Padding(4, 6, 4, 6);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(38, 21);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Filter:";
            // 
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFilter.EditValue = "";
            txtFilter.Location = new Point(64, 18);
            txtFilter.Margin = new Padding(4, 6, 4, 6);
            txtFilter.Name = "txtFilter";
            txtFilter.Properties.NullText = "Filter by Quotation name...";
            txtFilter.Properties.NullValuePrompt = "Filter by Quotation name...";
            txtFilter.Size = new Size(878, 34);
            txtFilter.TabIndex = 0;
            txtFilter.EditValueChanged += txtFilter_EditValueChanged;
            // 
            // btnAddClinic
            // 
            btnAddClinic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddClinic.Appearance.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddClinic.Appearance.Options.UseFont = true;
            btnAddClinic.Location = new Point(3042, 19);
            btnAddClinic.Margin = new Padding(4, 6, 4, 6);
            btnAddClinic.Name = "btnAddClinic";
            btnAddClinic.Size = new Size(108, 36);
            btnAddClinic.TabIndex = 1;
            btnAddClinic.Text = "Add Clinic";
            // 
            // AllQuotations
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 657);
            Controls.Add(gridControl1);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 8F);
            IconOptions.Image = Properties.Resources.icons8_offer_40;
            Name = "AllQuotations";
            Text = "AllQuotations";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)topPanel).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtFilter.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl topPanel;
        private DevExpress.XtraEditors.SimpleButton btnAddInvoice;
        private DevExpress.XtraEditors.LabelControl lblFilter;
        private DevExpress.XtraEditors.TextEdit txtFilter;
        private DevExpress.XtraEditors.SimpleButton btnAddClinic;
        private DevExpress.XtraEditors.SimpleButton btnAddQuotation;
    }
}