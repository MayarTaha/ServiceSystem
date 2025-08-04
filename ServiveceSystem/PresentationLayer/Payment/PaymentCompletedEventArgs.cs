using System;

namespace ServiveceSystem.PresentationLayer.Payment
{
    public class PaymentCompletedEventArgs : EventArgs
    {
        public int InvoiceId { get; set; }
        public decimal NewRemainder { get; set; }
        public PaymentCompletedEventArgs(int invoiceId, decimal newRemainder)
        {
            InvoiceId = invoiceId;
            NewRemainder = newRemainder;
        }
    }
} 