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
    public class PaymentService
    {
        private readonly AppDBContext _context;

        public PaymentService(AppDBContext context)
        {
            _context = context;
        }

        // Get all Payments
        public async Task<List<Payment>> GetAll()
        {
            return await _context.payments
                .Where(p => !p.isDeleted)
                .ToListAsync();
        }

        // Get Payment by ID
        public async Task<Payment> GetById(int id)
        {
            return await _context.payments.FindAsync(id);
        }

        // Add new Payment
        public async Task AddPayment(Payment payment)
        {
            var exists = await _context.payments.AnyAsync(p => p.PaymentId == payment.PaymentId && !p.isDeleted);

            if (!exists)
            {
                payment.CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                _context.payments.Add(payment);
                await _context.SaveChangesAsync();
            }
        }

        // Update Payment
        public async Task UpdateAsync(Payment payment)
        {
            var existingPayment = await _context.payments.FindAsync(payment.PaymentId);
            if (existingPayment != null)
            {
                existingPayment.InvoiceId = payment.InvoiceId;
                existingPayment.AmountPaid = payment.AmountPaid;
                existingPayment.RemainingAmount = payment.RemainingAmount;
                existingPayment.PaymentDate = payment.PaymentDate;
                existingPayment.PaymentMethodId = payment.PaymentMethodId;
                existingPayment.PaymentStatus = payment.PaymentStatus;
                existingPayment.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";

                await _context.SaveChangesAsync();
            }
        }

        // Delete Payment
        public async Task DeleteAsync(int id)
        {
            var payment = await _context.payments.FindAsync(id);
            if (payment != null)
            {
                payment.DeletedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                payment.isDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}
