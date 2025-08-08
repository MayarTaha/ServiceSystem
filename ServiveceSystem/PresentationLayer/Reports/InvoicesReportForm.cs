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
    public partial class InvoicesReportForm : XtraForm
    {
        private AppDBContext _context;
        private PaymentHistoryService _paymentHistoryService;
        private int _clinicId;
        private string _clinicName;

        public InvoicesReportForm(int clinicId, string clinicName)
        {
            InitializeComponent();
            _context = new AppDBContext();
            _paymentHistoryService = new PaymentHistoryService(_context);
            _clinicId = clinicId;
            _clinicName = clinicName;
            LoadInvoicesReport();
        }

        private void LoadInvoicesReport()
        {
            try
            {
                // Get all invoices for this clinic that have outstanding balances
                var clinicInvoices = _context.invoiceHeaders
                    .Where(ih => !ih.isDeleted && 
                                ih.QuotationHeader != null && 
                                ih.QuotationHeader.ClinicId == _clinicId)
                    .Include(ih => ih.QuotationHeader)
                    .Include(ih => ih.Contact)
                    .Include(ih => ih.PaymentMethod)
                    .ToList();

                // Calculate current remainder for each invoice
                var invoicesWithRemainder = clinicInvoices.Select(invoice => {
                    var currentRemainder = _paymentHistoryService.GetCurrentRemainder(invoice.InvoiceHeaderId);
                    var totalPaid = _paymentHistoryService.GetTotalPaid(invoice.InvoiceHeaderId);
                    
                    return new
                    {
                        InvoiceId = invoice.InvoiceHeaderId,
                        InvoiceDate = invoice.InvoiceDate,
                        QuotationNote = invoice.QuotationHeader?.Note ?? "",
                        ContactName = invoice.Contact?.ContactName ?? "",
                        PaymentMethod = invoice.PaymentMethod?.PaymentType ?? "",
                        TotalPrice = invoice.TotalPrice,
                        TotalPaid = totalPaid,
                        CurrentRemainder = currentRemainder,
                        CreatedLog = invoice.CreatedLog,
                        UpdatedLog = invoice.UpdatedLog
                    };
                })
                .Where(inv => inv.CurrentRemainder > 0) // Only show invoices with outstanding balance
                .OrderByDescending(inv => inv.CurrentRemainder)
                .ToList();

                gridControl1.DataSource = invoicesWithRemainder;
                
                // Set column captions
                gridView1.Columns["InvoiceId"].Caption = "Invoice ID";
                gridView1.Columns["InvoiceDate"].Caption = "Invoice Date";
                gridView1.Columns["QuotationNote"].Caption = "Quotation Note";
                gridView1.Columns["ContactName"].Caption = "Contact Name";
                gridView1.Columns["PaymentMethod"].Caption = "Payment Method";
                gridView1.Columns["TotalPrice"].Caption = "Total Price";
                gridView1.Columns["TotalPaid"].Caption = "Total Paid";
                gridView1.Columns["CurrentRemainder"].Caption = "Outstanding Balance";

                // Format currency columns
                gridView1.Columns["TotalPrice"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns["TotalPrice"].DisplayFormat.FormatString = "C2";
                gridView1.Columns["TotalPaid"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns["TotalPaid"].DisplayFormat.FormatString = "C2";
                gridView1.Columns["CurrentRemainder"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns["CurrentRemainder"].DisplayFormat.FormatString = "C2";

                // Set column widths
                gridView1.Columns["InvoiceId"].Width = 80;
                gridView1.Columns["InvoiceDate"].Width = 120;
                gridView1.Columns["QuotationNote"].Width = 200;
                gridView1.Columns["ContactName"].Width = 150;
                gridView1.Columns["PaymentMethod"].Width = 120;
                gridView1.Columns["TotalPrice"].Width = 120;
                gridView1.Columns["TotalPaid"].Width = 120;
                gridView1.Columns["CurrentRemainder"].Width = 140;

                // Set outstanding balance column color
                gridView1.Columns["CurrentRemainder"].AppearanceCell.BackColor = Color.LightCoral;
                gridView1.Columns["CurrentRemainder"].AppearanceCell.ForeColor = Color.DarkRed;

                // Hide unwanted columns
                string[] hiddenColumns = { "CreatedLog", "UpdatedLog" };
                foreach (var colName in hiddenColumns)
                {
                    var col = gridView1.Columns[colName];
                    if (col != null)
                        col.Visible = false;
                }

                // Set form title
                this.Text = $"Invoices Report - {_clinicName}";

                // Update summary labels
                lblTotalOutstanding.Text = $"Total Outstanding: {invoicesWithRemainder.Sum(inv => inv.CurrentRemainder):C2}";
                lblTotalInvoices.Text = $"Total Invoices with Outstanding Balance: {invoicesWithRemainder.Count}";
                lblClinicName.Text = $"Clinic: {_clinicName}";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading invoices report: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInvoicesReport();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.RestoreDirectory = true;
                saveDialog.FileName = $"Invoices_Report_{_clinicName.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd}";

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

        private void btnViewInvoiceDetails_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;

            int invoiceId = (int)gridView1.GetRowCellValue(rowHandle, "InvoiceId");
            ShowInvoiceDetails(invoiceId);
        }

        private void ShowInvoiceDetails(int invoiceId)
        {
            try
            {
                // Get invoice details
                var invoice = _context.invoiceHeaders
                    .Where(ih => ih.InvoiceHeaderId == invoiceId)
                    .Include(ih => ih.QuotationHeader)
                    .Include(ih => ih.Contact)
                    .Include(ih => ih.PaymentMethod)
                    .FirstOrDefault();

                if (invoice == null)
                {
                    XtraMessageBox.Show("Invoice not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get payment history
                var paymentHistory = _paymentHistoryService.GetPaymentHistory(invoiceId);
                var currentRemainder = _paymentHistoryService.GetCurrentRemainder(invoiceId);
                var totalPaid = _paymentHistoryService.GetTotalPaid(invoiceId);

                // Create detailed message
                var details = new StringBuilder();
                details.AppendLine($"Invoice ID: {invoice.InvoiceHeaderId}");
                details.AppendLine($"Invoice Date: {invoice.InvoiceDate:dd/MM/yyyy}");
                details.AppendLine($"Quotation Note: {invoice.QuotationHeader?.Note ?? "N/A"}");
                details.AppendLine($"Contact: {invoice.Contact?.ContactName ?? "N/A"}");
                details.AppendLine($"Payment Method: {invoice.PaymentMethod?.PaymentType ?? "N/A"}");
                details.AppendLine($"Total Price: {invoice.TotalPrice:C2}");
                details.AppendLine($"Total Paid: {totalPaid:C2}");
                details.AppendLine($"Current Outstanding: {currentRemainder:C2}");
                details.AppendLine();
                details.AppendLine("Payment History:");
                details.AppendLine("================");

                if (paymentHistory.Any())
                {
                    foreach (var payment in paymentHistory)
                    {
                        details.AppendLine($"Date: {payment.PaymentDate:dd/MM/yyyy HH:mm}");
                        details.AppendLine($"Amount Paid: {payment.AmountPaid:C2}");
                        details.AppendLine($"Remaining After Payment: {payment.RemainingAmount:C2}");
                        details.AppendLine($"Status: {payment.PaymentStatus}");
                        details.AppendLine("---");
                    }
                }
                else
                {
                    details.AppendLine("No payments recorded yet.");
                }

                XtraMessageBox.Show(details.ToString(), $"Invoice Details - {invoice.InvoiceHeaderId}", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error showing invoice details: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnViewInvoiceDetails_Click(sender, e);
        }
    }
} 