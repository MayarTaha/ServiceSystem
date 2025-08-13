using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.Models
{
   public class SalesMan
    {
        public int? SalesManId { get; set; }
        public string SalesManName { get; set; }
        public string CreatedLog { get; set; }
        public string UpdatedLog { get; set; }
        public string DeletedLog { get; set; }
        public bool isDeleted { get; set; }

        public List<InvoiceHeader>? InvoiceHeaders { get; set; }
        public List<QuotationHeader>? QuotationHeaders { get; set; }

    }
}
