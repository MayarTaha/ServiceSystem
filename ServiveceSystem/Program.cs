using DevExpress.XtraWaitForm;
using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;
using ServiceSystem.PresentationLayer.InvoiceDetail;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;
using ServiveceSystem.PresentationLayer;
using ServiveceSystem.PresentationLayer.Clinic;
using ServiveceSystem.PresentationLayer.ContactPerson;
using ServiveceSystem.PresentationLayer.InvoiceDetail;
using ServiveceSystem.PresentationLayer.PaymentMethod;
using ServiveceSystem.PresentationLayer.QuotationHeader;
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
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2019 Black";
            var login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Home());
            }
            else
            {
                // Exit if login fails or canceled
                Application.Exit();
            }

            //Application.Run(new AddUser()
            // );  // ← your desired form here
        }

    }
}
