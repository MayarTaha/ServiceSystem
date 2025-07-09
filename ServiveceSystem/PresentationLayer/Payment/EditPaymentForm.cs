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

namespace ServiveceSystem.PresentationLayer.PaymentMethod
{
    public partial class EditPaymentForm : Form
    {
        public EditPaymentForm()
        {
            InitializeComponent();
            PaymentStatuscomboBox.DataSource = Enum.GetValues(typeof(PaymentStatus));
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
                PaymentMethodcomboBox.DisplayMember = "PaymentType"; // اللي يظهر للمستخدم
                PaymentMethodcomboBox.ValueMember = "PaymentMethodId";     // القيمة اللي ممكن نستخدمها
            }
        }

        private void EditPaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
