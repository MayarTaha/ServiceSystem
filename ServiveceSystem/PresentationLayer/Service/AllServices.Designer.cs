namespace ServiveceSystem.PresentationLayer.Service
{
    partial class AllServices
    {
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAddService;
        private DevExpress.XtraEditors.TextEdit txtFilter;
        private DevExpress.XtraEditors.PanelControl topPanel;
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnAddService = new DevExpress.XtraEditors.SimpleButton();
            txtFilter = new DevExpress.XtraEditors.TextEdit();
            topPanel = new DevExpress.XtraEditors.PanelControl();
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
            gridControl1.Location = new Point(0, 45);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(784, 416);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnAddService
            // 
            btnAddService.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddService.Location = new Point(699, 12);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(80, 23);
            btnAddService.TabIndex = 1;
            btnAddService.Text = "Add Service";
            btnAddService.Click += btnAddService_Click;
            // 
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFilter.Location = new Point(49, 13);
            txtFilter.Name = "txtFilter";
            txtFilter.Properties.NullText = "Filter by name...";
            txtFilter.Size = new Size(644, 22);
            txtFilter.TabIndex = 2;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(lblFilter);
            topPanel.Controls.Add(txtFilter);
            topPanel.Controls.Add(btnAddService);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(784, 45);
            topPanel.TabIndex = 1;
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(14, 17);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(29, 13);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Filter:";
            // 
            // AllServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(gridControl1);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AllServices";
            StartPosition = FormStartPosition.CenterParent;
            Text = "All Services";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFilter.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)topPanel).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }
        private DevExpress.XtraEditors.LabelControl lblFilter;
    }
} 