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
            detail.UpdatedLog = DateTime.Now.ToString();
            detail.isDeleted = false;
            _context.InvoiceDetails.Add(detail);
            await _context.SaveChangesAsync();
            return true;
        }


        //public async Task<bool> AddQuotationDetails(QuotationDetail qout, string? username = "null")
        //{
        //    username ??= CurrentUser.Username ?? "system";
        //    var quotationExists = await _context.QuotationHeaders
        //        .AnyAsync(q => q.QuotationId == qout.QuotationId && !q.isDeleted);

        //    if (!quotationExists)
        //        return false;

        //    // حساب TotalService
        //    qout.TotalService = (qout.ServicePrice * qout.Quantity) - qout.Discount;
        //    qout.CreatedLog = $"{username} - {DateTime.Now}";
        //    qout.isDeleted = false;

        //    _context.QuotationDetails.Add(qout);
        //    await _context.SaveChangesAsync();
        //    return true;
        //}

        // Update 
        public void Update(InvoiceDetail detail)
        {
            var existingDetail = _context.InvoiceDetails.Find(detail.InvoiceDetailId);
            if (existingDetail != null)
            {
               
                existingDetail.ServiceId = detail.ServiceId;
                existingDetail.QuotationId = detail.QuotationId;
                existingDetail.Quantity = detail.Quantity;
                existingDetail.Discount = detail.Discount;
                existingDetail.DiscountType = detail.DiscountType;
                existingDetail.ServicePrice = detail.ServicePrice;

                
                existingDetail.TotalService = CalculateTotalService(detail);
                existingDetail.TotalDuo = detail.TotalDuo;

                existingDetail.UpdatedLog = DateTime.Now.ToString();

                _context.SaveChanges();
            }
            
        }

        // Delete
        public void Delete(int id)
        {
            var detail = _context.InvoiceDetails.Find(id);
            if (detail != null)
            {
                _context.InvoiceDetails.Remove(detail);
                _context.SaveChanges();
            }
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
