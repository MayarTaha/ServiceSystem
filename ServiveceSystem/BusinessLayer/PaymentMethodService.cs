using ServiveceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiveceSystem.BusinessLayer
{
    class PaymentMethodService
    {
        private readonly AppDBContext _context;

        public PaymentMethodService(AppDBContext context)
        {
            _context = context;
        }

        // Getall PaymentMethods
        public List<PaymentMethod> GetAll()
        {
            return _context.PaymentMethods.ToList();
        }

        // Get PaymentMethod by id
        public PaymentMethod? GetById(int id)
        {
            return _context.PaymentMethods.Find(id);
        }

        // Add new PaymentMethod
        public void AddPaymentMethod(PaymentMethod paymentMethod)
        {
           
            bool exists = _context.PaymentMethods.Any(pm => pm.PaymentType == paymentMethod.PaymentType);

            if (!exists)
            {
                _context.PaymentMethods.Add(paymentMethod);
                _context.SaveChanges();
            }
          
        }

        // Update 
        public void Update(PaymentMethod paymentMethod)
        {
            var existingMethod = _context.PaymentMethods.Find(paymentMethod.PaymentMethodId);
            if (existingMethod != null)
            {
                existingMethod.PaymentType = paymentMethod.PaymentType;
                _context.SaveChanges();
            }
           
        }

        // Delete 
        public void Delete(int id)
        {
            var method = _context.PaymentMethods.Find(id);
            if (method != null)
            {
                _context.PaymentMethods.Remove(method);
                _context.SaveChanges();
            }
        }

    }
}
