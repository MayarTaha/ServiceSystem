using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.Models.View
{
   public class InvoiceDetailView
    {
        public int InvoiceHeaderId { get; set; }

        public string ServiceName { get; set; }
        public decimal ServicePrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public Discount DiscountType { get; set; }
        public decimal TotalService { get; set; }
    }
}
