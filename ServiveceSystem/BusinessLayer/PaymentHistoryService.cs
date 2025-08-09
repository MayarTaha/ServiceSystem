using System;
using System.Collections.Generic;
using System.Linq;
using ServiceSystem.Models;
using ServiveceSystem.Models;

namespace ServiveceSystem.BusinessLayer
{
    public class PaymentHistoryService
    {
        private readonly AppDBContext _context;

        public PaymentHistoryService(AppDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the current remainder for an invoice based on payment history
        /// </summary>
        /// <param name="invoiceId">The invoice ID</param>
        /// <returns>Current remainder amount</returns>
        public decimal GetCurrentRemainder(int invoiceId)
        {
            var latestPayment = _context.payments
                .Where(p => p.InvoiceId == invoiceId && !p.isDeleted)
                .OrderByDescending(p => p.PaymentDate)
                .FirstOrDefault();

            if (latestPayment != null)
            {
                return latestPayment.RemainingAmount;
            }

            // No payments made yet, get the invoice total
            var invoice = _context.invoiceHeaders.FirstOrDefault(i => i.InvoiceHeaderId == invoiceId);
            return invoice?.TotalPrice ?? 0;
        }

        /// <summary>
        /// Gets the total amount paid for an invoice based on payment history
        /// </summary>
        /// <param name="invoiceId">The invoice ID</param>
        /// <returns>Total amount paid</returns>
        public decimal GetTotalPaid(int invoiceId)
        {
            return _context.payments
                .Where(p => p.InvoiceId == invoiceId && !p.isDeleted)
                .Sum(p => p.AmountPaid);
        }

        /// <summary>
        /// Gets all payment records for an invoice ordered by date
        /// </summary>
        /// <param name="invoiceId">The invoice ID</param>
        /// <returns>List of payment records</returns>
        public List<Payment> GetPaymentHistory(int invoiceId)
        {
            return _context.payments
                .Where(p => p.InvoiceId == invoiceId && !p.isDeleted)
                .OrderBy(p => p.PaymentDate)
                .ToList();
        }

        /// <summary>
        /// Gets invoices with remaining balance based on payment history
        /// </summary>
        /// <returns>List of invoices with current remainder > 0</returns>
        /// 

        //edit
        //public List<InvoiceHeader> GetInvoicesWithRemainder()
        //{
        //    var invoicesWithRemainder = new List<InvoiceHeader>();
        //    var allInvoices = _context.invoiceHeaders.Where(i => !i.isDeleted).ToList();

        //    foreach (var invoice in allInvoices)
        //    {
        //        var currentRemainder = GetCurrentRemainder(invoice.InvoiceHeaderId);
        //        if (currentRemainder > 0)
        //        {
        //            // Update the reminder field for display purposes
        //            invoice.Reminder = currentRemainder.ToString();
        //            invoicesWithRemainder.Add(invoice);
        //        }
        //    }

        //    return invoicesWithRemainder;
        //}
        public List<InvoiceHeader> GetInvoicesWithRemainder()
        {
            // Get all non-deleted invoices
            var allInvoices = _context.invoiceHeaders
                .Where(i => !i.isDeleted)
                .ToList();

            // Pre-aggregate payments per invoice (only non-deleted payments)
            var paymentsByInvoice = _context.payments
                .Where(p => !p.isDeleted)
                .GroupBy(p => p.InvoiceId)
                .Select(g => new { InvoiceId = g.Key, TotalPaid = g.Sum(x => x.AmountPaid) })
                .ToDictionary(x => x.InvoiceId, x => x.TotalPaid);

            var result = new List<InvoiceHeader>();

            foreach (var invoice in allInvoices)
            {
                // Prefer payment history; if none exists (legacy invoices), fall back to header.Payment
                decimal totalPaidFromPayments = paymentsByInvoice.TryGetValue(invoice.InvoiceHeaderId, out var paid)
                    ? paid
                    : 0m;
                decimal totalPaid = totalPaidFromPayments > 0 ? totalPaidFromPayments : invoice.Payment;

                decimal currentRemainder = invoice.TotalPrice - totalPaid;
                if (currentRemainder > 0)
                {
                    // Populate Reminder for display only
                    invoice.Reminder = currentRemainder.ToString();
                    result.Add(invoice);
                }
            }

            return result;
        }


        /// <summary>
        /// Gets payment summary for a clinic
        /// </summary>
        /// <param name="clinicId">The clinic ID</param>
        /// <returns>Payment summary object</returns>
        public ClinicPaymentSummary GetClinicPaymentSummary(int clinicId)
        {
            var clinicInvoices = _context.invoiceHeaders
                .Where(ih => !ih.isDeleted && ih.QuotationHeader != null && ih.QuotationHeader.ClinicId == clinicId)
                .ToList();

            var totalInvoiced = clinicInvoices.Sum(ih => ih.TotalPrice);
            var totalPaid = clinicInvoices.Sum(ih => GetTotalPaid(ih.InvoiceHeaderId));
            var outstandingBalance = totalInvoiced - totalPaid;

            return new ClinicPaymentSummary
            {
                TotalInvoiced = totalInvoiced,
                TotalPaid = totalPaid,
                OutstandingBalance = outstandingBalance
            };
        }
    }

    /// <summary>
    /// Payment summary for a clinic
    /// </summary>
    public class ClinicPaymentSummary
    {
        public decimal TotalInvoiced { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal OutstandingBalance { get; set; }
    }
    }
 