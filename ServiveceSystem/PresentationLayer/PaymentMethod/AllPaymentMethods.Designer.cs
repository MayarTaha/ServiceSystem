namespace ServiveceSystem.PresentationLayer.PaymentMethod
{
    partial class AllPaymentMethods
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            txtFilter = new DevExpress.XtraEditors.TextEdit();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
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
            gridControl1.Location = new Point(0, 39);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(784, 422);
            gridControl1.TabIndex = 2;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFilter.Location = new Point(46, 11);
            txtFilter.Name = "txtFilter";
            txtFilter.Properties.NullText = "Filter by payment type...";
            txtFilter.Size = new Size(648, 22);
            txtFilter.TabIndex = 0;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Appearance.Font = new Font("Segoe UI Semilight", 9.75F);
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Location = new Point(700, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(72, 22);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(lblFilter);
            topPanel.Controls.Add(txtFilter);
            topPanel.Controls.Add(btnAdd);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(784, 39);
            topPanel.TabIndex = 3;
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(5, 15);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(29, 13);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Filter:";
            // 
            // AllPaymentMethods
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(gridControl1);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AllPaymentMethods";
            Text = "All Payment Methods";
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
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.PanelControl topPanel;
        private DevExpress.XtraEditors.LabelControl lblFilter;
    }
} 