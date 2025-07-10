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
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFilter.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.EmbeddedNavigator.Margin = new Padding(4, 3, 4, 3);
            gridControl1.Location = new Point(14, 52);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(4, 3, 4, 3);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(884, 462);
            gridControl1.TabIndex = 2;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 404;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(14, 14);
            txtFilter.Margin = new Padding(4, 3, 4, 3);
            txtFilter.Name = "txtFilter";
            txtFilter.Properties.NullValuePrompt = "Filter by name...";
            txtFilter.Size = new Size(233, 20);
            txtFilter.TabIndex = 0;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // btnAddTaxes
            // 
            btnAddTaxes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddTaxes.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAddTaxes.Appearance.Options.UseFont = true;
            btnAddTaxes.Location = new Point(782, 12);
            btnAddTaxes.Margin = new Padding(4, 3, 4, 3);
            btnAddTaxes.Name = "btnAddTaxes";
            btnAddTaxes.Size = new Size(117, 29);
            btnAddTaxes.TabIndex = 1;
            btnAddTaxes.Text = "Add Taxes";
            btnAddTaxes.Click += btnAddTaxes_Click;
            // 
            // AllTaxes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 532);
            Controls.Add(gridControl1);
            Controls.Add(btnAddTaxes);
            Controls.Add(txtFilter);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AllTaxes";
            Text = "All Taxes";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFilter.Properties).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtFilter;
        private DevExpress.XtraEditors.SimpleButton btnAddTaxes;
    }
} 