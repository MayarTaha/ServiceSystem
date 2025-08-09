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

        // Getall InvoiceDetails
        //public List<InvoiceDetail> GetAll()
        //{
        //    return _context.InvoiceDetails.ToList();
        //}


        public async Task<List<InvoiceDetail>> GetAllAsync()

        {
            return await _context.InvoiceDetails.Include(d => d.Service)
        .Include(d => d.QuotationHeader)
            .ThenInclude(q => q.Clinic).ToListAsync();
        }

        //




        // Get InvoiceDetail by ID
        public InvoiceDetail? GetById(int id)
        {
            return _context.InvoiceDetails.Find(id);
        }

        // Add new InvoiceDetail
        public async Task<bool> AddInvoiceDetail(InvoiceDetail detail)
        {
            var quotationExists = await _context.QuotationHeaders
              .AnyAsync(q => q.QuotationId == detail.QuotationId && !q.isDeleted);

            if (!quotationExists)
                  return false;
              

            detail.TotalService = CalculateTotalService(detail);
            detail.CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
            detail.UpdatedLog = DateTime.Now.ToString();
            detail.isDeleted = false;
            _context.InvoiceDetails.Add(detail);
            await _context.SaveChangesAsync();
            return true;
        }



        // Update 
        public async Task<bool> Update(InvoiceDetail detail)
        {
            var existingDetail = await _context.InvoiceDetails.FindAsync(detail.InvoiceDetailId);
            if (existingDetail != null)
                return false;


            existingDetail.ServiceId = detail.ServiceId;
                existingDetail.QuotationId = detail.QuotationId;
                existingDetail.Quantity = detail.Quantity;
                existingDetail.Discount = detail.Discount;
                existingDetail.DiscountType = detail.DiscountType;
                existingDetail.ServicePrice = detail.ServicePrice;

                
                existingDetail.TotalService = CalculateTotalService(detail);
                //existingDetail.TotalDuo = detail.TotalDuo;
                existingDetail.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";

                await _context.SaveChangesAsync();
                return true;
            
            
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

