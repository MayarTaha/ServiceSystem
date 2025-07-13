using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;
using ServiveceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiveceSystem.BusinessLayer
{
    class InvoiceHeaderService
    {
        private readonly AppDBContext _context;


        public InvoiceHeaderService(AppDBContext context)
        {
            // var invoiceHeaderService = App.ServiceProvider.GetRequiredService<InvoiceHeaderService>();

            _context = context;
        }

        // Get all InvoiceHeaders
        public List<InvoiceHeader> GetAll()
        {
            return _context.invoiceHeaders.ToList();
        }

        // Get InvoiceHeader by ID
        public InvoiceHeader? GetById(int id)
        {
            return _context.invoiceHeaders.Find(id);
        }

        // Add new InvoiceHeader
        public async Task<bool> AddInvoiceHeader(InvoiceHeader invoice)
        {
            var quotationExists = await _context.QuotationHeaders.AnyAsync(q => q.QuotationId == invoice.QuotationId && !q.isDeleted);
            var paymentMethodExists = await _context.PaymentMethods.AnyAsync(pm => pm.PaymentMethodId == invoice.PaymentMethodId);
            //
            if (!quotationExists || !paymentMethodExists)
                return false;
            var exists = await _context.invoiceHeaders
               .AnyAsync(q => q.QuotationId == invoice.QuotationId &&
                              q.PaymentMethodId == invoice.PaymentMethodId &&
                              q.ContactId == invoice.ContactId &&
                              !q.isDeleted);
            MessageBox.Show($"QuotationId Exists: {quotationExists}\nPayment Exists: {paymentMethodExists}\nAlready Exists: {exists}");

            if (!quotationExists || !paymentMethodExists || exists)
                return false;

            //  bool quotationExists = _context.QuotationHeaders.Any(q => q.QuotationId == invoice.QuotationId);
            //if (!quotationExists)
            //    throw new Exception("Quotation not found");


            // bool paymentMethodExists = _context.PaymentMethods.Any(pm => pm.PaymentMethodId == invoice.PaymentMethodId);
            //if (!paymentMethodExists)
            //    throw new Exception("Payment method not found");

            invoice.CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
            invoice.UpdatedLog = DateTime.Now.ToString();

            //_context.invoiceHeaders.Add(invoice);
            //_context.SaveChanges();
            _context.invoiceHeaders.Add(invoice);
            await _context.SaveChangesAsync();
            return true;
        }

        // Update 
        public void Update(InvoiceHeader invoice)
        {
            var existingInvoice = _context.invoiceHeaders.Find(invoice.InvoiceHeaderId);
            if (existingInvoice != null)
            {

                bool quotationExists = _context.QuotationHeaders.Any(q => q.QuotationId == invoice.QuotationId);
                bool paymentMethodExists = _context.PaymentMethods.Any(pm => pm.PaymentMethodId == invoice.PaymentMethodId);


                if (!quotationExists)
                    throw new Exception("Quotation not found");

                if (!paymentMethodExists)
                    throw new Exception("Payment method not found");


                existingInvoice.QuotationId = invoice.QuotationId;
                existingInvoice.InvoiceDate = invoice.InvoiceDate;
                existingInvoice.TotalPrice = invoice.TotalPrice;
                existingInvoice.Payment = invoice.Payment;
                existingInvoice.PaymentMethodId = invoice.PaymentMethodId;
                existingInvoice.Reminder = invoice.Reminder;
                existingInvoice.ContactId = invoice.ContactId;
                existingInvoice.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";


                existingInvoice.UpdatedLog = DateTime.Now.ToString();

                _context.SaveChanges();
            }

        }

        // Delete 
        public async Task DeleteInvoice(int id)
        {
            var invoice = await _context.invoiceHeaders.FindAsync(id);
            if (invoice != null)
            {
                invoice.isDeleted = true;
                invoice.DeletedLog = DateTime.Now.ToString();
                _context.SaveChanges();
            }
        }



    }
}





