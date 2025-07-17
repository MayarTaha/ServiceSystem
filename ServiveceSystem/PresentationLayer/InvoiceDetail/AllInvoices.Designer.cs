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
            txtFilter = new DevExpress.XtraEditors.TextEdit();
            btnAddClinic = new DevExpress.XtraEditors.SimpleButton();
            topPanel = new DevExpress.XtraEditors.PanelControl();
            btnAddInvoice = new DevExpress.XtraEditors.SimpleButton();
            lblFilter = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFilter.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topPanel).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.EmbeddedNavigator.Margin = new Padding(4, 5, 4, 5);
            gridControl1.Location = new Point(0, 63);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(4, 5, 4, 5);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1261, 773);
            gridControl1.TabIndex = 4;
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
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFilter.EditValue = "Filter by Name...";
            txtFilter.Location = new Point(54, 18);
            txtFilter.Margin = new Padding(4, 5, 4, 5);
            txtFilter.Name = "txtFilter";
            txtFilter.Properties.NullValuePrompt = "Filter by name...";
            txtFilter.Size = new Size(1066, 34);
            txtFilter.TabIndex = 0;
            // 
            // btnAddClinic
            // 
            btnAddClinic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddClinic.Appearance.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddClinic.Appearance.Options.UseFont = true;
            btnAddClinic.Location = new Point(2111, 19);
            btnAddClinic.Margin = new Padding(4, 5, 4, 5);
            btnAddClinic.Name = "btnAddClinic";
            btnAddClinic.Size = new Size(108, 36);
            btnAddClinic.TabIndex = 1;
            btnAddClinic.Text = "Add Clinic";
            // 
            // topPanel
            // 
            topPanel.Controls.Add(btnAddInvoice);
            topPanel.Controls.Add(lblFilter);
            topPanel.Controls.Add(txtFilter);
            topPanel.Controls.Add(btnAddClinic);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(4, 5, 4, 5);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1261, 63);
            topPanel.TabIndex = 5;
            // 
            // btnAddInvoice
            // 
            btnAddInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddInvoice.Appearance.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddInvoice.Appearance.Options.UseFont = true;
            btnAddInvoice.Location = new Point(1128, 16);
            btnAddInvoice.Margin = new Padding(4, 5, 4, 5);
            btnAddInvoice.Name = "btnAddInvoice";
            btnAddInvoice.Size = new Size(108, 36);
            btnAddInvoice.TabIndex = 6;
            btnAddInvoice.Text = "Add Invoice";
            btnAddInvoice.Click += btnAddInvoice_Click;
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(8, 24);
            lblFilter.Margin = new Padding(4, 5, 4, 5);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(38, 21);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Filter:";
            // 
            // AllInvoices
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 836);
            Controls.Add(gridControl1);
            Controls.Add(topPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AllInvoices";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFilter.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)topPanel).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtFilter;
        private DevExpress.XtraEditors.SimpleButton btnAddClinic;
        private DevExpress.XtraEditors.PanelControl topPanel;
        private DevExpress.XtraEditors.LabelControl lblFilter;
        private DevExpress.XtraEditors.SimpleButton btnAddInvoice;
    }
}