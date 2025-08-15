namespace ServiveceSystem.PresentationLayer.Taxes
{
    partial class AllTaxes
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
            btnAddTaxes = new DevExpress.XtraEditors.SimpleButton();
            lblFilter = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFilter.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControl1.Location = new Point(12, 47);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(772, 422);
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
            txtFilter.Properties.NullText = "Filter by tax name...";
            txtFilter.Size = new Size(648, 22);
            txtFilter.TabIndex = 0;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // btnAddTaxes
            // 
            btnAddTaxes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddTaxes.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddTaxes.Appearance.Options.UseFont = true;
            btnAddTaxes.Location = new Point(711, 12);
            btnAddTaxes.Name = "btnAddTaxes";
            btnAddTaxes.Size = new Size(73, 23);
            btnAddTaxes.TabIndex = 1;
            btnAddTaxes.Text = "Add Taxes";
            btnAddTaxes.Click += btnAddTaxes_Click;
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(12, 16);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(29, 13);
            lblFilter.TabIndex = 4;
            lblFilter.Text = "Filter:";
            // 
            // AllTaxes
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 484);
            Controls.Add(lblFilter);
            Controls.Add(gridControl1);
            Controls.Add(btnAddTaxes);
            Controls.Add(txtFilter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AllTaxes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "All Taxes";
            Load += AllTaxes_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFilter.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtFilter;
        private DevExpress.XtraEditors.SimpleButton btnAddTaxes;
        private DevExpress.XtraEditors.LabelControl lblFilter;
    }
} 