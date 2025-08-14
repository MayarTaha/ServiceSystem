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
    class InvoiceDetailService
    {
        private readonly AppDBContext _context;

        public InvoiceDetailService(AppDBContext context)
        {
            _context = context;
        }

       


        public async Task<List<InvoiceDetail>> GetAllAsync()

        {
            return await _context.InvoiceDetails.Include(d => d.Service)
        .Include(d => d.QuotationHeader)
            .ThenInclude(q => q.Clinic).ToListAsync();
        }

      




        // Get InvoiceDetail by ID
        public InvoiceDetail? GetById(int id)
        {
            return _context.InvoiceDetails.Find(id);
        }

        

        public async Task<bool> AddInvoiceDetail(InvoiceDetail detail)
        {
            // Create a new DbContext instance for this operation
            using (var context = new AppDBContext())
            {
                bool serviceExists = await context.Services
                    .AnyAsync(s => s.ServiceId == detail.ServiceId && !s.isDeleted);
                if (!serviceExists)
                {
                    
                    XtraMessageBox.Show("The selected service does not exist.");
                    return false;
                }
                if (detail.QuotationId.HasValue)
                {
                    bool quotationExists = await context.QuotationHeaders
                        .AnyAsync(q => q.QuotationId == detail.QuotationId && !q.isDeleted);
                    if (!quotationExists)
                    {
                        // Same recommendation as above for UI interaction.
                        XtraMessageBox.Show("The selected quotation does not exist.");
                        return false;
                    }
                }

                // Assuming CalculateTotalService is a pure function or part of the domain model
                detail.TotalService = CalculateTotalService(detail);

                // Assuming CurrentUser is accessible globally or passed in
                detail.CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                detail.UpdatedLog = DateTime.Now.ToString(); // This seems inconsistent with CreatedLog format
                detail.isDeleted = false;
                context.InvoiceDetails.Add(detail);
                await context.SaveChangesAsync();
            }
            // UI interaction should be handled by the calling layer.
            XtraMessageBox.Show("Invoice saved successfully!");
            return true;
        }




        

        public async Task<bool> Update(InvoiceDetail detail)
        {
            // Create a new DbContext instance for this operation
            using (var context = new AppDBContext())
            {
                var existingDetail = await context.InvoiceDetails.FindAsync(detail.InvoiceDetailId);
                if (existingDetail == null)
                    return false;

                existingDetail.ServiceId = detail.ServiceId;
                existingDetail.QuotationId = detail.QuotationId;
                existingDetail.Quantity = detail.Quantity;
                existingDetail.Discount = detail.Discount;
                existingDetail.DiscountType = detail.DiscountType;
                existingDetail.ServicePrice = detail.ServicePrice;

                // Assuming CalculateTotalService is a pure function or part of the domain model
                existingDetail.TotalService = CalculateTotalService(detail);

                //existingDetail.TotalDuo = detail.TotalDuo; // Commented out in original code

                // Assuming CurrentUser is accessible globally or passed in
                existingDetail.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";

                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> Delete(int id)
        {
            var detail = await _context.InvoiceDetails.FindAsync(id);
            if (detail != null)
            {
                detail.isDeleted = true;
                detail.DeletedLog = System.DateTime.Now.ToString();
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        //// THIS IS THE MISSING FUNCTION
        public async Task<List<InvoiceDetail>> GetDetailsByInvoiceHeaderIdAsync(int invoiceHeaderId)
        {
            return await _context.InvoiceDetails
                                 .Where(d => d.InvoiceHeaderId == invoiceHeaderId && !d.isDeleted)
                                 .Include(d => d.Service)
                                 .Include(d => d.QuotationHeader)
                                 .ToListAsync();
        }


        private decimal CalculateTotalService(InvoiceDetail detail)
        {
            decimal total = detail.ServicePrice * detail.Quantity;

            if (detail.DiscountType == Discount.Percentage)
            {
                total -= total * (detail.Discount / 100m);
            }
            else 
            {
                total -= detail.Discount;
            }

            return total;
        }

    }
}

