//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using DevExpress.XtraEditors;
//using DevExpress.XtraEditors.Repository;
//using ServiveceSystem.BusinessLayer;
//using ServiveceSystem.Models;
//using ServiveceSystem.PresentationLayer.InvoiceDetail;
//using ServiveceSystem.PresentationLayer.PaymentMethod;

//namespace ServiceSystem.PresentationLayer.InvoiceDetail
//{
//    public partial class AllInvoices : DevExpress.XtraEditors.XtraForm
//    {
//        private readonly InvoiceHeaderService _invoiceHeaderService;
//        private List<ServiceSystem.Models.InvoiceHeader> _invoices;
//        public AllInvoices()
//        {
//            InitializeComponent();
//            _invoiceHeaderService = new InvoiceHeaderService(new AppDBContext());
//            gridView1.RowCellClick += gridView1_RowCellClick;
//            LoadInvoices();
//        }

//        private async void LoadInvoices()
//        {
//            try
//            {
//                _invoices = await _invoiceHeaderService.GetAllAsync();
//                BindGrid(_invoices);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error loading invoices: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }



//        private void BindGrid(List<ServiceSystem.Models.InvoiceHeader> invoices)
//        {
//            var displayList = invoices.Select(i => new
//            {
//                i.InvoiceHeaderId,
//                Name = i.QuotationHeader != null ? i.QuotationHeader.QuotationNaMe : "", // Show Quotation Note as "Name"
//                i.InvoiceDate,
//                PaymentMethod = i.PaymentMethod != null ? i.PaymentMethod.PaymentType : "", // Show Payment Method Type
//                i.Reminder,
//                ContactName = i.Contact != null ? i.Contact.ContactName : "", // Show Contact Name
//                ShowPaymentButton = decimal.TryParse(i.Reminder, out decimal reminderValue) && reminderValue > 0,
//                i.CreatedLog,
//                i.UpdatedLog,
//                i.DeletedLog
//            }).ToList();

//            gridControl1.DataSource = displayList;
//            gridControl1.ForceInitialize();

//            // Hide unwanted columns
//            string[] hiddenColumns = { "InvoiceHeaderId", "CreatedLog", "UpdatedLog", "DeletedLog", "ShowPaymentButton" };
//            foreach (var colName in hiddenColumns)
//            {
//                var col = gridView1.Columns[colName];
//                if (col != null)
//                    col.Visible = false;
//            }

//            // Set the "Name" column caption
//            var nameCol = gridView1.Columns["Name"];
//            if (nameCol != null)
//                nameCol.Caption = "Name";

//            InitGridButtons();
//            gridView1.RefreshData();
//            gridView1.BestFitColumns();

//            // Force refresh of Payment column to apply conditional visibility
//            if (gridView1.Columns["Payment"] != null)
//            {
//                gridView1.Columns["Payment"].Visible = false;
//                gridView1.Columns["Payment"].Visible = true;
//            }
//        }
//        private void InitGridButtons()
//        {
//            if (gridView1.Columns["Edit"] == null)
//            {
//                var editButton = new RepositoryItemButtonEdit();
//                editButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
//                editButton.Buttons[0].Caption = "Edit";
//                editButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
//                editButton.Buttons[0].Appearance.ForeColor = System.Drawing.Color.Blue;
//                gridControl1.RepositoryItems.Add(editButton);

//                var editCol = gridView1.Columns.AddField("Edit");
//                editCol.Visible = true;
//                editCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
//                editCol.ColumnEdit = editButton;
//                editCol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
//                editCol.VisibleIndex = 0;
//            }

//            if (gridView1.Columns["Delete"] == null)
//            {
//                var deleteButton = new RepositoryItemButtonEdit();
//                deleteButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
//                deleteButton.Buttons[0].Caption = "Delete";
//                deleteButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
//                deleteButton.Buttons[0].Appearance.ForeColor = System.Drawing.Color.Red;
//                gridControl1.RepositoryItems.Add(deleteButton);

//                var deleteCol = gridView1.Columns.AddField("Delete");
//                deleteCol.Visible = true;
//                deleteCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
//                deleteCol.ColumnEdit = deleteButton;
//                deleteCol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
//                deleteCol.VisibleIndex = 1;
//            }

