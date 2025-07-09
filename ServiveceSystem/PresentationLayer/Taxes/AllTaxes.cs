using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using ServiveceSystem.BusinessLayer;
using ServiceSystem.Models;

namespace ServiveceSystem.PresentationLayer.Taxes
{
    public partial class AllTaxes : Form
    {
        private readonly TaxesService _taxesService;
        private List<Taxes> _taxes;

        public AllTaxes()
        {
            InitializeComponent();
            _taxesService = new TaxesService(new AppDBContext());
            LoadTaxes();
        }

        private void LoadTaxes()
        {
            _taxes = _taxesService.GetAll().Where(t => !t.isDeleted).ToList();
            BindGrid(_taxes);
        }

        private void BindGrid(List<Taxes> taxes)
        {
            var displayList = taxes.Select(t => new
            {
                t.TaxesID, // hidden
                t.Name,
                t.TaxRate
            }).ToList();
            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();
            var col = gridView1.Columns["TaxesID"];
            if (col != null)
                col.Visible = false;
            InitGridButtons();
        }

        private void InitGridButtons()
        {
            if (gridView1.Columns["Edit"] == null)
            {
                var editButton = new RepositoryItemButtonEdit();
                editButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                editButton.Buttons[0].Caption = "Edit";
                editButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
                editButton.Buttons[0].Appearance.ForeColor = System.Drawing.Color.Blue;
                editButton.Click += EditButton_Click;
                gridControl1.RepositoryItems.Add(editButton);

                var editCol = gridView1.Columns.AddField("Edit");
                editCol.Visible = true;
                editCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                editCol.ColumnEdit = editButton;
                editCol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
                editCol.VisibleIndex = 0;
            }

            if (gridView1.Columns["Delete"] == null)
            {
                var deleteButton = new RepositoryItemButtonEdit();
                deleteButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                deleteButton.Buttons[0].Caption = "Delete";
                deleteButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
                deleteButton.Buttons[0].Appearance.ForeColor = System.Drawing.Color.Red;
                deleteButton.Click += DeleteButton_Click;
                gridControl1.RepositoryItems.Add(deleteButton);

                var deleteCol = gridView1.Columns.AddField("Delete");
                deleteCol.Visible = true;
                deleteCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                deleteCol.ColumnEdit = deleteButton;
                deleteCol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
                deleteCol.VisibleIndex = 1;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int taxesId = (int)gridView1.GetRowCellValue(rowHandle, "TaxesID");
            var editForm = new EditTaxes(taxesId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadTaxes();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int taxesId = (int)gridView1.GetRowCellValue(rowHandle, "TaxesID");
            var taxes = _taxes.FirstOrDefault(t => t.TaxesID == taxesId);
            if (taxes != null && MessageBox.Show($"Delete tax '{taxes.Name}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _taxesService.DeleteAsync(taxesId).Wait();
                LoadTaxes();
            }
        }

        private void btnAddTaxes_Click(object sender, EventArgs e)
        {
            var addForm = new AddTaxes();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadTaxes();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _taxes.Where(t => t.Name != null && t.Name.ToLower().Contains(filter)).ToList();
            BindGrid(filtered);
        }
    }
} 