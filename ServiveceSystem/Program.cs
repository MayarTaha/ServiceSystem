using DevExpress.XtraWaitForm;
using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;
using ServiceSystem.PresentationLayer.InvoiceDetail;
using ServiceSystem.PresentationLayer.QuotationHeader;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;
using ServiveceSystem.PresentationLayer;
using ServiveceSystem.PresentationLayer.Clinic;
using ServiveceSystem.PresentationLayer.ContactPerson;
using ServiveceSystem.PresentationLayer.InvoiceDetail;
using ServiveceSystem.PresentationLayer.PaymentMethod;
using ServiveceSystem.PresentationLayer.QuotationHeader;
using ServiveceSystem.PresentationLayer.Service;
using ServiveceSystem.PresentationLayer.User;

namespace ServiveceSystem
{
    internal static class Program
    {


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Enable DevExpress dark skin
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
             Application.Run(new AllInvoices());
           // Application.Run(new AllQuotations()); // ← your desired form here
          //  Application.Run(new AllContactPersons());
        }

    }
}
