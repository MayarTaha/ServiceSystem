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
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;
using ServiveceSystem.PresentationLayer.QuotationHeader;
using DevExpress.XtraEditors.Repository;
using ServiceSystem.PresentationLayer.Quotation;
using Microsoft.EntityFrameworkCore;

namespace ServiceSystem.PresentationLayer.QuotationHeader
{
    public partial class AllQuotations : DevExpress.XtraEditors.XtraForm
    {
        private readonly QuotationHeaderService _quotationHeaderService;
        private List<ServiceSystem.Models.QuotationHeader> _quotations;
        public AllQuotations()
        {
            InitializeComponent();
            _quotationHeaderService = new QuotationHeaderService(new AppDBContext());
            gridView1.RowCellClick += gridView1_RowCellClick;
            LoadQuotations();
        }
        private async void LoadQuotations()
        {
            try
            {
                var _quotationHeaderService = new QuotationHeaderService(new AppDBContext());
                _quotations = await _quotationHeaderService.GetAll();
                BindGrid(_quotations);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading quotations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BindGrid(List<ServiceSystem.Models.QuotationHeader> quotations)
        {
            var displayList = quotations.Select(q => new
            {
                q.QuotationId,
                Name = q.QuotationNaMe,
                q.InitialDate,
                q.ExpireDate,
                ClinicName = q.Clinic != null ? q.Clinic.ClinicName : "",
                ContactName = q.Contact != null ? q.Contact.ContactName : "",
                q.CreatedLog,
                q.UpdatedLog,
                q.DeletedLog
            }).ToList();

            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();

            // Hide unwanted columns
            string[] hiddenColumns = { "QuotationId", "CreatedLog", "UpdatedLog", "DeletedLog" };
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

            if (gridView1.Columns["TransferToInvoice"] == null)
            {
                var transferButton = new RepositoryItemButtonEdit();
                transferButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                transferButton.Buttons[0].Caption = "Transfer";
                transferButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
                transferButton.Buttons[0].Appearance.ForeColor = System.Drawing.Color.Green;
                gridControl1.RepositoryItems.Add(transferButton);

                var transferCol = gridView1.Columns.AddField("TransferToInvoice");
                transferCol.Visible = true;
                transferCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                transferCol.ColumnEdit = transferButton;
                transferCol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
                transferCol.VisibleIndex = 2;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int quotationId = (int)gridView1.GetRowCellValue(rowHandle, "QuotationId");
            var editForm = new EditQuotationForm(quotationId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadQuotations();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int quotationId = (int)gridView1.GetRowCellValue(rowHandle, "QuotationId");
            var quotation = _quotations.FirstOrDefault(q => q.QuotationId == quotationId);
            if (quotation != null && MessageBox.Show($"Delete quotation '{quotation.QuotationNaMe}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await _quotationHeaderService.Delete(quotationId);
                await LoadQuotationsAsync();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _quotations.Where(q => q.Note != null && q.Note.ToLower().Contains(filter)).ToList();
            BindGrid(filtered);
        }

        private async Task LoadQuotationsAsync()
        {
            try
            {
                _quotations = await _quotationHeaderService.GetAll();
                BindGrid(_quotations);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading quotations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (e.Column.FieldName == "TransferToInvoice")
            {
                TransferToInvoiceButton_Click(sender, EventArgs.Empty);
            }
        }

        private async void TransferToInvoiceButton_Click(object sender, EventArgs e)
        {
            //var rowHandle = gridView1.FocusedRowHandle;
            //if (rowHandle < 0) return;
            //int quotationId = (int)gridView1.GetRowCellValue(rowHandle, "QuotationId");
            //var quotation = _quotations.FirstOrDefault(q => q.QuotationId == quotationId);
            //if (quotation == null) return;
            //int clinicId = quotation.ClinicId;
            //int contactId = quotation.ContactId;

            //// Fetch QuotationDetails
            //var context = new AppDBContext();
            //var details = context.QuotationDetails.Where(qd => qd.QuotationId == quotationId && !qd.isDeleted).ToList();
            //// Load Service navigation property for each detail
            //foreach (var d in details)
            //{
            //    d.Service = context.Services.FirstOrDefault(s => s.ServiceId == d.ServiceId);
            //}

            //var transferForm = new ServiceSystem.PresentationLayer.InvoiceDetail.TransferToInvoice(quotationId, clinicId, contactId, details, quotation.QuotationNaMe);
            //transferForm.ShowDialog();

            //================
            //================
            //================

            //var rowHandle = gridView1.FocusedRowHandle;
            //if (rowHandle < 0) return;
            //int quotationId = (int)gridView1.GetRowCellValue(rowHandle, "QuotationId");
            //var quotation = _quotations.FirstOrDefault(q => q.QuotationId == quotationId);
            //if (quotation == null) return;

            //// Fetch QuotationDetails
            //var context = new AppDBContext();
            //var details = context.QuotationDetails.Where(qd => qd.QuotationId == quotationId && !qd.isDeleted).ToList();
            //// Load Service navigation property for each detail
            //foreach (var d in details)
            //{
            //    d.Service = context.Services.FirstOrDefault(s => s.ServiceId == d.ServiceId);
            //}

            //var transferForm = new ServiceSystem.PresentationLayer.InvoiceDetail.TransferToInvoice(quotation, details);
            //transferForm.ShowDialog();
            //================
            //================
            //================

            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int quotationId = (int)gridView1.GetRowCellValue(rowHandle, "QuotationId");

            // Fetch the full QuotationHeader with related entities (Taxes, Clinic, Contact, SalesMan)
            var context = new AppDBContext();
            var quotation = await context.QuotationHeaders
                                        .Include(q => q.Taxes)
                                        .Include(q => q.Clinic)
                                        .Include(q => q.Contact)
                                        .Include(q => q.SalesMan)
                                        .FirstOrDefaultAsync(q => q.QuotationId == quotationId);

            if (quotation == null) return;

            // Fetch QuotationDetails
            var details = context.QuotationDetails.Where(qd => qd.QuotationId == quotationId && !qd.isDeleted).ToList();
            // Load Service navigation property for each detail
            foreach (var d in details)
            {
                d.Service = context.Services.FirstOrDefault(s => s.ServiceId == d.ServiceId);
            }

            var transferForm = new ServiceSystem.PresentationLayer.InvoiceDetail.TransferToInvoice(quotation, details);
            transferForm.ShowDialog();
        }

        private void btnAddQuotation_Click(object sender, EventArgs e)
        {
            var addForm = new AddQuotationForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadQuotationsAsync();
            }
        }

        private void txtFilter_EditValueChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _quotations.Where(q => q.QuotationNaMe != null && q.QuotationNaMe.ToLower().Contains(filter)).ToList();
            BindGrid(filtered);
        }
    }
}











