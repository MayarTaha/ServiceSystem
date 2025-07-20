using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.PaymentMethod
{
    public partial class AddPaymentMethod : XtraForm
    {
        private readonly PaymentMethodService _service;
        public AddPaymentMethod()
        {
            InitializeComponent();
            _service = new PaymentMethodService(new AppDBContext());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaymentType.Text))
            {
                XtraMessageBox.Show("Payment type is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaymentType.Focus();
                return;
            }
            var method = new ServiveceSystem.Models.PaymentMethod { PaymentType = txtPaymentType.Text.Trim() };
            _service.AddPaymentMethod(method);
            XtraMessageBox.Show("Payment method added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
} 