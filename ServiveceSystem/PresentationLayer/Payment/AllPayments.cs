using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models; // For AppDBContext
using ServiceSystem.Models;
using ServiveceSystem.PresentationLayer.PaymentMethod; // For Payment

namespace ServiveceSystem.PresentationLayer.Payment
{
    public partial class AllPayments : DevExpress.XtraEditors.XtraForm
    {
        private readonly PaymentService _paymentService;
        private List<ServiceSystem.Models.Payment> _payments;

        public AllPayments()
        {
            InitializeComponent();
            _paymentService = new PaymentService(new AppDBContext());
            LoadPayments();
        }

        private async void LoadPayments()
        {
            try
            {
                _payments = await _paymentService.GetAll();
                BindGrid(_payments);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<ServiceSystem.Models.Payment> payments)
        {
            var displayList = payments.Select(p => new
            {
                p.PaymentId, // hidden
                p.InvoiceId,
                p.AmountPaid,
                p.RemainingAmount,
                p.PaymentDate,
                p.PaymentMethodId,
                p.PaymentStatus
            }).ToList();
            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();
            var col = gridView1.Columns["PaymentId"];
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

        private async void EditButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int paymentId = (int)gridView1.GetRowCellValue(rowHandle, "PaymentId");
            // If EditPaymentForm does not have a constructor with paymentId, use the parameterless one
            var editForm = new EditPaymentForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await LoadPaymentsAsync();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int paymentId = (int)gridView1.GetRowCellValue(rowHandle, "PaymentId");
            var payment = _payments.FirstOrDefault(p => p.PaymentId == paymentId);
            if (payment != null && MessageBox.Show($"Delete payment for Invoice {payment.InvoiceId}?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await _paymentService.DeleteAsync(paymentId);
                await LoadPaymentsAsync();
            }
        }

        private async void btnAddPayment_Click(object sender, EventArgs e)
        {
            var addForm = new AddPaymentForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                await LoadPaymentsAsync();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _payments.Where(p => p.PaymentStatus != null && p.PaymentStatus.ToString().ToLower().Contains(filter)).ToList();
            BindGrid(filtered);
        }

        private async Task LoadPaymentsAsync()
        {
            try
            {
                _payments = await _paymentService.GetAll();
                BindGrid(_payments);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 