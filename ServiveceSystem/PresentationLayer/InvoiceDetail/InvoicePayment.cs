using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ServiceSystem.Models;
using ServiveceSystem.Models;
using ServiveceSystem.BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace ServiceSystem.PresentationLayer.InvoiceDetail
{
    public partial class InvoicePayment : DevExpress.XtraEditors.XtraForm
    {
        private AppDBContext _context;
        private List<ServiceSystem.Models.InvoiceDetail> _invoiceDetails;
        private decimal _total;
        private decimal _finalTotal;
        private InvoiceHeaderService _invoiceHeaderService;
        private InvoiceDetailService _invoiceDetailService;
        private  PaymentService _paymentService;


        public InvoicePayment(List<ServiceSystem.Models.InvoiceDetail> invoiceDetails, decimal total)
        {
            InitializeComponent();
            PaymenttextEdit.KeyPress += PaymenttextEdit_KeyPress;
            invoiceDateEdit.DateTime = DateTime.Now;
            noterichTextBox.BackColor = this.BackColor;
            noterichTextBox.ForeColor = Color.White;
            reminderTextEdit.Properties.ReadOnly = true;
            _context = new AppDBContext();
            _invoiceDetails = invoiceDetails;
            _total = total;
            _finalTotal = _total;
            _invoiceHeaderService = new InvoiceHeaderService(_context);
            _invoiceDetailService = new InvoiceDetailService(_context);
            _paymentService = new PaymentService(_context);
            LoadLookUps();
            TotalPricetextEdit.Text = _total.ToString("0.##");
                        checkedListBoxControltax.ItemCheck += (s, e) => CalculateTotalWithDiscount();
            PaymenttextEdit.EditValueChanged += PaymenttextEdit_EditValueChanged;
            //taxes
            checkedListBoxControltax.ItemCheck += (s, e) => CalculateTotalWithDiscount();


            // Wire up the payment discount type change event
            comboBoxPaymentDiscountType.SelectedIndexChanged += comboBoxPaymentDiscountType_SelectedIndexChanged;
            
            // Wire up the discount value change event
            Discounttextedit.EditValueChanged += Discounttextedit_EditValueChanged;
            
            // Initialize discount field properly
            Discounttextedit.Text = "0";
            Discounttextedit.Enabled = false;
            
            CalculateTotalWithDiscount();

        }

        private void LoadLookUps()
        {
            

            clinicLookUpEdit.Properties.DataSource = _context.Clinics.Where(c => !c.isDeleted).ToList();
            clinicLookUpEdit.Properties.DisplayMember = "ClinicName";
            clinicLookUpEdit.Properties.ValueMember = "ClinicId";
            clinicLookUpEdit.Properties.Columns.Clear();
            clinicLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClinicName", "Clinic Name"));




            lookUpEditSalesMan.Properties.DataSource = _context.SalesMen.Where(c => !c.isDeleted).ToList();
            lookUpEditSalesMan.Properties.DisplayMember = "SalesManName";
            lookUpEditSalesMan.Properties.ValueMember = "SalesManId";
            lookUpEditSalesMan.Properties.Columns.Clear();
            lookUpEditSalesMan.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalesManName", "SalesMan Name"));


            contactLookUpEdit.Properties.DataSource = _context.ContactPersons.Where(cp => !cp.isDeleted).ToList();
            contactLookUpEdit.Properties.DisplayMember = "ContactName";
            contactLookUpEdit.Properties.ValueMember = "ContactId";
            contactLookUpEdit.Properties.Columns.Clear();
            contactLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "Contact Name"));

            quotationLookUpEdit.Properties.DataSource = _context.QuotationHeaders.Where(q => !q.isDeleted).ToList();
            quotationLookUpEdit.Properties.DisplayMember = "QuotationNaMe";
            quotationLookUpEdit.Properties.ValueMember = "QuotationId";
            quotationLookUpEdit.Properties.Columns.Clear();
            quotationLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuotationNaMe", "Quotation Name"));

            paymentmethodlookupedit.Properties.DataSource = _context.PaymentMethods.ToList();
            paymentmethodlookupedit.Properties.DisplayMember = "PaymentType";
            paymentmethodlookupedit.Properties.ValueMember = "PaymentMethodId";
            paymentmethodlookupedit.Properties.Columns.Clear();
            paymentmethodlookupedit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentType", "Payment Method"));

            comboBoxStatus.Properties.Items.Clear();
            comboBoxStatus.Properties.Items.AddRange(Enum.GetValues(typeof(InvoiceStatus)));
            comboBoxStatus.EditValue = InvoiceStatus.Pending; // Default to Pending

            comboBoxPaymentDiscountType.Properties.Items.Clear();
            comboBoxPaymentDiscountType.Properties.Items.AddRange(Enum.GetValues(typeof(Discount)));
            comboBoxPaymentDiscountType.EditValue = Discount.NotSelected;

            // Taxes
            checkedListBoxControltax.Items.Clear();
            var taxes = _context.Taxeses.Where(t => !t.isDeleted).ToList();

            foreach (var tax in taxes)
            {


                checkedListBoxControltax.Items.Add(
                    new DevExpress.XtraEditors.Controls.CheckedListBoxItem(
                        value: tax.TaxesID,
                        description: $"{tax.Name} ({tax.TaxRate}%)",
                         false
                    )
                );
            }
        }

        private void Payment_Enter(object sender, EventArgs e)
        {
        }

        private void lookUpClinic_EditValueChanged(object sender, EventArgs e)
        {
            if (clinicLookUpEdit.EditValue != null)
            {
                int clinicId = Convert.ToInt32(clinicLookUpEdit.EditValue);

                // Get clinic data and fill location, email, phone
                var clinic = _context.Clinics.FirstOrDefault(c => c.ClinicId == clinicId);
                if (clinic != null)
                {
                    locationTextEdit.Text = clinic.Location;
                    emailTextEdit.Text = clinic.Email;
                    phoneTextEdit.Text = clinic.Phone;
                }

                // Filter contacts for this clinic
                var contacts = _context.ContactPersons.Where(cp => cp.ClinicId == clinicId && !cp.isDeleted).ToList();
                contactLookUpEdit.Properties.DataSource = contacts;
                contactLookUpEdit.EditValue = null;
            }
            else
            {
                contactLookUpEdit.Properties.DataSource = null;
                contactLookUpEdit.EditValue = null;
                locationTextEdit.Text = "";
                emailTextEdit.Text = "";
                phoneTextEdit.Text = "";
            }
        }

        private void lookUpQuotation_EditValueChanged(object sender, EventArgs e)
        {
            if (quotationLookUpEdit.EditValue != null)
            {
                int quotationId = Convert.ToInt32(quotationLookUpEdit.EditValue);
                var quotation = _context.QuotationHeaders.FirstOrDefault(q => q.QuotationId == quotationId);
                if (quotation != null)
                {
                    clinicLookUpEdit.EditValue = quotation.ClinicId;
                }
            }
        }

        private void comboBoxDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void comboBoxPaymentDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPaymentDiscountType.EditValue == null)
                return;

            var selected = (Discount)comboBoxPaymentDiscountType.EditValue;
            if (selected == Discount.NotSelected)
            {
                Discounttextedit.Text = "0";
                Discounttextedit.Enabled = false;
            }
            else
            {
                Discounttextedit.Text = "";
                Discounttextedit.Enabled = true;
            }
            CalculateTotalWithDiscount();
        }

        private void PaymenttextEdit_EditValueChanged(object sender, EventArgs e)
        {
            CalculateReminder();
        }

        private void Discounttextedit_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalWithDiscount();
        }

        private void CalculateReminder()
        {
            decimal payment = decimal.TryParse(PaymenttextEdit.Text, out var p) ? p : 0;
            decimal reminder = _finalTotal - payment;
            reminderTextEdit.Text = reminder.ToString("0.##");
        }

        private void CalculateTotalWithDiscount()
        {
            decimal discount = decimal.TryParse(Discounttextedit.Text, out var d) ? d : 0;
            var discountType = comboBoxPaymentDiscountType.EditValue != null ? (Discount)comboBoxPaymentDiscountType.EditValue : Discount.NotSelected;
            decimal total = _total;
            if (discountType == Discount.Percentage)
                total -= total * (discount / 100m);
            else if (discountType == Discount.Value)
                total -= discount;

            // Add taxes
            decimal totalTax = 0;
            var taxes = _context.Taxeses.Where(t => !t.isDeleted).ToList();
            foreach (var checkedItem in checkedListBoxControltax.CheckedItems)
            {
                string itemStr = checkedItem.ToString();
                var tax = taxes.FirstOrDefault(t => itemStr.StartsWith(t.Name + " ("));
                if (tax != null)
                {
                    totalTax += total * (tax.TaxRate / 100m);
                }
            }
            _finalTotal = total + totalTax;
            TotalPricetextEdit.Text = _finalTotal.ToString("0.##");
            CalculateReminder();
        }

        private async void savebutton_Click(object sender, EventArgs e)
        {
            // Get values from form fields
            decimal totalPrice = decimal.TryParse(TotalPricetextEdit.Text, out var t) ? t : 0;
            decimal payment = decimal.TryParse(PaymenttextEdit.Text, out var p) ? p : 0;
            decimal discount = decimal.TryParse(Discounttextedit.Text, out var d) ? d : 0;

            var newHeader = new InvoiceHeader
            {
                // QuotationId = Convert.ToInt32(quotationLookUpEdit.EditValue),
                QuotationId = quotationLookUpEdit.EditValue == null
    ? (int?)null
    : Convert.ToInt32(quotationLookUpEdit.EditValue),
                InvoiceDate = invoiceDateEdit.DateTime.ToString("yyyy-MM-dd"),
                PaymentMethodId = Convert.ToInt32(paymentmethodlookupedit.EditValue),
                Reminder = reminderTextEdit.Text,
                Note = noterichTextBox.Text,
                ClinicId = Convert.ToInt32(clinicLookUpEdit.EditValue),
                ContactId = Convert.ToInt32(contactLookUpEdit.EditValue),
                SalesManId = lookUpEditSalesMan.EditValue == null
    ? (int?)null
    : Convert.ToInt32(lookUpEditSalesMan.EditValue),
              //  SalesManId = Convert.ToInt32(lookUpEditSalesMan.EditValue),
                Status = (InvoiceStatus)comboBoxStatus.EditValue,
                DiscountType = (Discount)comboBoxPaymentDiscountType.EditValue,
                Discount = discount,
                TotalPrice = totalPrice,
                Payment = payment,
                CreatedLog = DateTime.Now.ToString(),
                UpdatedLog = DateTime.Now.ToString(),
                DeletedLog = "",
                isDeleted = false
            };
            newHeader.Taxes = new List<ServiceSystem.Models.Taxes>();


            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem checkedItem in checkedListBoxControltax.CheckedItems)
            {
                int taxId = (int)checkedItem.Value;
                var tax = await _context.Taxeses.FirstOrDefaultAsync(tx => tx.TaxesID == taxId);
                if (tax != null)
                {
                    newHeader.Taxes.Add(tax);
                }
            }
            if (!ValidateInvoiceForm())
                return;

            try
            {
                var headerAdded = await _invoiceHeaderService.AddInvoiceHeader(newHeader);
                //if (!headerAdded)
                //{
                //    XtraMessageBox.Show("Failed to add invoice header.");
                //    return;
                //}
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show($"Failed to add invoice header: {ex.Message}");
               // return;
            }


            // Add InvoiceDetails
            foreach (var detail in _invoiceDetails)
            {
                detail.InvoiceHeaderId = newHeader.InvoiceHeaderId;
                //  detail.QuotationId = newHeader.QuotationId;
                if(newHeader.QuotationId != null)
        detail.QuotationId = newHeader.QuotationId;
                detail.CreatedLog = DateTime.Now.ToString();
                detail.UpdatedLog = DateTime.Now.ToString();
                detail.DeletedLog = "";
                detail.isDeleted = false;
                await _invoiceDetailService.AddInvoiceDetail(detail);
            }

            //  Add Payment
            var newPayment = new Payment
            {
                InvoiceId = newHeader.InvoiceHeaderId,
                AmountPaid = payment, // from PaymenttextEdit
                RemainingAmount = decimal.TryParse(reminderTextEdit.Text, out var rem) ? rem : 0, // from reminder
                PaymentDate = invoiceDateEdit.DateTime, // start date = invoice date
                PaymentMethodId = newHeader.PaymentMethodId,
                PaymentStatus = PaymentStatus.Pending, // using invoice status enum
                CreatedLog = DateTime.Now.ToString(),
                UpdatedLog = DateTime.Now.ToString(),
                DeletedLog = "",
                isDeleted = false
            };

            await _paymentService.AddPayment(newPayment);


            // XtraMessageBox.Show("Invoice saved successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidateInvoiceForm()
        {
            // Quotation is optional (you already handled that) ✅

            // Clinic must be selected
            if (clinicLookUpEdit.EditValue == null)
            {
                XtraMessageBox.Show("Please select a clinic.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Contact must be selected
            if (contactLookUpEdit.EditValue == null)
            {
                XtraMessageBox.Show("Please select a contact person.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //// Salesman must be selected
            //if (lookUpEditSalesMan.EditValue == null)
            //{
            //    XtraMessageBox.Show("Please select a salesman.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            // Payment method must be selected
            if (paymentmethodlookupedit.EditValue == null)
            {
                XtraMessageBox.Show("Please select a payment method.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Status must be selected
            if (comboBoxStatus.EditValue == null)
            {
                XtraMessageBox.Show("Please select an invoice status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Discount type must be selected
            if (comboBoxPaymentDiscountType.EditValue == null)
            {
                XtraMessageBox.Show("Please select a discount type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Payment must be numeric and > 0
            if (!decimal.TryParse(PaymenttextEdit.Text, out var payment) || payment <= 0)
            {
                XtraMessageBox.Show("Please enter a valid payment amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Total Price must be numeric and > 0
            if (!decimal.TryParse(TotalPricetextEdit.Text, out var totalPrice) || totalPrice <= 0)
            {
                XtraMessageBox.Show("Please enter a valid total price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Must have at least one invoice detail
            if (_invoiceDetails == null || !_invoiceDetails.Any())
            {
                XtraMessageBox.Show("Please add at least one service to the invoice.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void PaymenttextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits
            if (char.IsDigit(e.KeyChar))
                return;

            // Allow only one decimal separator (.)
            if (e.KeyChar == '.' && !PaymenttextEdit.Text.Contains("."))
                return;

            // Otherwise block and show message
            e.Handled = true;
            XtraMessageBox.Show("Only decimal numbers are allowed in Payment.",
                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



    }
}