using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.Models
{
    public class Clinic
    {
        public int ClinicId { get; set; }
        public string ClinicName { get; set; }
        public string? CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

       
        public virtual List<ContactPerson>? ContactPersons { get; set; }

        public string Location { get; set; }
        public string CreatedLog { get; set; }
        public string UpdatedLog { get; set; }
        public string DeletedLog { get; set; }
        public bool isDeleted { get; set; }//test
    }
}
