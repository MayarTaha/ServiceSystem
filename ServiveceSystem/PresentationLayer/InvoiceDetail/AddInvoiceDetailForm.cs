using ServiceSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiveceSystem.PresentationLayer.InvoiceDetail
{
    public partial class AddInvoiceDetailForm: Form
    {
        public AddInvoiceDetailForm()
        {
            InitializeComponent();
            DiscountTypecomboBox.DataSource = Enum.GetValues(typeof(Discount));
        }
    }
}
