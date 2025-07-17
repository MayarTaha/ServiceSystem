using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;
using ServiveceSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ServiveceSystem.BusinessLayer
{
    public class QuotationHeaderService
    {
        private readonly AppDBContext _context;

        public QuotationHeaderService(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<QuotationHeader>> GetAll()
        {
            return await _context.QuotationHeaders
                .Where(q => !q.isDeleted)
                .Include(q => q.Clinic)
                .Include(q => q.Contact)
                .ToListAsync();
        }

        public async Task<QuotationHeader> GetById(int id)
        {
            return await _context.QuotationHeaders
             .Include(q => q.Clinic)
             .Include(q => q.Contact)
             .Include(q => q.QuotationDetails)
             .FirstOrDefaultAsync(q => q.QuotationId == id);
        }

        public async Task<bool> AddQuotationHeader(QuotationHeader qout, string? username = "null")
        {
            username ??= CurrentUser.Username ?? "system";

            var clientExists = await _context.Clinics.AnyAsync(c => c.ClinicId == qout.ClinicId && !c.isDeleted);
            var contactExists = await _context.ContactPersons.AnyAsync(cp => cp.ContactId == qout.ContactId );

            if (!clientExists || !contactExists)
                return false;
            var exists = await _context.QuotationHeaders
                .AnyAsync(q => q.ClinicId == qout.ClinicId &&
                               q.InitialDate == qout.InitialDate &&
                               q.ExpireDate == qout.ExpireDate &&
                               !q.isDeleted);

            if (exists)
                return false;

            qout.CreatedLog = $"{username} - {DateTime.Now}";
            _context.QuotationHeaders.Add(qout);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateQuotationHeader(QuotationHeader qout, string? username = "null")
        {
            username ??= CurrentUser.Username ?? "system";

            var contactExists = await _context.ContactPersons.AnyAsync(cp => cp.ContactId == qout.ContactId);

            if (!contactExists)
                return false;
            var exists = await _context.QuotationHeaders
                .AnyAsync(q => q.QuotationId != qout.QuotationId &&
                               q.ClinicId == qout.ClinicId &&
                               q.InitialDate == qout.InitialDate &&
                !q.isDeleted);

            if (exists)
                return false;

            qout.UpdatedLog = $"{username} - {DateTime.Now}";
            _context.QuotationHeaders.Update(qout);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task Delete(int id, string? username = "null")
        {
            username ??= CurrentUser.Username ?? "system";

            var qout = await _context.QuotationHeaders.FindAsync(id);
            if (qout != null)
            {
                qout.DeletedLog = $"{username} - {DateTime.Now}";
                qout.isDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}


