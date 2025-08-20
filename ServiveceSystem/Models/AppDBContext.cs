using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;
using ServiceSystem.Models.View;

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

        public DbSet<SalesMan> SalesMen { get; set; }

        //my views 
        public DbSet<InvoiceHeaderView> InvoiceHeaderViews { get; set; }
        public DbSet<QuotationHeaderView> QuotationHeaderViews { get; set; }
        public DbSet<InvoiceDetailView> InvoiceDetailViews { get; set; }
        public DbSet<QuotationDetailView> QuotationDetailViews { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ServiceSystem;Trusted_Connection=True;Trust server certificate=true ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            //invoice header view
            modelBuilder.Entity<InvoiceHeaderView>(entity =>
            {
                // Map to your SQL view
                entity.ToView("vw_InvoiceHeader");

                // Specify the key (must exist in your view!)
                entity.HasKey(e => e.InvoiceHeaderId);

               
            });
            //invoice detail view
            modelBuilder.Entity<InvoiceDetailView>(entity =>
            {
                entity.ToView("vw_InvoiceDetail");
                entity.HasNoKey();
            });


            //quotation header view
            modelBuilder.Entity<QuotationHeaderView>(entity =>
            {
                // Map to your SQL view
                entity.ToView("vw_QuotationHeader");

                // Specify the key (must exist in your view!)
                entity.HasKey(e => e.QuotationId);


            });
            // quotation details view
            modelBuilder.Entity<QuotationDetailView>(entity =>
            {
                // Map to your SQL view
                entity.ToView("vw_QuotationDetail");

                // Specify the key (must exist in your view!)
                entity.HasNoKey();


            });


            modelBuilder.Entity<SalesMan>()
                .HasMany(s => s.InvoiceHeaders)
                .WithOne(i => i.SalesMan)
                .HasForeignKey(i => i.SalesManId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SalesMan>()
                .HasMany(s => s.QuotationHeaders)
                .WithOne(q => q.SalesMan)
                .HasForeignKey(q => q.SalesManId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);


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

            // --- QuotationHeader and Clinic --- //
            modelBuilder.Entity<InvoiceHeader>()
                .HasOne(i => i.Clinic)
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

          

            // --- InvoiceHeader and QuotationHeader --- //
            modelBuilder.Entity<InvoiceHeader>()
                .HasOne(ih => ih.QuotationHeader)
                .WithMany()
                .HasForeignKey(ih => ih.QuotationId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);

            // ممكن امسحه 
            modelBuilder.Entity<InvoiceDetail>()
    .HasOne(id => id.QuotationHeader)
    .WithMany()
    .HasForeignKey(id => id.QuotationId)
    .IsRequired(false) // <-- also key
    .OnDelete(DeleteBehavior.NoAction);


            //-------




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


           
            // --- InvoiceDetail and Service --- //
            modelBuilder.Entity<InvoiceDetail>()
                .HasOne(id => id.Service)
                .WithMany()
                .HasForeignKey(id => id.ServiceId)
                .OnDelete(DeleteBehavior.NoAction);

            
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



          
        }

        
    }
}
