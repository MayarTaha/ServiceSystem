using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;

namespace ServiveceSystem.Models
{
    public class AppDBContext : DbContext
    {
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<ContactPerson> ContactPersons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<QuotationHeader> QuotationHeaders { get; set; }
        public DbSet<QuotationDetail> QuotationDetails { get; set; }
        public DbSet<InvoiceHeader> invoiceHeaders { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Taxes> Taxeses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ServiceSystem;Trusted_Connection=True;Trust server certificate=true ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            // --- Clinic and ContactPerson --- //
            modelBuilder.Entity<Clinic>()
                .HasMany(c => c.ContactPersons)
                .WithOne(cp => cp.Clinic)
                .HasForeignKey(cp => cp.ClinicId)
                .OnDelete(DeleteBehavior.NoAction);

            // --- QuotationHeader and Clinic --- //
            modelBuilder.Entity<QuotationHeader>()
                .HasOne(qh => qh.Clinic)
                .WithMany()
                .HasForeignKey(qh => qh.ClinicId)
                .OnDelete(DeleteBehavior.NoAction);

            // --- QuotationHeader and ContactPerson --- //
            modelBuilder.Entity<QuotationHeader>()
                .HasOne(qh => qh.Contact)
                .WithMany()
                .HasForeignKey(qh => qh.ContactId)
                .OnDelete(DeleteBehavior.NoAction);

            // --- QuotationHeader and QuotationDetail (One-to-Many) --- //
            modelBuilder.Entity<QuotationHeader>()
                .HasMany(qh => qh.QuotationDetails)
                .WithOne(qd => qd.QuotationHeader)
                .HasForeignKey(qd => qd.QuotationId)
                .OnDelete(DeleteBehavior.NoAction);

            // --- QuotationDetail and Service (Many-to-One) --- //
            // Assuming QuotationDetail has a ServiceId and virtual Service Service property
            // If not, you might need to add it to QuotationDetail for this relationship.
            // Based on your previous InvoiceDetail, I'm assuming a similar structure for QuotationDetail.
            // If Service is not directly linked to QuotationDetail, this part should be removed.
            // However, it's common for quotation details to link to a service.
            // If QuotationDetail.ServicePrice is meant to be the price of a specific Service, then this link is needed.
            // I'll add it for now, assuming it's missing from QuotationDetail.cs but intended.
            // If Service is not a direct FK on QuotationDetail, remove this block.
            // modelBuilder.Entity<QuotationDetail>()
            //     .HasOne(qd => qd.Service) // Assuming you add 'public virtual Service Service { get; set; }' to QuotationDetail
            //     .WithMany()
            //     .HasForeignKey(qd => qd.ServiceId); // Assuming you add 'public int ServiceId { get; set; }' to QuotationDetail

            // --- InvoiceHeader and QuotationHeader --- //
            modelBuilder.Entity<InvoiceHeader>()
                .HasOne(ih => ih.QuotationHeader)
                .WithMany()
                .HasForeignKey(ih => ih.QuotationId)
                .OnDelete(DeleteBehavior.NoAction);




            // --- InvoiceHeader and PaymentMethod --- //
            modelBuilder.Entity<InvoiceHeader>()
                .HasOne(ih => ih.PaymentMethod)
                .WithMany()
                .HasForeignKey(ih => ih.PaymentMethodId)
                .OnDelete(DeleteBehavior.NoAction);

            // --- InvoiceHeader and ContactPerson --- //
            modelBuilder.Entity<InvoiceHeader>()
                .HasOne(ih => ih.Contact)
                .WithMany()
                .HasForeignKey(ih => ih.ContactId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<InvoiceDetail>()
            .HasOne(d => d.InvoiceHeader)
            .WithMany(h => h.InvoiceDetails)
            .HasForeignKey(d => d.InvoiceHeaderId)
            .OnDelete(DeleteBehavior.Cascade); // أو Restrict حسب المطلوب


            // --- InvoiceHeader and InvoiceDetail (One-to-Many) --- //
            // Assuming InvoiceHeader has a List<InvoiceDetail> navigation property
            //modelBuilder.Entity<InvoiceHeader>()
            //    .HasMany<InvoiceDetail>() // InvoiceHeader has many InvoiceDetails
            //    .WithOne() // Each InvoiceDetail has one InvoiceHeader
            //    .HasForeignKey(d => d.InvoiceHeaderId)
            //    .OnDelete(DeleteBehavior.NoAction);  // Assuming InvoiceDetail has InvoiceHeaderId as FK
            // Note: If InvoiceDetail does not have a direct InvoiceHeaderId, you might need to add it
            // or configure a many-to-many if that's the intent.
            // Based on your InvoiceDetail, it links to QuotationHeader, not InvoiceHeader directly.
            // This implies InvoiceDetail is linked to QuotationHeader, and InvoiceHeader is also linked to QuotationHeader.
            // If InvoiceDetail is meant to be a child of InvoiceHeader, then InvoiceDetail needs an InvoiceHeaderId FK.
            // For now, I'll assume InvoiceDetail is a child of InvoiceHeader and add a placeholder.
            // If InvoiceDetail should only link to QuotationHeader, then this relationship needs to be re-evaluated.

            // --- InvoiceDetail and Service --- //
            modelBuilder.Entity<InvoiceDetail>()
                .HasOne(id => id.Service)
                .WithMany()
                .HasForeignKey(id => id.ServiceId)
                .OnDelete(DeleteBehavior.NoAction);

            // --- InvoiceDetail and QuotationHeader --- //
            // This relationship is already defined in InvoiceDetail.cs with [ForeignKey("QuotationHeader")]
            // but explicitly defining it here for clarity and to set delete behavior.
            modelBuilder.Entity<InvoiceDetail>()
                .HasOne(id => id.QuotationHeader)
                .WithMany()
                .HasForeignKey(id => id.QuotationId)
                .OnDelete(DeleteBehavior.NoAction);

            // --- Payment and InvoiceHeader --- //
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.InvoiceHeader)
                .WithMany()
                .HasForeignKey(p => p.InvoiceId)
                .OnDelete(DeleteBehavior.NoAction);

            // --- Payment and PaymentMethod --- //
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.PaymentMethod)
                .WithMany()
                .HasForeignKey(p => p.PaymentMethodId)
                .OnDelete(DeleteBehavior.NoAction);

            // --- Computed Columns --- //

            // QuotationDetail.TotalService
            // Assuming DiscountType is an enum with Percentage and Value/FixedAmount
            // And Discount is the raw value (e.g., 10 for 10% or 10 for $10)
            //modelBuilder.Entity<QuotationDetail>()
            //    .Property(qd => qd.TotalService)
            //    .HasComputedColumnSql(
            //        "CASE WHEN [DiscountType] = 1 THEN ([ServicePrice] * [Quantity]) * (1 - [Discount] / 100.0) ELSE ([ServicePrice] * [Quantity]) - [Discount] END");

            //// InvoiceDetail.TotalService
            //modelBuilder.Entity<InvoiceDetail>()
            //    .Property(id => id.TotalService)
            //    .HasComputedColumnSql(
            //        "CASE WHEN [DiscountType] = 1 THEN ([ServicePrice] * [Quantity]) * (1 - [Discount] / 100.0) ELSE ([ServicePrice] * [Quantity]) - [Discount] END");


          
        }

        
    }
}
