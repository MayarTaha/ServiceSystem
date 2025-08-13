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

        // Get all InvoiceHeaders
        //public List<InvoiceHeader> GetAll()
        //{
        //    return _context.invoiceHeaders.ToList();
        //}

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

        // Add new InvoiceHeader
        //public async Task<bool> AddInvoiceHeader(InvoiceHeader invoice)
        //{
        //    var quotationExists = await _context.QuotationHeaders.AnyAsync(q => q.QuotationId == invoice.QuotationId && !q.isDeleted);
        //    var paymentMethodExists = await _context.PaymentMethods.AnyAsync(pm => pm.PaymentMethodId == invoice.PaymentMethodId);
        //    //
        //    if (!quotationExists || !paymentMethodExists)
        //        return false;
        //    var exists = await _context.invoiceHeaders
        //       .AnyAsync(q => q.QuotationId == invoice.QuotationId &&
        //                      q.PaymentMethodId == invoice.PaymentMethodId &&
        //                      q.ContactId == invoice.ContactId &&
        //                      !q.isDeleted);
        //    DevExpress.XtraEditors.XtraMessageBox.Show($"QuotationId Exists: {quotationExists}\nPayment Exists: {paymentMethodExists}\nAlready Exists: {exists}");

        //    if (!quotationExists || !paymentMethodExists || exists)
        //        return false;



        //    invoice.CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
        //    invoice.UpdatedLog = DateTime.Now.ToString();

        //    _context.invoiceHeaders.Add(invoice);
        //    await _context.SaveChangesAsync();
        //    return true;
        //}
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


            // Prevent duplicates only if quotation exists
            //var exists = await _context.invoiceHeaders
            //    .AnyAsync(q =>
            //        q.QuotationId == invoice.QuotationId &&
            //        q.PaymentMethodId == invoice.PaymentMethodId &&
            //        q.ContactId == invoice.ContactId &&
            //        !q.isDeleted);

            //if (exists)
            //{
            //    XtraMessageBox.Show("An invoice with the same details already exists.");
            //    return false;
            //}




            //Prevent duplicates only if quotation exists
           //var exists = await _context.invoiceHeaders
           //    .AnyAsync(q =>
           //        q.Payment == invoice.Payment &&
           //        !q.isDeleted);

           // if (exists)
           // {
           //     XtraMessageBox.Show("must wirte payemnt .");
           //     return false;
           // }

            // Set logs
            invoice.CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
            invoice.UpdatedLog = DateTime.Now.ToString();

            // Save
            _context.invoiceHeaders.Add(invoice);
            await _context.SaveChangesAsync();
            //XtraMessageBox.Show("Invoice saved successfully!");
            return true;
        }

        // Update 
        public async Task<bool> Update(InvoiceHeader invoice)
        {
            var existingInvoice = await _context.invoiceHeaders.FindAsync(invoice.InvoiceHeaderId);
            if (existingInvoice != null)
                return false;

                bool quotationExists = _context.QuotationHeaders.Any(q => q.QuotationId == invoice.QuotationId);
                bool paymentMethodExists = _context.PaymentMethods.Any(pm => pm.PaymentMethodId == invoice.PaymentMethodId);


                if (!quotationExists)
                return false;
            //throw new Exception("Quotation not found");

            if (!paymentMethodExists)
                // throw new Exception("Payment method not found");
                return false;


            existingInvoice.QuotationId = invoice.QuotationId;
                existingInvoice.InvoiceDate = invoice.InvoiceDate;
                existingInvoice.TotalPrice = invoice.TotalPrice;
                existingInvoice.Payment = invoice.Payment;
                existingInvoice.PaymentMethodId = invoice.PaymentMethodId;
                existingInvoice.Reminder = invoice.Reminder;
                existingInvoice.ContactId = invoice.ContactId;
                existingInvoice.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";


                existingInvoice.UpdatedLog = DateTime.Now.ToString();

            await _context.SaveChangesAsync();
            return true;


        }


        //public async Task<bool> UpdateQuotationHeader(QuotationHeader qout, string? username = "null")
        //{
        //    username ??= CurrentUser.Username ?? "system";

        //    var contactExists = await _context.ContactPersons.AnyAsync(cp => cp.ContactId == qout.ContactId);
        //    if (!contactExists)
        //        return false;
        //    var exists = await _context.QuotationHeaders
        //        .AnyAsync(q => q.QuotationId != qout.QuotationId &&
        //                       q.ClinicId == qout.ClinicId &&
        //                       q.InitialDate == qout.InitialDate &&
        //        !q.isDeleted);
        //    if (exists)
        //        return false;

        //    var tracked = await _context.QuotationHeaders.FirstOrDefaultAsync(q => q.QuotationId == qout.QuotationId);
        //    if (tracked == null)
        //        return false;

        //    // Update properties
        //    tracked.ClinicId = qout.ClinicId;
        //    tracked.InitialDate = qout.InitialDate;
        //    tracked.ExpireDate = qout.ExpireDate;
        //    tracked.Note = qout.Note;
        //    tracked.QuotationNaMe = qout.QuotationNaMe;
        //    tracked.Status = qout.Status;
        //    tracked.priority = qout.priority;
        //    tracked.DiscountType = qout.DiscountType;
        //    tracked.Discount = qout.Discount;
        //    tracked.TotalDuo = qout.TotalDuo;
        //    tracked.ContactId = qout.ContactId;
        //    tracked.UpdatedLog = $"{username} - {DateTime.Now}";
        //    // ... any other fields

        //    await _context.SaveChangesAsync();
        //    return true;
        //}
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





