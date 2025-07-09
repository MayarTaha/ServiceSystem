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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ServiveceSystem.PresentationLayer.PaymentMethod
{
    public partial class AddPaymentForm : Form
    {
        public AddPaymentForm()
        {
            InitializeComponent();
            PaymentStatuscomboBox.DataSource = Enum.GetValues(typeof(PaymentStatus));
            using (var context = new AppDBContext())
            {
                var paymentMethods = context.PaymentMethods
                    .Select(pm => new
                    {
                        pm.PaymentMethodId,
                        pm.PaymentType
                    })
                    .ToList();

                PaymentMethodcomboBox.DataSource = paymentMethods;
                PaymentMethodcomboBox.DisplayMember = "PaymentType";
                PaymentMethodcomboBox.ValueMember = "PaymentMethodId";
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
