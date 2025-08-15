using ServiceSystem.Models;
using ServiveceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ServiveceSystem.BusinessLayer
{
    public class SalesManService
    {
        private readonly AppDBContext _context;

        public SalesManService(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<SalesMan>> GetAll()
        {
            return await _context.SalesMen
                .Where(s => !s.isDeleted)
                .OrderBy(s => s.SalesManName)
                .ToListAsync();
        }

        public async Task<SalesMan> GetById(int id)
        {
            return await _context.SalesMen.FindAsync(id);
        }

        public async Task AddAsync(SalesMan salesMan)
        {
            if (string.IsNullOrWhiteSpace(salesMan.SalesManName))
                throw new Exception("Name is required");

            bool exists = await _context.SalesMen.AnyAsync(s => s.SalesManName == salesMan.SalesManName && !s.isDeleted);
            if (exists)
                throw new Exception("Salesman with the same name already exists");

            salesMan.CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
            salesMan.UpdatedLog = string.Empty;
            salesMan.DeletedLog = string.Empty;
            salesMan.isDeleted = false;
            _context.SalesMen.Add(salesMan);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SalesMan salesMan)
        {
            var existing = await _context.SalesMen.FindAsync(salesMan.SalesManId);
            if (existing == null)
                throw new Exception("Salesman not found");

            if (string.IsNullOrWhiteSpace(salesMan.SalesManName))
                throw new Exception("Name is required");

            bool duplicate = await _context.SalesMen
                .AnyAsync(s => s.SalesManName == salesMan.SalesManName && s.SalesManId != salesMan.SalesManId && !s.isDeleted);
            if (duplicate)
                throw new Exception("Another salesman with the same name exists");

            existing.SalesManName = salesMan.SalesManName;
            existing.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existing = await _context.SalesMen.FindAsync(id);
            if (existing != null)
            {
                existing.DeletedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                existing.isDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}


