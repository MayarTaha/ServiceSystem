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
    public class ClinicService
    {
        private readonly AppDBContext _context;

        public ClinicService(AppDBContext context)
        {
            _context = context;
        }

        //Get All  Clinics
        public async Task<List<Clinic>> GetAll()
        {
            return await _context.Clinics
                .Include(E => E.ContactPersons)
                .Where(c => !c.isDeleted)
                .ToListAsync();
        }

        //get by id
        public async Task<Clinic> GetById(int id)
        {
            return await _context.Clinics.FindAsync(id);
        }

        //Add new Clinic
        public async Task AddClinic(Clinic clinic)
        {
            var exists = await _context.Clinics.AnyAsync(c => c.ClinicName.ToLower() == clinic.ClinicName.ToLower() && !c.isDeleted);

            if (!exists)
            {
                clinic.CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                _context.Clinics.Add(clinic);
                await _context.SaveChangesAsync();
            }
        }

        // update 
        public async Task UpdateAsync(Clinic clinic)
        {
            var existingClinic = await _context.Clinics.FindAsync(clinic.ClinicId);
            if (existingClinic != null)
            {
                existingClinic.ClinicName = clinic.ClinicName;
                existingClinic.Phone = clinic.Phone;
                existingClinic.Email = clinic.Email;
                existingClinic.CompanyName = clinic.CompanyName;
                existingClinic.Location = clinic.Location;
                
                existingClinic.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";

                await _context.SaveChangesAsync();
            }
        }

        //deleted
        public async Task DeleteAsync(int id)
        {
            var clinic = await _context.Clinics.FindAsync(id);
            if (clinic != null)
            {
                clinic.DeletedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                clinic.isDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}
