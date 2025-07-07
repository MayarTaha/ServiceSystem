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
    class ClinicService
    {
        private readonly AppDBContext _context;

        public ClinicService(AppDBContext context)
        {
            _context = context;
        }

        //Get All  Clinics
        public List<Clinic> GetAll()
        {
            return _context.Clinics.Include(E => E.ContactPersons).ToList();
        }

        //get by id

        public Clinic? GetById(int id)
        {
            return _context.Clinics.Find(id);
        }
        //Add new Clinic

        public void AddClinic(Clinic clinic)
        {

            
            var exists = _context.Clinics.Any(c => c.ClinicName.ToLower() == clinic.ClinicName.ToLower() && !c.isDeleted);

            if (!exists)
            {
                clinic.CreatedLog = DateTime.Now.ToString();
                _context.Clinics.Add(clinic);
                _context.SaveChanges();
            }
           
        }

        // update 
        public void Update(Clinic clinic)
        {
            var existingClinic = _context.Clinics.Find(clinic.ClinicId);
            if (existingClinic != null)
            {
                existingClinic.ClinicName = clinic.ClinicName;
                existingClinic.Phone = clinic.Phone;
                existingClinic.Email = clinic.Email;
                existingClinic.CompanyName = clinic.CompanyName;
                existingClinic.Location = clinic.Location;
                

                _context.SaveChanges();
            }
        }
        //deleted
        public void Delete(int id)
        {
            var clinic = _context.Clinics.Find(id);
            if (clinic != null)
            {
                _context.Clinics.Remove(clinic);
                _context.SaveChanges();
            }
        }



    }
}