//            if (gridView1.Columns["Payment"] == null)
//            {
//                var paymentButton = new RepositoryItemButtonEdit();
//                paymentButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
//                paymentButton.Buttons[0].Caption = "Payment";
//                paymentButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
//                paymentButton.Buttons[0].Appearance.ForeColor = System.Drawing.Color.Green;
//                gridControl1.RepositoryItems.Add(paymentButton);

//                var paymentCol = gridView1.Columns.AddField("Payment");
//                paymentCol.Visible = true;
//                paymentCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
//                paymentCol.ColumnEdit = null; // Don't set default column edit
//                paymentCol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
//                paymentCol.VisibleIndex = 2;
//            }

//            // Set up conditional visibility for Payment button
//            gridView1.CustomRowCellEdit += GridView1_CustomRowCellEdit;
//        }

//        private void GridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
//        {
//            if (e.Column.FieldName == "Payment")
//            {
//                var rowHandle = e.RowHandle;
//                if (rowHandle >= 0)
//                {
//                    var showPaymentButton = gridView1.GetRowCellValue(rowHandle, "ShowPaymentButton");
//                    if (showPaymentButton != null && (bool)showPaymentButton)
//                    {
//                        e.RepositoryItem = gridControl1.RepositoryItems["Payment"];
//                    }
//                    else
//                    {
//                        e.RepositoryItem = null;
//                    }
//                }
//            }
//        }

//        private async void EditButton_Click(object sender, EventArgs e)
//        {
//            var rowHandle = gridView1.FocusedRowHandle;
//            if (rowHandle < 0) return;
//            int invoiceHeaderId = (int)gridView1.GetRowCellValue(rowHandle, "InvoiceHeaderId");
//            var editForm = new EditInvoiceForm(invoiceHeaderId);
//            if (editForm.ShowDialog() == DialogResult.OK)
//            {
//                await LoadInvoicesAsync();
//            }
//        }

//        private async void DeleteButton_Click(object sender, EventArgs e)
//        {
//            var rowHandle = gridView1.FocusedRowHandle;
//            if (rowHandle < 0) return;
//            int invoiceHeaderId = (int)gridView1.GetRowCellValue(rowHandle, "InvoiceHeaderId");
//            var invoice = _invoices.FirstOrDefault(i => i.InvoiceHeaderId == invoiceHeaderId);
//            string invoiceName = invoice?.QuotationHeader?.QuotationNaMe ?? invoiceHeaderId.ToString();
//            if (invoice != null && MessageBox.Show($"Delete invoice '{invoiceName}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
//            {
//                await _invoiceHeaderService.Delete(invoiceHeaderId);
//                await LoadInvoicesAsync();
//            }
//        }

//        private async void PaymentButton_Click(object sender, EventArgs e)
//        {
//            var rowHandle = gridView1.FocusedRowHandle;
//            if (rowHandle < 0) return;

//            int invoiceHeaderId = (int)gridView1.GetRowCellValue(rowHandle, "InvoiceHeaderId");
//            var invoice = _invoices.FirstOrDefault(i => i.InvoiceHeaderId == invoiceHeaderId);

//            if (invoice != null)
//            {
//                // Navigate to AddPaymentForm instead of InvoicePayment
//                var paymentForm = new AddPaymentForm();
//                if (paymentForm.ShowDialog() == DialogResult.OK)
//                {
//                    await LoadInvoicesAsync();
//                }
//            }
//        }

//        private void txtFilter_TextChanged(object sender, EventArgs e)
//        {
//            string filter = txtFilter.Text.Trim().ToLower();
//            var filtered = _invoices.Where(i => i.InvoiceHeaderId.ToString().Contains(filter)).ToList();
//            BindGrid(filtered);
//        }

//        private async Task LoadInvoicesAsync()
//        {
//            try
//            {
//                _invoices = await _invoiceHeaderService.GetAllAsync();
//                BindGrid(_invoices);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error loading invoices: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
//        {
//            if (e.Column.FieldName == "Edit")
//            {
//                EditButton_Click(sender, EventArgs.Empty);
//            }
//            else if (e.Column.FieldName == "Delete")
//            {
//                DeleteButton_Click(sender, EventArgs.Empty);
//            }
//            else if (e.Column.FieldName == "Payment")
//            {
//                PaymentButton_Click(sender, EventArgs.Empty);
//            }
//        }

