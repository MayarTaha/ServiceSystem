using ServiceSystem.Models;
using ServiveceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiveceSystem.BusinessLayer
{
    class PaymentService
    {
        private readonly AppDBContext _context;

        public PaymentService(AppDBContext context)
        {
            _context = context;
        }

        // Get all Payments
        public List<Payment> GetAll()
        {
            return _context.payments.ToList();
        }

        // Get Payment by ID
        public Payment? GetById(int id)
        {
            return _context.payments.Find(id);
        }

        // Add new Payment
        public void AddPayment(Payment payment)
        {
           
            var exists = _context.payments.Any(p => p.PaymentId == payment.PaymentId && !p.isDeleted);

            if (!exists)
            {
                payment.CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                _context.payments.Add(payment);
                _context.SaveChanges();
            }
        }

        // Update Payment
        public void Update(Payment payment)
        {
            var existingPayment = _context.payments.Find(payment.PaymentId);
            if (existingPayment != null)
            {
               
                existingPayment.InvoiceId = payment.InvoiceId;
                existingPayment.AmountPaid = payment.AmountPaid;
                existingPayment.RemainingAmount = payment.RemainingAmount;
                existingPayment.PaymentDate = payment.PaymentDate;
                existingPayment.PaymentMethodId = payment.PaymentMethodId;
                existingPayment.PaymentStatus = payment.PaymentStatus;
                existingPayment.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";

                _context.SaveChanges();
            }
        }

        //update with two check on the fk ????
        //public void UpdateWithCheck(Payment payment)
        //{
        //    var existingPayment = _context.payments.Find(payment.PaymentId);
        //    if (existingPayment != null)
        //    {

        //        bool invoiceExists = _context.invoiceHeaders.Any(i => i.InvoiceHeaderId == payment.InvoiceId);
        //        if (!invoiceExists)
        //        {
        //            throw new Exception("Invoice not found");
        //        }


        //        bool paymentMethodExists = _context.PaymentMethods.Any(pm => pm.PaymentMethodId == payment.PaymentMethodId);
        //        if (!paymentMethodExists)
        //        {
        //            throw new Exception("Payment Method not found");
        //        }


        //        existingPayment.InvoiceId = payment.InvoiceId;
        //        existingPayment.AmountPaid = payment.AmountPaid;
        //        existingPayment.RemainingAmount = payment.RemainingAmount;
        //        existingPayment.PaymentDate = payment.PaymentDate;
        //        existingPayment.PaymentMethodId = payment.PaymentMethodId;
        //        existingPayment.PaymentStatus = payment.PaymentStatus;
        //        existingPayment.UpdatedLog = DateTime.Now.ToString();

        //        _context.SaveChanges();
        //    }
        //    else
        //    {
        //        throw new Exception("Payment not found");
        //    }
        //}


        // Delete Payment
        public void Delete(int id)
        {
            var payment = _context.payments.Find(id);
            if (payment != null)
            {
                payment.DeletedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                payment.isDeleted = true;
                _context.SaveChanges();
            }
        }

    }
}
