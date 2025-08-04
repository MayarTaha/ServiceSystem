using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ServiveceSystem.PresentationLayer.Payment
{
    public partial class PayNowForm : XtraForm
    {
        public event EventHandler<PaymentCompletedEventArgs> PaymentCompleted;
        private int _invoiceId;
        private decimal _remainder;

        public PayNowForm(int invoiceId, decimal remainder)
        {
            _invoiceId = invoiceId;
            _remainder = remainder;
            InitializeComponent();
            // Set initial values
            dxLblInvoiceId.Text = _invoiceId.ToString();
            dxLblCurrentRemainder.Text = _remainder.ToString("F2");
            dxLblNewRemainder.Text = _remainder.ToString("F2");
            dxTxtAmountToPay.TextChanged += DxTxtAmountToPay_TextChanged;
            dxBtnPay.Click += DxBtnPay_Click;
        }

        private void DxTxtAmountToPay_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(dxTxtAmountToPay.Text, out var amountToPay))
            {
                var newRemainder = _remainder - amountToPay;
                if (newRemainder < 0) newRemainder = 0;
                dxLblNewRemainder.Text = newRemainder.ToString("F2");
            }
            else
            {
                dxLblNewRemainder.Text = _remainder.ToString("F2");
            }
        }

        private void DxBtnPay_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(dxTxtAmountToPay.Text, out var amountToPay) || amountToPay <= 0)
            {
                XtraMessageBox.Show("Please enter a valid amount to pay.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var newRemainder = _remainder - amountToPay;
            if (newRemainder < 0)
            {
                XtraMessageBox.Show("Amount to pay cannot exceed the current remainder.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PaymentCompleted?.Invoke(this, new PaymentCompletedEventArgs(_invoiceId, newRemainder));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}