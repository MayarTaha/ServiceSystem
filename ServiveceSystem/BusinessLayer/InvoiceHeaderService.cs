using DevExpress.XtraEditors;
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

       

        public async Task<List<InvoiceHeader>> GetAll()
        {
            return await _context.invoiceHeaders.Include(i => i.QuotationHeader)
        .Include(i => i.PaymentMethod)
        .Include(i => i.Contact)
        .Where(i => !i.isDeleted)
        .ToListAsync();
        }

        // Get InvoiceHeader by ID
        public InvoiceHeader? GetById(int id)
        {
            return _context.invoiceHeaders.Find(id);
        }

        
        public async Task<bool> AddInvoiceHeader(InvoiceHeader invoice)
        {
            bool quotationExists = true;

            // Only check quotation if provided
            if (invoice.QuotationId.HasValue)
            {
                quotationExists = await _context.QuotationHeaders
                    .AnyAsync(q => q.QuotationId == invoice.QuotationId && !q.isDeleted);

                if (!quotationExists)
                {
                    XtraMessageBox.Show("The selected quotation does not exist.");
                    return false;
                }
            }

            // Check  contact
            var contactExists = await _context.ContactPersons
                .AnyAsync(c => c.ContactId == invoice.ContactId);

            if (!contactExists)
            {
                XtraMessageBox.Show("The selected contact  does not exist.");
                return false;
            }

            // Check payment method
            var paymentMethodExists = await _context.PaymentMethods
                .AnyAsync(pm => pm.PaymentMethodId == invoice.PaymentMethodId);

            if (!paymentMethodExists)
            {
                XtraMessageBox.Show("The selected payment method does not exist.");
                return false;
            }


            

            // Set logs
            invoice.CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
            invoice.UpdatedLog = DateTime.Now.ToString();

            // Save
            _context.invoiceHeaders.Add(invoice);
            await _context.SaveChangesAsync();
            //XtraMessageBox.Show("Invoice saved successfully!");
            return true;
        }
        //new update
        public async Task<bool> Update(InvoiceHeader invoice)
        {
            // Create a new DbContext instance for this operation
            using (var context = new AppDBContext())
            {
                var existingInvoice = await context.invoiceHeaders.FindAsync(invoice.InvoiceHeaderId);
                if (existingInvoice == null)
                    return false;

                // bool quotationExists = _context.QuotationHeaders.Any(q => q.QuotationId == invoice.QuotationId);
                bool paymentMethodExists = context.PaymentMethods.Any(pm => pm.PaymentMethodId == invoice.PaymentMethodId);
                //if (!quotationExists)
                //return false;
                //throw new Exception("Quotation not found");

                if (!paymentMethodExists)
                    // throw new Exception("Payment method not found");
                    return false;
                //existingInvoice.QuotationId = invoice.QuotationId;
                if (invoice.QuotationId.HasValue)
                    existingInvoice.QuotationId = invoice.QuotationId;
                else
                    existingInvoice.QuotationId = null;
                if (invoice.SalesManId.HasValue)
                    existingInvoice.SalesManId = invoice.SalesManId;
                else
                    existingInvoice.SalesManId = null;
                existingInvoice.InvoiceDate = invoice.InvoiceDate;
                existingInvoice.TotalPrice = invoice.TotalPrice;
                existingInvoice.Payment = invoice.Payment;
                existingInvoice.PaymentMethodId = invoice.PaymentMethodId;
                existingInvoice.Reminder = invoice.Reminder;
                existingInvoice.ContactId = invoice.ContactId;
                existingInvoice.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                // existingInvoice.UpdatedLog = DateTime.Now.ToString();
                await context.SaveChangesAsync();
                return true;
            }
        }
        
       
        // Delete 
        public async Task<bool> Delete(int id)
        {
            var invoice = await _context.invoiceHeaders.FindAsync(id);
            if (invoice != null)
            {
                invoice.isDeleted = true;
                invoice.DeletedLog = DateTime.Now.ToString();
                // _context.SaveChanges();
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }



    }
}





