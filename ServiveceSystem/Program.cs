using DevExpress.XtraWaitForm;
using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;
using ServiveceSystem.PresentationLayer;
using ServiveceSystem.PresentationLayer.Clinic;
using ServiveceSystem.PresentationLayer.ContactPerson;
using ServiveceSystem.PresentationLayer.InvoiceDetail;
using ServiveceSystem.PresentationLayer.PaymentMethod;
using ServiveceSystem.PresentationLayer.QuotationHeader;

namespace ServiveceSystem
{
    internal static class Program
    {




        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new AllPaymentMethods()
            // ); // ← your desired form here
        }

        //static async Task Main(string[] args)
        //{
        //    var context = new AppDBContext();
        //    var quotationService = new QuotationHeaderService(context);

        //    var newQuotation = new QuotationHeader
        //    {
        //        ClinicId = 6, // نفس العيادة ممكن، لكن غيري التواريخ
        //        ContactId = 1,
        //        InitialDate = DateTime.Today.AddDays(1), // غيري التاريخ علشان يكون سطر جديد
        //        ExpireDate = DateTime.Today.AddDays(6),
        //        Note = "الحقونا  ",
        //        Status = QuotationStatus.Pending,
        //        DiscountType = Discount.Percentage,
        //        Discount = 90, // خصم مختلف
        //        TotalDuo = 850, // قيمة مختلفة
        //        CreatedLog = "", // هيتعدل داخل Add
        //        UpdatedLog = "",
        //        DeletedLog = "",
        //        isDeleted = false
        //    };

        //    var success = await quotationService.AddQuotationHeader(newQuotation, "Roaa");

        //    if (success)
        //        Console.WriteLine("✔️ تم إضافة العرض بنجاح");
        //    else
        //        Console.WriteLine("❌ فشل في الإضافة. تأكدي من صحة Clinic و Contact.");
        //}

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    // To customize application configuration such as set high DPI settings or default font,
        //    // see https://aka.ms/applicationconfiguration.
        //    ApplicationConfiguration.Initialize();
        //    Application.Run(new Form1());

        //    var newClinic = new Clinic
        //    {
        //        ClinicName = "Sunshine Clinic",
        //        CompanyName = "Sunshine Healthcare Group",
        //        Phone = "0123456789",
        //        Email = "info@sunshine.com",
        //        Location = "Nasr City, Cairo",
        //        CreatedLog = DateTime.Now.ToString(),
        //        UpdatedLog = DateTime.Now.ToString(),
        //        isDeleted = false
        //    };

        //    var clinicService = new ClinicService(_context); 
        //    clinicService.AddClinic(newClinic);

        //}
        //static void Main(string[] args)
        //{
        //    using (var context = new AppDBContext()) 
        //    {
        //        var clinicService = new ClinicService(context);

        //        try
        //        {
        //            var clinic = new Clinic
        //            {
        //                ClinicName = "roaa",
        //                CompanyName = "Tariq",
        //                Phone = "01017557580",
        //                Email = "test@test.com",
        //                Location = "minia",
        //                CreatedLog = DateTime.Now.ToString(),
        //                UpdatedLog = DateTime.Now.ToString(),
        //                DeletedLog = "",
        //                isDeleted = false
        //            };




        //            clinicService.AddClinic(clinic);
        //            Console.WriteLine("Clinic added successfully!");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("ERROR: " + ex.Message);
        //            if (ex.InnerException != null)
        //                Console.WriteLine("INNER: " + ex.InnerException.Message);
        //        }

        //        var contactService = new ContactPersonService(context);
        //        var newContact = new ContactPerson
        //        {
        //            ContactName = "Ali Youssef",
        //            ContactEmail = "ali@example.com",
        //            ContactNumber = "01012345678",
        //            ClinicId = 5
        //        };

        //        try
        //        {
        //            contactService.AddContactPerson(newContact);
        //            Console.WriteLine("ContactPerson added successfully.");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("ERROR: " + ex.Message);
        //        }

        //    }




        //}




    }
}
