namespace ServiveceSystem.PresentationLayer.Reports
{
    partial class InvoicesReportForm
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
            if (disposing && _context != null)
            {
                _context.Dispose();
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnViewInvoiceDetails = new DevExpress.XtraEditors.SimpleButton();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnExport = new DevExpress.XtraEditors.SimpleButton();
            btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            lblClinicName = new DevExpress.XtraEditors.LabelControl();
            lblTotalInvoices = new DevExpress.XtraEditors.LabelControl();
            lblTotalOutstanding = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.EmbeddedNavigator.Margin = new Padding(6, 9, 6, 9);
            gridControl1.Location = new Point(0, 100);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1000, 502);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.DoubleClick += gridView1_DoubleClick;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnViewInvoiceDetails);
            panelControl1.Controls.Add(btnPrint);
            panelControl1.Controls.Add(btnExport);
            panelControl1.Controls.Add(btnRefresh);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1000, 50);
            panelControl1.TabIndex = 1;
            // 
            // btnViewInvoiceDetails
            // 
            btnViewInvoiceDetails.Location = new Point(12, 12);
            btnViewInvoiceDetails.Name = "btnViewInvoiceDetails";
            btnViewInvoiceDetails.Size = new Size(156, 30);
            btnViewInvoiceDetails.TabIndex = 3;
            btnViewInvoiceDetails.Text = "View Invoice Details";
            btnViewInvoiceDetails.Click += btnViewInvoiceDetails_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(870, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(100, 30);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(760, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 30);
            btnExport.TabIndex = 1;
            btnExport.Text = "Export";
            btnExport.Click += btnExport_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(650, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(lblClinicName);
            panelControl2.Controls.Add(lblTotalInvoices);
            panelControl2.Controls.Add(lblTotalOutstanding);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(0, 50);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(1000, 50);
            panelControl2.TabIndex = 2;
            // 
            // lblClinicName
            // 
            lblClinicName.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblClinicName.Appearance.ForeColor = Color.Navy;
            lblClinicName.Appearance.Options.UseFont = true;
            lblClinicName.Appearance.Options.UseForeColor = true;
            lblClinicName.Location = new Point(12, 15);
            lblClinicName.Name = "lblClinicName";
            lblClinicName.Size = new Size(68, 24);
            lblClinicName.TabIndex = 2;
            lblClinicName.Text = "Clinic: ";
            // 
            // lblTotalInvoices
            // 
            lblTotalInvoices.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblTotalInvoices.Appearance.ForeColor = Color.Green;
            lblTotalInvoices.Appearance.Options.UseFont = true;
            lblTotalInvoices.Appearance.Options.UseForeColor = true;
            lblTotalInvoices.Location = new Point(400, 15);
            lblTotalInvoices.Name = "lblTotalInvoices";
            lblTotalInvoices.Size = new Size(377, 22);
            lblTotalInvoices.TabIndex = 1;
            lblTotalInvoices.Text = "Total Invoices with Outstanding Balance: ";
            // 
            // lblTotalOutstanding
            // 
            lblTotalOutstanding.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblTotalOutstanding.Appearance.ForeColor = Color.Red;
            lblTotalOutstanding.Appearance.Options.UseFont = true;
            lblTotalOutstanding.Appearance.Options.UseForeColor = true;
            lblTotalOutstanding.Location = new Point(700, 15);
            lblTotalOutstanding.Name = "lblTotalOutstanding";
            lblTotalOutstanding.Size = new Size(173, 22);
            lblTotalOutstanding.TabIndex = 0;
            lblTotalOutstanding.Text = "Total Outstanding: ";
            // 
            // InvoicesReportForm
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 602);
            Controls.Add(gridControl1);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Font = new Font("Segoe UI", 8.25F);
            IconOptions.Image = ServiceSystem.Properties.Resources.icons8_invoice_64;
            Name = "InvoicesReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoices Report";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnViewInvoiceDetails;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblTotalOutstanding;
        private DevExpress.XtraEditors.LabelControl lblTotalInvoices;
        private DevExpress.XtraEditors.LabelControl lblClinicName;
    }
} 