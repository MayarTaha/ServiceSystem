using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.Models
{
    public enum QuotationStatus
    {
        Pending,
        Approved,
        Rejected,
        Expired
    }

    public enum priorityStatus
    {
        LowLevel,
        MediumLevel,
        HighLevel
    }

    [Flags]
     public enum Discount
    {
        NotSelected,
        Value,
        Percentage
    }
    public class QuotationHeader
    {
        [Key]
        public int QuotationId { get; set; }
        
        [ForeignKey("Clinic")]
        public int ClinicId { get; set; } ///fk
        public virtual Clinic Clinic { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Note { get; set; }

        public string QuotationNaMe { get; set; }
        public QuotationStatus Status { get; set; }

        public priorityStatus priority { get; set; }
        
        public Discount DiscountType { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalDuo { get; set; }

        
        [ForeignKey("Contact")]
        public int ContactId { get; set; } ///fk
        public virtual ContactPerson? Contact { get; set; }
        public string CreatedLog { get; set; }
        public string UpdatedLog { get; set; }
        public string DeletedLog { get; set; }
        public bool isDeleted { get; set; }
        public virtual List<QuotationDetail>? QuotationDetails { get; set; }
        public virtual List<Taxes>? Taxes { get; set; }


    }
}
