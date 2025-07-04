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
        public void AddInvoiceHeader(InvoiceHeader invoice)
        {
            
            bool quotationExists = _context.QuotationHeaders.Any(q => q.QuotationId == invoice.QuotationId);
            if (!quotationExists)
                throw new Exception("Quotation not found");

          
            bool paymentMethodExists = _context.PaymentMethods.Any(pm => pm.PaymentMethodId == invoice.PaymentMethodId);
            if (!paymentMethodExists)
                throw new Exception("Payment method not found");

            invoice.UpdatedLog = DateTime.Now.ToString();

            _context.invoiceHeaders.Add(invoice);
            _context.SaveChanges();
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

               
                existingInvoice.UpdatedLog = DateTime.Now.ToString();

                _context.SaveChanges();
            }
          
        }

        // Delete 
        public void Delete(int id)
        {
            var invoice = _context.invoiceHeaders.Find(id);
            if (invoice != null)
            {
                _context.invoiceHeaders.Remove(invoice);
                _context.SaveChanges();
            }
        }

    }
}
