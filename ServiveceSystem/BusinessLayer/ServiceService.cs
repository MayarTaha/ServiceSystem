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
    public class ServiceService
    {
        private readonly AppDBContext _context;

        public ServiceService(AppDBContext context)
        {
            _context = context;
        }
        public async Task<List<Service>> GetAll()
        {
            return await _context.Services
                .Where(e => !e.isDeleted)
                .ToListAsync();
        }

        public async Task<Service> GetById(int id)
        {
            return await _context.Services.FindAsync(id);
        }

        public async Task AddService(Service service)
        {
            var exists = await _context.Services.AnyAsync(s => s.Name.ToLower() == service.Name.ToLower() && !s.isDeleted);

            if (!exists)
            {
                service.CreatedLog = DateTime.Now.ToString();
                _context.Services.Add(service);
                await _context.SaveChangesAsync();
            }

        }

        public async Task UpdateService(Service service)
        {
            var exists = await _context.Services.AnyAsync(s => s.Name.ToLower() == service.Name.ToLower() && s.ServiceId != service.ServiceId && !s.isDeleted);

            if (exists)
                service.UpdatedLog = DateTime.Now.ToString();
                _context.Services.Update(service);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteService(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service != null)
            {
                service.isDeleted = true;
                service.DeletedLog = DateTime.Now.ToString();
                await _context.SaveChangesAsync();
            }
        }
    }
}