//        private  void btnAddInvoice_Click(object sender, EventArgs e)
//        {
//            var addForm = new AddInvoiceForm();
//            if (addForm.ShowDialog() == DialogResult.OK)
//            {
//                 LoadInvoicesAsync();
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;
using ServiveceSystem.PresentationLayer.InvoiceDetail;
using ServiveceSystem.PresentationLayer.PaymentMethod;

namespace ServiceSystem.PresentationLayer.InvoiceDetail
{
    public partial class AllInvoices : DevExpress.XtraEditors.XtraForm
    {
        private readonly InvoiceHeaderService _invoiceHeaderService;
        private List<ServiceSystem.Models.InvoiceHeader> _invoices;
        private bool _isReminderFilterActive = false; // Track if reminder filter is active

        public AllInvoices()
        {
            InitializeComponent();
            _invoiceHeaderService = new InvoiceHeaderService(new AppDBContext());
            gridView1.RowCellClick += gridView1_RowCellClick;

            // Connect the filter event - try both possible event types
            txtFilter.EditValueChanged += txtFilter_TextChanged;
            // txtFilter.TextChanged += txtFilter_TextChanged; // Uncomment if EditValueChanged doesn't work

            LoadInvoices();
        }

        private async void LoadInvoices()
        {
            try
            {
                _invoices = await _invoiceHeaderService.GetAllAsync();
                BindGrid(_invoices);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading invoices: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<ServiceSystem.Models.InvoiceHeader> invoices)
        {
            var displayList = invoices.Select(i => new
            {
                i.InvoiceHeaderId,
                Name = i.QuotationHeader != null ? i.QuotationHeader.QuotationNaMe : "", // Show Quotation Note as "Name"
                i.InvoiceDate,
                PaymentMethod = i.PaymentMethod != null ? i.PaymentMethod.PaymentType : "", // Show Payment Method Type
                i.Reminder,
                ContactName = i.Contact != null ? i.Contact.ContactName : "", // Show Contact Name
                // KEY CHANGE: ShowPaymentButton now depends on filter state AND reminder value
                ShowPaymentButton = _isReminderFilterActive &&
                                  decimal.TryParse(i.Reminder, out decimal reminderValue) &&
                                  reminderValue > 0,
                i.CreatedLog,
                i.UpdatedLog,
                i.DeletedLog
            }).ToList();

            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();

            // Hide unwanted columns
            string[] hiddenColumns = { "InvoiceHeaderId", "CreatedLog", "UpdatedLog", "DeletedLog", "ShowPaymentButton" };
            foreach (var colName in hiddenColumns)
            {
                var col = gridView1.Columns[colName];
                if (col != null)
                    col.Visible = false;
            }

            // Set the "Name" column caption
            var nameCol = gridView1.Columns["Name"];
            if (nameCol != null)
                nameCol.Caption = "Name";

            InitGridButtons();
            gridView1.RefreshData();
            gridView1.BestFitColumns();

            // Force refresh of Payment column to apply conditional visibility
            if (gridView1.Columns["Payment"] != null)
            {
                gridView1.Columns["Payment"].Visible = false;
                gridView1.Columns["Payment"].Visible = true;
            }
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

            if (gridView1.Columns["Payment"] == null)
            {
                var paymentButton = new RepositoryItemButtonEdit();
                paymentButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                paymentButton.Buttons[0].Caption = "Payment";
                paymentButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
                paymentButton.Buttons[0].Appearance.ForeColor = System.Drawing.Color.Green;
                gridControl1.RepositoryItems.Add(paymentButton);

                var paymentCol = gridView1.Columns.AddField("Payment");
                paymentCol.Visible = true;
                paymentCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                paymentCol.ColumnEdit = null; // Don't set default column edit
                paymentCol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
                paymentCol.VisibleIndex = 2;
            }

            // Set up conditional visibility for Payment button
            gridView1.CustomRowCellEdit += GridView1_CustomRowCellEdit;
        }

        private void GridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "Payment")
            {
                var rowHandle = e.RowHandle;
                if (rowHandle >= 0)
                {
                    var showPaymentButton = gridView1.GetRowCellValue(rowHandle, "ShowPaymentButton");
                    if (showPaymentButton != null && (bool)showPaymentButton)
                    {
                        // Find the payment button repository item
                        var paymentRepo = gridControl1.RepositoryItems.Cast<RepositoryItem>()
                            .FirstOrDefault(r => r is RepositoryItemButtonEdit &&
                                          ((RepositoryItemButtonEdit)r).Buttons[0].Caption == "Payment");
                        e.RepositoryItem = paymentRepo;
                    }
                    else
                    {
                        e.RepositoryItem = null;
                    }
                }
            }
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int invoiceHeaderId = (int)gridView1.GetRowCellValue(rowHandle, "InvoiceHeaderId");
            var editForm = new EditInvoiceForm(invoiceHeaderId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await LoadInvoicesAsync();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int invoiceHeaderId = (int)gridView1.GetRowCellValue(rowHandle, "InvoiceHeaderId");
            var invoice = _invoices.FirstOrDefault(i => i.InvoiceHeaderId == invoiceHeaderId);
            string invoiceName = invoice?.QuotationHeader?.QuotationNaMe ?? invoiceHeaderId.ToString();
            if (invoice != null && MessageBox.Show($"Delete invoice '{invoiceName}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await _invoiceHeaderService.Delete(invoiceHeaderId);
                await LoadInvoicesAsync();
            }
        }

        private async void PaymentButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;

            int invoiceHeaderId = (int)gridView1.GetRowCellValue(rowHandle, "InvoiceHeaderId");
            var invoice = _invoices.FirstOrDefault(i => i.InvoiceHeaderId == invoiceHeaderId);

            if (invoice != null)
            {
                // Navigate to AddPaymentForm instead of InvoicePayment
                var paymentForm = new AddPaymentForm();
                if (paymentForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadInvoicesAsync();
                }
            }
        }

