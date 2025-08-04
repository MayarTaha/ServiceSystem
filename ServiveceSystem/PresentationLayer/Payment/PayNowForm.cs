using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ServiceSystem.Models;
using ServiveceSystem.Models;

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

        private async void DxBtnPay_Click(object sender, EventArgs e)
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

            try
            {
                using (var context = new ServiveceSystem.Models.AppDBContext())
                {
                                         // Get default payment method (first available)
                     var defaultPaymentMethod = context.PaymentMethods.FirstOrDefault();
                     int paymentMethodId = defaultPaymentMethod?.PaymentMethodId ?? 1;
                     
                     // Create new payment record
                     var payment = new ServiceSystem.Models.Payment
                     {
                         InvoiceId = _invoiceId,
                         AmountPaid = amountToPay,
                         RemainingAmount = newRemainder,
                         PaymentDate = DateTime.Now,
                         PaymentMethodId = paymentMethodId,
                         PaymentStatus = newRemainder == 0 ? ServiceSystem.Models.PaymentStatus.Completed : ServiceSystem.Models.PaymentStatus.Partial,
                         CreatedLog = DateTime.Now.ToString(),
                         UpdatedLog = DateTime.Now.ToString(),
                         DeletedLog = "",
                         isDeleted = false
                     };

                                         context.payments.Add(payment);

                     // Note: We don't update InvoiceHeader.Payment or InvoiceHeader.Reminder
                     // Payment history is maintained in Payment records
                     // Each payment record shows the state at that time

                     await context.SaveChangesAsync();
                }

                PaymentCompleted?.Invoke(this, new PaymentCompletedEventArgs(_invoiceId, newRemainder));
                XtraMessageBox.Show("Payment processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error processing payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 