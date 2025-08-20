using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.Models.View
{
    public class InvoiceHeaderView
    {
        public int InvoiceHeaderId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Payment { get; set; }
        public string Note { get; set; }
        public decimal Discount { get; set; }
        public string DiscountType { get; set; }
        public string Status { get; set; }
        public string Reminder { get; set; }

        // Quotation
        public string QuotationName { get; set; }

        // Clinic
        public string ClinicName { get; set; }
        public string ClinicPhone { get; set; }
        public string ClinicEmail { get; set; }
        public string Location { get; set; }


        // Contact
        public string ClinicContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }

        // SalesMan
        public string SalesManName { get; set; }

        // Payment Method
        public string PaymentType { get; set; }

        // Taxes (concatenated string)
        public string Taxes { get; set; }
    }
}
