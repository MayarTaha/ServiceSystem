using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;
using ServiveceSystem.Models;

namespace ServiveceSystem.BusinessLayer
{
    public class QuotationDetailService
    {
        private readonly AppDBContext _context;

        public QuotationDetailService( AppDBContext context)
        {
           _context = context;
        }

        public async Task<List<QuotationDetail>> GetAll()
        {
            return await _context.QuotationDetails
                .Where(q => !q.isDeleted)
                .Include(q => q.QuotationHeader)
                .ToListAsync();
        }

        public async Task<QuotationDetail> GetById(int id)
        {
            return await _context.QuotationDetails
                .Include(q => q.QuotationHeader)
                .FirstOrDefaultAsync(q => q.QuotationDetailId == id);
        }

        public async Task<bool> AddQuotationDetails(QuotationDetail qout, string? username = "null")
        {
            username ??= CurrentUser.Username ?? "system";
            var quotationExists = await _context.QuotationHeaders
                .AnyAsync(q => q.QuotationId == qout.QuotationId && !q.isDeleted);

            if (!quotationExists)
                return false;

            // حساب TotalService
            qout.TotalService = (qout.ServicePrice * qout.Quantity) - qout.Discount;
            qout.CreatedLog = $"{username} - {DateTime.Now}";
            qout.isDeleted = false;

            _context.QuotationDetails.Add(qout);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateQuotationDetails(QuotationDetail qout, string? username = "null")
        {
            username ??= CurrentUser.Username ?? "system";

            var exists = await _context.QuotationDetails
                .AnyAsync(q => q.QuotationDetailId != qout.QuotationDetailId &&
                               q.QuotationId == qout.QuotationId &&
                               !q.isDeleted);

            if (!exists)
                return false;

            qout.TotalService = (qout.ServicePrice * qout.Quantity) - qout.Discount;
            qout.UpdatedLog = $"{username} - {DateTime.Now}";

            _context.QuotationDetails.Update(qout);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task Delete(int id, string? username = "null")
        {
            username ??= CurrentUser.Username ?? "system";

            var qout = await _context.QuotationDetails.FindAsync(id);
            if (qout != null && !qout.isDeleted)
            {
                qout.DeletedLog = $"{username} - {DateTime.Now}";
                qout.isDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}
