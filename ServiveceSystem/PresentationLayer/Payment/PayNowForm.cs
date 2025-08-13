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

            // Load payment methods
            try
            {
                using (var context = new AppDBContext())
                {
                    var methods = context.PaymentMethods
                        .Select(pm => new { pm.PaymentMethodId, pm.PaymentType })
                        .ToList();
                    dxLookUpPaymentMethod.Properties.DataSource = methods;
                    dxLookUpPaymentMethod.EditValue = methods.FirstOrDefault()?.PaymentMethodId;
                }
            }
            catch {  }
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
                using (var context = new AppDBContext())
                {
                    int paymentMethodId = 0;
                    if (dxLookUpPaymentMethod.EditValue != null && int.TryParse(dxLookUpPaymentMethod.EditValue.ToString(), out var selectedId))
                    {
                        paymentMethodId = selectedId;
                    }
                    else
                    {
                        var invoice = context.invoiceHeaders.FirstOrDefault(i => i.InvoiceHeaderId == _invoiceId);
                        if (invoice != null && invoice.PaymentMethodId > 0)
                        {
                            paymentMethodId = invoice.PaymentMethodId;
                        }
                        else
                        {
                            var defaultMethod = context.PaymentMethods.FirstOrDefault();
                            if (defaultMethod == null)
                            {
                                throw new InvalidOperationException("No payment methods defined. Please add a payment method first.");
                            }
                            paymentMethodId = defaultMethod.PaymentMethodId;
                        }
                    }

                    // Create payment record
                    var payment = new ServiceSystem.Models.Payment
                    {
                        InvoiceId = _invoiceId,
                        AmountPaid = amountToPay,
                        RemainingAmount = newRemainder,
                        PaymentDate = DateTime.Now,
                        PaymentMethodId = paymentMethodId,
                        PaymentStatus = newRemainder == 0 ? PaymentStatus.Completed : PaymentStatus.Partial,
                        CreatedLog = DateTime.Now.ToString(),
                        UpdatedLog = DateTime.Now.ToString(),
                        DeletedLog = string.Empty,
                        isDeleted = false
                    };

                    context.payments.Add(payment);
                    await context.SaveChangesAsync();
                }

                PaymentCompleted?.Invoke(this, new PaymentCompletedEventArgs(_invoiceId, newRemainder));
                XtraMessageBox.Show("Payment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error while saving payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}