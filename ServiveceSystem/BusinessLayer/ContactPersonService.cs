using ServiceSystem.Models;
using ServiveceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiveceSystem.BusinessLayer
{
    class ContactPersonService
    {
        private readonly AppDBContext _context;

        public ContactPersonService(AppDBContext context)
        {
            _context = context;
        }

        // Get all ContactPersons
        public List<ContactPerson> GetAll()
        {
            return _context.ContactPersons.ToList();
        }

        // Get ContactPerson by ID
        public ContactPerson? GetById(int id)
        {
            return _context.ContactPersons.Find(id);
        }

        // Add new ContactPerson
        public void AddContactPerson(ContactPerson contact)
        {
            
            bool clinicExists = _context.Clinics.Any(c => c.ClinicId == contact.ClinicId);
            if (!clinicExists)
                throw new Exception("Clinic not found");

            bool exists = _context.ContactPersons.Any(cp =>
                cp.ContactName == contact.ContactName &&
                cp.ContactEmail == contact.ContactEmail &&
                cp.ClinicId == contact.ClinicId
            );

            if (!exists)
            {
                _context.ContactPersons.Add(contact);
                _context.SaveChanges();
            }
           
        }

        // Update ContactPerson
        public void Update(ContactPerson contact)
        {
            var existingContact = _context.ContactPersons.Find(contact.ContactId);
            if (existingContact != null)
            {
               
                bool clinicExists = _context.Clinics.Any(c => c.ClinicId == contact.ClinicId);
                if (!clinicExists)
                    throw new Exception("Clinic not found");

                existingContact.ContactName = contact.ContactName;
                existingContact.ContactNumber = contact.ContactNumber;
                existingContact.ContactEmail = contact.ContactEmail;
                existingContact.ClinicId = contact.ClinicId;

                _context.SaveChanges();
            }
          
        }

        // Delete ContactPerson
        public void Delete(int id)
        {
            var contact = _context.ContactPersons.Find(id);
            if (contact != null)
            {
                _context.ContactPersons.Remove(contact);
                _context.SaveChanges();
            }
        }

    }
}