        // Enhanced txtFilter_TextChanged method with filter state tracking
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            // Get the sender as TextEdit to ensure we have the right control
            if (!(sender is TextEdit textEdit))
            {
                textEdit = txtFilter;
                if (textEdit == null) return;
            }

            string filter = textEdit.Text.Trim().ToLower();

            if (_invoices == null) return;

            List<ServiceSystem.Models.InvoiceHeader> filtered;

            // Check if user wants to filter by reminders > 0
            if (filter == "reminders" || filter == "reminder" || filter == "payment" || filter == "payments")
            {
                // Set reminder filter as active
                _isReminderFilterActive = true;

                // Filter to show only invoices with reminders > 0
                filtered = _invoices.Where(i =>
                {
                    if (string.IsNullOrEmpty(i.Reminder)) return false;
                    return decimal.TryParse(i.Reminder, out decimal reminderValue) && reminderValue > 0;
                }).ToList();
            }
            else
            {
                // Set reminder filter as inactive
                _isReminderFilterActive = false;

                if (string.IsNullOrEmpty(filter))
                {
                    // Show all invoices when filter is empty
                    filtered = _invoices;
                }
                else
                {
                    // Enhanced text filtering - search in multiple fields
                    filtered = _invoices.Where(i =>
                    {
                        // Search in Invoice ID
                        if (i.InvoiceHeaderId.ToString().ToLower().Contains(filter))
                            return true;

                        // Search in Quotation Name
                        if (i.QuotationHeader?.QuotationNaMe != null &&
                            i.QuotationHeader.QuotationNaMe.ToLower().Contains(filter))
                            return true;

                        // Search in Contact Name
                        if (i.Contact?.ContactName != null &&
                            i.Contact.ContactName.ToLower().Contains(filter))
                            return true;

                        return false;
                    }).ToList();
                }
            }

            BindGrid(filtered);
        }

        private async Task LoadInvoicesAsync()
        {
            try
            {
                _invoices = await _invoiceHeaderService.GetAllAsync();

                // Apply current filter if any
                if (txtFilter != null && !string.IsNullOrEmpty(txtFilter.Text))
                {
                    txtFilter_TextChanged(txtFilter, EventArgs.Empty);
                }
                else
                {
                    // Reset filter state when reloading without filter
                    _isReminderFilterActive = false;
                    BindGrid(_invoices);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading invoices: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "Edit")
            {
                EditButton_Click(sender, EventArgs.Empty);
            }
            else if (e.Column.FieldName == "Delete")
            {
                DeleteButton_Click(sender, EventArgs.Empty);
            }
            else if (e.Column.FieldName == "Payment")
            {
                PaymentButton_Click(sender, EventArgs.Empty);
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            var addForm = new AddInvoiceForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadInvoicesAsync();
            }
        }
    }
}


