using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;
using ServiveceSystem.Models;
using ServiveceSystem.BusinessLayer;

namespace ServiveceSystem.PresentationLayer.Reports
{
    public partial class ClientReportForm : XtraForm
    {
        private AppDBContext _context;
        private PaymentHistoryService _paymentHistoryService;

        public ClientReportForm()
        {
            InitializeComponent();
            _context = new AppDBContext();
            _paymentHistoryService = new PaymentHistoryService(_context);
            LoadClientReport();
        }

        private void LoadClientReport()
        {
            try
            {
                // First, let's get all clinics
                var allClinics = _context.Clinics.Where(c => !c.isDeleted).ToList();
                
                // Get all invoices with their quotations
                var allInvoices = _context.invoiceHeaders
                    .Where(ih => !ih.isDeleted)
                    .Include(ih => ih.QuotationHeader)
                    .ToList();
                
                // Get all payments
                var allPayments = _context.payments
                    .Where(p => !p.isDeleted)
                    .Include(p => p.InvoiceHeader)
                    .ThenInclude(ih => ih.QuotationHeader)
                    .ToList();

                                 // Calculate clinic balances using PaymentHistoryService
                 var clinicBalances = allClinics.Select(clinic => {
                     var summary = _paymentHistoryService.GetClinicPaymentSummary(clinic.ClinicId);
                     return new
                     {
                         ClinicId = clinic.ClinicId,
                         ClinicName = clinic.ClinicName,
                         CompanyName = clinic.CompanyName,
                         Phone = clinic.Phone,
                         Email = clinic.Email,
                         Location = clinic.Location,
                         TotalInvoiced = summary.TotalInvoiced,
                         TotalPaid = summary.TotalPaid,
                         OutstandingBalance = summary.OutstandingBalance
                     };
                 })
                                 .Select(cb => new
                 {
                     cb.ClinicId,
                     cb.ClinicName,
                     cb.CompanyName,
                     cb.Phone,
                     cb.Email,
                     cb.Location,
                     cb.TotalInvoiced,
                     cb.TotalPaid,
                     cb.OutstandingBalance
                 })
                .OrderByDescending(cb => cb.OutstandingBalance)
                .ToList();

                gridControl1.DataSource = clinicBalances;
                gridView1.Columns["ClinicId"].Caption = "Clinic ID";
                gridView1.Columns["ClinicName"].Caption = "Clinic Name";
                gridView1.Columns["CompanyName"].Caption = "Company Name";
                gridView1.Columns["Phone"].Caption = "Phone";
                gridView1.Columns["Email"].Caption = "Email";
                gridView1.Columns["Location"].Caption = "Location";
                gridView1.Columns["TotalInvoiced"].Caption = "Total Invoiced";
                gridView1.Columns["TotalPaid"].Caption = "Total Paid";
                gridView1.Columns["OutstandingBalance"].Caption = "Outstanding Balance";

                // Format currency columns
                gridView1.Columns["TotalInvoiced"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns["TotalInvoiced"].DisplayFormat.FormatString = "C2";
                gridView1.Columns["TotalPaid"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns["TotalPaid"].DisplayFormat.FormatString = "C2";
                gridView1.Columns["OutstandingBalance"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns["OutstandingBalance"].DisplayFormat.FormatString = "C2";

                // Set column widths
                gridView1.Columns["ClinicId"].Width = 80;
                gridView1.Columns["ClinicName"].Width = 150;
                gridView1.Columns["CompanyName"].Width = 150;
                gridView1.Columns["Phone"].Width = 120;
                gridView1.Columns["Email"].Width = 180;
                gridView1.Columns["Location"].Width = 150;
                gridView1.Columns["TotalInvoiced"].Width = 120;
                gridView1.Columns["TotalPaid"].Width = 120;
                gridView1.Columns["OutstandingBalance"].Width = 140;

                // Set outstanding balance column color and make it clickable
                gridView1.Columns["OutstandingBalance"].AppearanceCell.BackColor = Color.LightCoral;
                gridView1.Columns["OutstandingBalance"].AppearanceCell.ForeColor = Color.DarkRed;
                gridView1.Columns["OutstandingBalance"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                
                // Add click event for outstanding balance column
                gridView1.Columns["OutstandingBalance"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["OutstandingBalance"].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                gridView1.Columns["OutstandingBalance"].AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                
                // Make outstanding balance column look clickable
                gridView1.Columns["OutstandingBalance"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["OutstandingBalance"].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                gridView1.Columns["OutstandingBalance"].AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                gridView1.Columns["OutstandingBalance"].AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
                
                // Add click event handler
                gridView1.RowCellClick += GridView1_RowCellClick;
                
                // Set tooltip for outstanding balance column
                gridView1.Columns["OutstandingBalance"].ToolTip = "Click to view invoices with outstanding balance";

                lblTotalOutstanding.Text = $"Total Outstanding: {clinicBalances.Sum(cb => cb.OutstandingBalance):C2}";
                lblTotalClients.Text = $"Total Clients with Outstanding Balance: {clinicBalances.Count}";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading client report: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadClientReport();
        }

        private void btnViewInvoices_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0)
            {
                XtraMessageBox.Show("Please select a clinic first.", "Information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int clinicId = (int)gridView1.GetRowCellValue(rowHandle, "ClinicId");
            string clinicName = gridView1.GetRowCellValue(rowHandle, "ClinicName").ToString();
            decimal outstandingBalance = (decimal)gridView1.GetRowCellValue(rowHandle, "OutstandingBalance");

            // Only open invoices report if there's an outstanding balance
            if (outstandingBalance > 0)
            {
                var invoicesReportForm = new InvoicesReportForm(clinicId, clinicName);
                invoicesReportForm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show($"No outstanding balance for {clinicName}.", "Information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.RestoreDirectory = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    gridView1.ExportToXlsx(saveDialog.FileName);
                    XtraMessageBox.Show("Report exported successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error exporting report: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                gridView1.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error printing report: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            // Check if clicked on Outstanding Balance column
            if (e.Column.FieldName == "OutstandingBalance")
            {
                var rowHandle = e.RowHandle;
                if (rowHandle >= 0)
                {
                    int clinicId = (int)gridView1.GetRowCellValue(rowHandle, "ClinicId");
                    string clinicName = gridView1.GetRowCellValue(rowHandle, "ClinicName").ToString();
                    decimal outstandingBalance = (decimal)gridView1.GetRowCellValue(rowHandle, "OutstandingBalance");

                    // Only open invoices report if there's an outstanding balance
                    if (outstandingBalance > 0)
                    {
                        var invoicesReportForm = new InvoicesReportForm(clinicId, clinicName);
                        invoicesReportForm.ShowDialog();
                    }
                    else
                    {
                        XtraMessageBox.Show($"No outstanding balance for {clinicName}.", "Information", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

    }
} 