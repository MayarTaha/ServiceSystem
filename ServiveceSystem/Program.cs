using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;

namespace ServiveceSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
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
        static void Main(string[] args)
        {
            using (var context = new AppDBContext()) 
            {
                var clinicService = new ClinicService(context);

                try
                {
                    var clinic = new Clinic
                    {
                        ClinicName = "roaa",
                        CompanyName = "Tariq",
                        Phone = "01017557580",
                        Email = "test@test.com",
                        Location = "minia",
                        CreatedLog = DateTime.Now.ToString(),
                        UpdatedLog = DateTime.Now.ToString(),
                        DeletedLog = "",
                        isDeleted = false
                    };

                    


                    clinicService.AddClinic(clinic);
                    Console.WriteLine("Clinic added successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    if (ex.InnerException != null)
                        Console.WriteLine("INNER: " + ex.InnerException.Message);
                }

                var contactService = new ContactPersonService(context);
                var newContact = new ContactPerson
                {
                    ContactName = "Ali Youssef",
                    ContactEmail = "ali@example.com",
                    ContactNumber = "01012345678",
                    ClinicId = 5
                };

                try
                {
                    contactService.AddContactPerson(newContact);
                    Console.WriteLine("ContactPerson added successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }

            }

           


        }

    }
}
