using ServiceSystem.Models;
using ServiveceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ServiveceSystem.BusinessLayer
{
    public class ContactPersonService
    {
        private readonly AppDBContext _context;

        public ContactPersonService(AppDBContext context)
        {
            _context = context;
        }

        // Get all ContactPersons
        public async Task<List<ContactPerson>> GetAll()
        {
            return await _context.ContactPersons
                .Where(cp => !cp.isDeleted)
                .ToListAsync();
        }

        // Get ContactPerson by ID
        public async Task<ContactPerson> GetById(int id)
        {
            return await _context.ContactPersons.FindAsync(id);
        }

        // Add new ContactPerson
        public async Task AddContactPerson(ContactPerson contact)
        {
            bool clinicExists = await _context.Clinics.AnyAsync(c => c.ClinicId == contact.ClinicId && !c.isDeleted);
            if (!clinicExists)
                throw new Exception("Clinic not found");

            bool exists = await _context.ContactPersons.AnyAsync(cp =>
                cp.ContactName == contact.ContactName &&
                cp.ContactEmail == contact.ContactEmail &&
                cp.ClinicId == contact.ClinicId &&
                !cp.isDeleted
            );

            if (!exists)
            {
                contact.CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                _context.ContactPersons.Add(contact);
                await _context.SaveChangesAsync();
            }
        }

        // Update ContactPerson
        public async Task UpdateAsync(ContactPerson contact)
        {
            var existingContact = await _context.ContactPersons.FindAsync(contact.ContactId);
            if (existingContact != null)
            {
                bool clinicExists = await _context.Clinics.AnyAsync(c => c.ClinicId == contact.ClinicId && !c.isDeleted);
                if (!clinicExists)
                    throw new Exception("Clinic not found");

                existingContact.ContactName = contact.ContactName;
                existingContact.ContactNumber = contact.ContactNumber;
                existingContact.ContactEmail = contact.ContactEmail;
                existingContact.ClinicId = contact.ClinicId;
                existingContact.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";

                await _context.SaveChangesAsync();
            }
        }

        // Delete ContactPerson
        public async Task DeleteAsync(int id)
        {
            var contact = await _context.ContactPersons.FindAsync(id);
            if (contact != null)
            {
                contact.DeletedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                contact.isDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}
