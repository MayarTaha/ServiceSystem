using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;

namespace ServiveceSystem.PresentationLayer
{
    public partial class Home : XtraForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ShowFormInPanel(Form form)
        {
            mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void accordionControl_ElementClick(object sender, ElementClickEventArgs e)
        {
            switch (e.Element.Name)
            {
                case "servicesElement":
                    ShowFormInPanel(new Service.AllServices());
                    break;
                case "clinicsElement":
                    ShowFormInPanel(new Clinic.AllClinics());
                    break;
                case "contactsElement":
                    ShowFormInPanel(new ContactPerson.AllContactPersons());
                    break;
                case "quotationsElement":
                    // ShowFormInPanel(new Quotation.AllQuotations()); // Uncomment when available
                    break;
                case "invoicesElement":
                    // ShowFormInPanel(new InvoiceHeader.AllInvoices()); // Uncomment when available
                    break;
                case "usersElement":
                    ShowFormInPanel(new User.AllUsers());
                    break;
                case "paymentsElement":
                    ShowFormInPanel(new Payment.AllPayments());
                    break;
                case "taxesElement":
                    ShowFormInPanel(new Taxes.AllTaxes());
                    break;
                case "paymentMethodsElement":
                    ShowFormInPanel(new PaymentMethod.AllPaymentMethods());
                    break;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void accordionControl_Click(object sender, EventArgs e)
        {

        }
    }
} 