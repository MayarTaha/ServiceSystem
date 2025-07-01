using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ServicePrice { get; set; }
        public string CreatedLog { get; set; }
        public string UpdatedLog { get; set; }
        public string DeletedLog { get; set; }
        public bool isDeleted { get; set; }
    }
}
