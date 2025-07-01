using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiveceSystem.Models;

namespace ServiceSystem.Models
{
    public enum PaymentStatus
    {
        Pending,
        Partial,
        Completed
    }
    public class Payment
    {
        public int PaymentId { get; set; }
        [ForeignKey("InvoiceHeader")]
        public int InvoiceId { get; set; } // FK header
        public virtual InvoiceHeader? InvoiceHeader { get; set; }

        public decimal AmountPaid { get; set; }
        public decimal RemainingAmount { get; set; }
        public DateTime PaymentDate { get; set; }

        [ForeignKey("PaymentMethod")]
        public int PaymentMethodId { get; set; } // fk
        public virtual PaymentMethod? PaymentMethod { get; set; }

        public PaymentStatus PaymentStatus { get; set; }

        public string CreatedLog { get; set; }
        public string UpdatedLog { get; set; }
        public string DeletedLog { get; set; }
        public bool isDeleted { get; set; }
    }
}
