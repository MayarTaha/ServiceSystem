using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.Reports
{
    partial class ClientReportForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTotalClients = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalOutstanding = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewInvoices = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1200, 600);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblTotalClients);
            this.panelControl1.Controls.Add(this.lblTotalOutstanding);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.btnExport);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.btnViewInvoices);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 600);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1200, 80);
            this.panelControl1.TabIndex = 1;
            // 
            // lblTotalClients
            // 
            this.lblTotalClients.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalClients.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalClients.Location = new System.Drawing.Point(12, 45);
            this.lblTotalClients.Name = "lblTotalClients";
            this.lblTotalClients.Size = new System.Drawing.Size(200, 16);
            this.lblTotalClients.TabIndex = 5;
            this.lblTotalClients.Text = "Total Clients with Outstanding Balance: 0";
            // 
            // lblTotalOutstanding
            // 
            this.lblTotalOutstanding.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalOutstanding.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalOutstanding.Location = new System.Drawing.Point(12, 15);
            this.lblTotalOutstanding.Name = "lblTotalOutstanding";
            this.lblTotalOutstanding.Size = new System.Drawing.Size(150, 16);
            this.lblTotalOutstanding.TabIndex = 4;
            this.lblTotalOutstanding.Text = "Total Outstanding: $0.00";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.Image = global::ServiceSystem.Properties.Resources.icons8_invoice_64;
            this.btnPrint.Location = new System.Drawing.Point(1100, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 40);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ImageOptions.Image = global::ServiceSystem.Properties.Resources.icons8_invoice_64;
            this.btnExport.Location = new System.Drawing.Point(1000, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 40);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.ImageOptions.Image = global::ServiceSystem.Properties.Resources.icons8_invoice_64;
            this.btnRefresh.Location = new System.Drawing.Point(900, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnViewInvoices
            // 
            this.btnViewInvoices.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnViewInvoices.Appearance.Options.UseFont = true;
            this.btnViewInvoices.ImageOptions.Image = global::ServiceSystem.Properties.Resources.icons8_invoice_64;
            this.btnViewInvoices.Location = new System.Drawing.Point(800, 15);
            this.btnViewInvoices.Name = "btnViewInvoices";
            this.btnViewInvoices.Size = new System.Drawing.Size(80, 40);
            this.btnViewInvoices.TabIndex = 4;
            this.btnViewInvoices.Text = "View Invoices";
            this.btnViewInvoices.Click += new System.EventHandler(this.btnViewInvoices_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelControl1.Location = new System.Drawing.Point(400, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(200, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Client Outstanding Balance Report";
            // 
            // ClientReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "ClientReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Outstanding Balance Report";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnViewInvoices;
        private DevExpress.XtraEditors.LabelControl lblTotalOutstanding;
        private DevExpress.XtraEditors.LabelControl lblTotalClients;
    }
} 