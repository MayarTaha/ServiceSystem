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

namespace ServiceSystem.PresentationLayer.InvoiceDetail
{
    public partial class AllInvoices : DevExpress.XtraEditors.XtraForm
    {
        private readonly InvoiceHeaderService _invoiceHeaderService;
        private List<ServiceSystem.Models.InvoiceHeader> _invoices;
        public AllInvoices()
        {
            InitializeComponent();
            _invoiceHeaderService = new InvoiceHeaderService(new AppDBContext());
            gridView1.RowCellClick += gridView1_RowCellClick;
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

        //private void BindGrid(List<ServiceSystem.Models.InvoiceHeader> invoices)
        //{
        //    var displayList = invoices.Select(i => new
        //    {
        //        i.InvoiceHeaderId, // hidden
        //        i.QuotationId,
        //        i.InvoiceDate,
        //        i.PaymentMethodId,
        //        i.Reminder,
        //        i.ContactId,
        //        i.CreatedLog,
        //        i.UpdatedLog
        //    }).ToList();
        //    gridControl1.DataSource = displayList;
        //    gridControl1.ForceInitialize();
        //    var col = gridView1.Columns["InvoiceHeaderId"];
        //    if (col != null)
        //        col.Visible = false;
        //    InitGridButtons();
        //}

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
                i.CreatedLog,
                i.UpdatedLog,
                i.DeletedLog
            }).ToList();

            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();

            // Hide unwanted columns
            string[] hiddenColumns = { "InvoiceHeaderId", "CreatedLog", "UpdatedLog", "DeletedLog" };
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

        //private async void btnAddInvoice_Click(object sender, EventArgs e)
        //{
        //    var addForm = new AddInvoiceForm();
        //    if (addForm.ShowDialog() == DialogResult.OK)
        //    {
        //        await LoadInvoicesAsync();
        //    }
        //}

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _invoices.Where(i => i.InvoiceHeaderId.ToString().Contains(filter)).ToList();
            BindGrid(filtered);
        }

        private async Task LoadInvoicesAsync()
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
        }

        private  void btnAddInvoice_Click(object sender, EventArgs e)
        {
            var addForm = new AddInvoiceForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                 LoadInvoicesAsync();
            }
        }
    }
}









//namespace ServiveceSystem.PresentationLayer.InvoiceDetail
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
//                _invoices = await _invoiceHeaderService.GetAll();
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
//                i.InvoiceHeaderId, // hidden
//                i.QuotationId,
//                i.InvoiceDate,
//                i.PaymentMethodId,
//                i.Reminder,
//                i.ContactId,
//                i.CreatedLog,
//                i.UpdatedLog
//            }).ToList();
//            gridControl1.DataSource = displayList;
//            gridControl1.ForceInitialize();
//            var col = gridView1.Columns["InvoiceHeaderId"];
//            if (col != null)
//                col.Visible = false;
//            InitGridButtons();
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
//        }

//        private async void EditButton_Click(object sender, EventArgs e)
//        {
//            var rowHandle = gridView1.FocusedRowHandle;
//            if (rowHandle < 0) return;
//            int invoiceHeaderId = (int)gridView1.GetRowCellValue(rowHandle, "InvoiceHeaderId");
//            // TODO: Implement EditInvoiceForm and show it here
//            // var editForm = new EditInvoiceForm(invoiceHeaderId);
//            // if (editForm.ShowDialog() == DialogResult.OK)
//            // {
//            //     await LoadInvoicesAsync();
//            // }
//        }

//        private async void DeleteButton_Click(object sender, EventArgs e)
//        {
//            var rowHandle = gridView1.FocusedRowHandle;
//            if (rowHandle < 0) return;
//            int invoiceHeaderId = (int)gridView1.GetRowCellValue(rowHandle, "InvoiceHeaderId");
//            var invoice = _invoices.FirstOrDefault(i => i.InvoiceHeaderId == invoiceHeaderId);
//            if (invoice != null && MessageBox.Show($"Delete invoice '{invoice.InvoiceHeaderId}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
//            {
//                await _invoiceHeaderService.DeleteAsync(invoiceHeaderId);
//                await LoadInvoicesAsync();
//            }
//        }

//        private async void btnAddInvoice_Click(object sender, EventArgs e)
//        {
//            var addForm = new AddInvoiceForm();
//            if (addForm.ShowDialog() == DialogResult.OK)
//            {
//                await LoadInvoicesAsync();
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
//                _invoices = await _invoiceHeaderService.GetAll();
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
//        }
//    }
//}