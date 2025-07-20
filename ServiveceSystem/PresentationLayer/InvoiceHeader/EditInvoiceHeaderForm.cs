using ServiceSystem.Models;
using ServiveceSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiveceSystem.PresentationLayer.InvoiceHeader
{
    public partial class EditInvoiceHeaderForm: Form
    {
        public EditInvoiceHeaderForm()
        {
            //InitializeComponent();
            //PaymentMethodcomboBox.DataSource = Enum.GetValues(typeof(PaymentStatus));
            using (var context = new AppDBContext())
            {
                var paymentMethods = context.PaymentMethods
                    .Select(pm => new
                    {
                        pm.PaymentMethodId,
                        pm.PaymentType
                    })
                    .ToList();

                //PaymentMethodcomboBox.DataSource = paymentMethods;
                //PaymentMethodcomboBox.DisplayMember = "PaymentType"; 
                //PaymentMethodcomboBox.ValueMember = "PaymentMethodId";     
            }

        }
    }
}
