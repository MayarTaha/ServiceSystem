using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using ServiveceSystem.BusinessLayer;
using ServiceSystem.Models;
using ServiveceSystem.Models;

namespace ServiceSystem.PresentationLayer.SalesMam
{
    public partial class AllSalesMan : DevExpress.XtraEditors.XtraForm
    {
        private List<SalesMan> _salesMen;

        public AllSalesMan()
        {
            InitializeComponent();
            gridView1.RowCellClick += gridView1_RowCellClick;
            txtFilter.Enter += (s, e) => { if (string.Equals(txtFilter.Text, string.Empty, StringComparison.Ordinal)) txtFilter.Properties.NullValuePromptShowForEmptyValue = false; };
            txtFilter.Click += (s, e) => { if (string.Equals(txtFilter.Text, string.Empty, StringComparison.Ordinal)) txtFilter.Properties.NullValuePromptShowForEmptyValue = false; };
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                var service = new SalesManService(new AppDBContext());
                _salesMen = await service.GetAll();
                BindGrid(_salesMen);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading salesmen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<SalesMan> salesMen)
        {
            var displayList = salesMen.Select(s => new
            {
                s.SalesManId,
                s.SalesManName
            }).ToList();

            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();

            var idCol = gridView1.Columns["SalesManId"]; if (idCol != null) idCol.Visible = false;
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
                gridControl1.RepositoryItems.Add(deleteButton);

                var deleteCol = gridView1.Columns.AddField("Delete");
                deleteCol.Visible = true;
                deleteCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                deleteCol.ColumnEdit = deleteButton;
                deleteCol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
                deleteCol.VisibleIndex = 1;
            }
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "SalesManId"));
            var editForm = new EditSalesMan(id);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await LoadDataAsync();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "SalesManId"));
            var salesMan = _salesMen.FirstOrDefault(s => s.SalesManId == id);
            if (salesMan != null && MessageBox.Show($"Delete salesman '{salesMan.SalesManName}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var service = new SalesManService(new AppDBContext());
                await service.DeleteAsync(id);
                await LoadDataAsync();
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddSalesMan();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                await LoadDataAsync();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _salesMen.Where(s => s.SalesManName != null && s.SalesManName.ToLower().Contains(filter)).ToList();
            BindGrid(filtered);
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var service = new SalesManService(new AppDBContext());
                _salesMen = await service.GetAll();
                BindGrid(_salesMen);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading salesmen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "Edit")
            {
                EditButton_Click(sender, EventArgs.Empty);
            }
            else if (e.Column.FieldName == "Delete")
            {
                DeleteButton_Click(sender, EventArgs.Empty);
            }
        }

        private void txtFilter_EditValueChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _salesMen.Where(s => s.SalesManName != null && s.SalesManName.ToLower().Contains(filter)).ToList();
            BindGrid(filtered);
        }
    }
}