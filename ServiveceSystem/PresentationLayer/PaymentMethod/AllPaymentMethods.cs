using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.PaymentMethod
{
    public partial class AllPaymentMethods : XtraForm
    {
        private List<ServiveceSystem.Models.PaymentMethod> _methods;
        private RepositoryItemButtonEdit editButton;
        private RepositoryItemButtonEdit deleteButton;

        public AllPaymentMethods()
        {
            InitializeComponent();
            gridView1.RowCellClick += gridView1_RowCellClick;
            _ = LoadDataAsync(); // fire and forget
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var service = new PaymentMethodService(new AppDBContext());
                _methods = await Task.Run(() => service.GetAll());
                BindGrid(_methods);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payment methods: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<ServiveceSystem.Models.PaymentMethod> methods)
        {
            var displayList = methods.Select(m => new { m.PaymentType, m.PaymentMethodId }).ToList();
            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();

            var col = gridView1.Columns["PaymentMethodId"];
            if (col != null) col.Visible = false;

            InitGridButtons();
        }

        private void InitGridButtons()
        {
            if (gridView1.Columns["Edit"] == null)
            {
                editButton = new RepositoryItemButtonEdit
                {
                    TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
                };
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
                deleteButton = new RepositoryItemButtonEdit
                {
                    TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
                };
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

        private async void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            int id = (int)gridView1.GetRowCellValue(e.RowHandle, "PaymentMethodId");
            var service = new PaymentMethodService(new AppDBContext());

            if (e.Column.FieldName == "Edit")
            {
                var editForm = new EditPaymentMethod(id);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadDataAsync();
                }
            }
            else if (e.Column.FieldName == "Delete")
            {
                var method = _methods.FirstOrDefault(m => m.PaymentMethodId == id);
                if (method != null && MessageBox.Show($"Delete payment method '{method.PaymentType}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await Task.Run(() => service.Delete(id));
                    await LoadDataAsync();
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddPaymentMethod();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                await LoadDataAsync();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _methods
                .Where(m => m.PaymentType != null && m.PaymentType.ToLower().Contains(filter))
                .ToList();

            BindGrid(filtered);
        }
    }
}
