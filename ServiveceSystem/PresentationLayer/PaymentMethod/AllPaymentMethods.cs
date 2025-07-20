using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.PaymentMethod
{
    public partial class AllPaymentMethods : XtraForm
    {
        private readonly PaymentMethodService _service;
        private List<ServiveceSystem.Models.PaymentMethod> _methods;
        public AllPaymentMethods()
        {
            InitializeComponent();
            _service = new PaymentMethodService(new AppDBContext());
            gridView1.RowCellClick += gridView1_RowCellClick;
            LoadData();
        }
        private void LoadData()
        {
            _methods = _service.GetAll();
            BindGrid(_methods);
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
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "Edit")
            {
                int id = (int)gridView1.GetRowCellValue(e.RowHandle, "PaymentMethodId");
                var editForm = new EditPaymentMethod(id);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else if (e.Column.FieldName == "Delete")
            {
                int id = (int)gridView1.GetRowCellValue(e.RowHandle, "PaymentMethodId");
                var method = _methods.FirstOrDefault(m => m.PaymentMethodId == id);
                if (method != null && MessageBox.Show($"Delete payment method '{method.PaymentType}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _service.Delete(id);
                    LoadData();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddPaymentMethod();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _methods.Where(m => m.PaymentType != null && m.PaymentType.ToLower().Contains(filter)).ToList();
            BindGrid(filtered);
        }
    }
} 