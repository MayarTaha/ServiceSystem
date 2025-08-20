using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.Models.View
{
   public class QuotationHeaderView
    {
        public int QuotationId { get; set; }
        public string QuotationNaMe { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string DiscountType { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalDuo { get; set; }

        // Clinic info
        public string ClinicName { get; set; }
        public string ClinicPhone { get; set; }
        public string ClinicEmail { get; set; }
        public string Location { get; set; }

        // Contact info
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }

        // SalesMan
        public string SalesManName { get; set; }

        // Taxes
        public string Taxes { get; set; }
    }
}
