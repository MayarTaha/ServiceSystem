using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.Models
{
    public class ContactPerson
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }

        [ForeignKey("Clinic")]
        public int ClinicId { get; set; }
        public virtual Clinic Clinic { get; set; }
    }
}
