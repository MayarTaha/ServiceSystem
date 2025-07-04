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
    public class TaxesService
    {
        private readonly AppDBContext _context;

        public TaxesService(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<Taxes>> GetAll()
        {
            return await _context.Taxeses
                .Where(e => !e.isDeleted)
                .ToListAsync();
        }

        public async Task<Taxes> GetById(int id)
        {
            return await _context.Taxeses.FindAsync(id);
        }

        public async Task AddTaxes(Taxes taxes)
        {
            var exists = await _context.Taxeses.AnyAsync(s => s.Name.ToLower() == taxes.Name.ToLower() && !s.isDeleted);

            if (!exists)
              { 
                //taxes.CreatedLog = DateTime.Now;
                _context.Taxeses.Add(taxes);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Taxes taxes)
        {
            var exists = await _context.Taxeses.AnyAsync(s => s.Name.ToLower() == taxes.Name.ToLower() && !s.isDeleted);

            if (!exists)
            {
               // taxes.UpdatedLog = DateTime.Now;
                _context.Taxeses.Update(taxes);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var taxes = await _context.Taxeses.FindAsync(id);
            if (taxes != null)
            {
                taxes.isDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}
