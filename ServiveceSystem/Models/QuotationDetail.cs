using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.Models
{
    public class QuotationDetail
    {
        public int QuotationDetailId { get; set; }
        [ForeignKey("QuotationHeader")]
        public int QuotationId { get; set; } // FK
        
        public QuotationHeader QuotationHeader { get; set; }
        [ForeignKey("Service")]
        public int ServiceId { get; set; } // fk
        public Service Service { get; set; }

        public int Quantity { get; set; }
        public Discount DiscountType { get; set; } 
        public decimal Discount { get; set; }

       

        public decimal ServicePrice { get; set; }

        public decimal TotalService { get; set; } // Calculated: ServicePrice * Quantity - Discount

        public string CreatedLog { get; set; }
        public string UpdatedLog { get; set; }
        public string DeletedLog { get; set; }
        public bool isDeleted { get; set; }

    }
}
