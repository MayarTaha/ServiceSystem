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
                taxes.CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                _context.Taxeses.Add(taxes);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Taxes taxes)
        {
            // Check if another tax with the same name exists (excluding the current tax being updated)
            var exists = await _context.Taxeses.AnyAsync(s => 
                s.Name.ToLower() == taxes.Name.ToLower() && 
                !s.isDeleted && 
                s.TaxesID != taxes.TaxesID);

            if (!exists)
            {
                taxes.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                _context.Taxeses.Update(taxes);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"A tax with the name '{taxes.Name}' already exists.");
            }
        }

        public async Task DeleteAsync(int id)
        {
            var taxes = await _context.Taxeses.FindAsync(id);
            if (taxes != null)
            {
                taxes.DeletedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                taxes.isDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}
