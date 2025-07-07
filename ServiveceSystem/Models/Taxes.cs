using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.Models
{
    public class Taxes
    {
        public int TaxesID { get; set; }
        public string Name { get; set; }
        public decimal TaxRate { get; set; }
        public string CreatedLog { get; set; }
        public string UpdatedLog { get; set; }
        public string DeletedLog { get; set; }
        public bool isDeleted { get; set; }
        //test taxes
    }
}
