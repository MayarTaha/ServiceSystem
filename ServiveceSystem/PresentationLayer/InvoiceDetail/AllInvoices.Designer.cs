namespace ServiceSystem.PresentationLayer.InvoiceDetail
{
    partial class AllInvoices
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
            btnAddClinic = new DevExpress.XtraEditors.SimpleButton();
            topPanel = new DevExpress.XtraEditors.PanelControl();
            txtFilter = new DevExpress.XtraEditors.TextEdit();
            btnAddInvoice = new DevExpress.XtraEditors.SimpleButton();
            lblFilter = new DevExpress.XtraEditors.LabelControl();
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
            gridControl1.EmbeddedNavigator.Margin = new Padding(4);
            gridControl1.Location = new Point(0, 63);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(4);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1262, 694);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 566;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsEditForm.PopupEditFormWidth = 1200;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnAddClinic
            // 
            btnAddClinic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddClinic.Appearance.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddClinic.Appearance.Options.UseFont = true;
            btnAddClinic.Location = new Point(2110, 20);
            btnAddClinic.Margin = new Padding(4);
            btnAddClinic.Name = "btnAddClinic";
            btnAddClinic.Size = new Size(108, 35);
            btnAddClinic.TabIndex = 1;
            btnAddClinic.Text = "Add Clinic";
            // 
            // topPanel
            // 
            topPanel.Controls.Add(txtFilter);
            topPanel.Controls.Add(btnAddInvoice);
            topPanel.Controls.Add(lblFilter);
            topPanel.Controls.Add(btnAddClinic);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1262, 63);
            topPanel.TabIndex = 5;
            // 
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFilter.EditValue = "Filter by Reminder...";
            txtFilter.Location = new Point(57, 21);
            txtFilter.Margin = new Padding(4);
            txtFilter.Name = "txtFilter";
            txtFilter.Properties.NullText = "Filter by clinic name...";
            txtFilter.Size = new Size(972, 34);
            txtFilter.TabIndex = 7;
            txtFilter.EditValueChanged += txtFilter_EditValueChanged;
            // 
            // btnAddInvoice
            // 
            btnAddInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddInvoice.Appearance.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddInvoice.Appearance.Options.UseFont = true;
            btnAddInvoice.Location = new Point(1128, 17);
            btnAddInvoice.Margin = new Padding(4);
            btnAddInvoice.Name = "btnAddInvoice";
            btnAddInvoice.Size = new Size(108, 35);
            btnAddInvoice.TabIndex = 6;
            btnAddInvoice.Text = "Add Invoice";
            btnAddInvoice.Click += btnAddInvoice_Click;
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(8, 24);
            lblFilter.Margin = new Padding(4);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(38, 21);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Filter:";
            // 
            // AllInvoices
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 757);
            Controls.Add(gridControl1);
            Controls.Add(topPanel);
            IconOptions.Image = Properties.Resources.icons8_invoice_64;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AllInvoices";
            Text = "All Invoicecs";
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
        private DevExpress.XtraEditors.SimpleButton btnAddClinic;
        private DevExpress.XtraEditors.PanelControl topPanel;
        private DevExpress.XtraEditors.LabelControl lblFilter;
        private DevExpress.XtraEditors.SimpleButton btnAddInvoice;
        private DevExpress.XtraEditors.TextEdit txtFilter;
    }
}