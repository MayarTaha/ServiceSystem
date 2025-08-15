using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiveceSystem.Models;

namespace ServiceSystem.Models
{
    public enum InvoiceStatus
    {
        Pending,
        Approved,
        Rejected,
        Expired
    }
    public class InvoiceHeader
    {
        public int InvoiceHeaderId { get; set; }

        [ForeignKey("QuotationHeader")]
        public int? QuotationId { get; set; } // FK
        public virtual QuotationHeader? QuotationHeader { get; set; }
        [ForeignKey("SalesMan")] 
        public int? SalesManId { get; set; } // FK
        public virtual SalesMan? SalesMan { get; set; }



        public string InvoiceDate { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Payment { get; set; }
        public string Note { get; set; }

        public decimal Discount { get; set; }
        public Discount DiscountType { get; set; }
        public InvoiceStatus Status { get; set; }


        [ForeignKey("PaymentMethod")]
        public int PaymentMethodId { get; set; } // fk
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public string Reminder { get; set; }
        [ForeignKey("Contact")]
        public int ContactId { get; set; } ///fk

        public virtual ContactPerson? Contact { get; set; }

        public virtual List<Taxes>? Taxes { get; set; }

        public virtual List<InvoiceDetail>? InvoiceDetails { get; set; }


        public string CreatedLog { get; set; }
        public string UpdatedLog { get; set; }
        public string DeletedLog { get; set; }
        public bool isDeleted { get; set; }
    }
}
