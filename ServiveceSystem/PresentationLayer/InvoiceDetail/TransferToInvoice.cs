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
using ServiveceSystem.Models;
using ServiceSystem.Models;
using ServiveceSystem.BusinessLayer;
using System.Reflection.PortableExecutable;

namespace ServiceSystem.PresentationLayer.InvoiceDetail
{
	public partial class TransferToInvoice: DevExpress.XtraEditors.XtraForm
	{
        private List<QuotationDetail> _details;
        public TransferToInvoice()
		{
            InitializeComponent();
		}

        public TransferToInvoice(int quotationId, int clinicId, int contactId, List<QuotationDetail> details, string quotationName)
        {
            InitializeComponent();
            _details = details;
            var context = new AppDBContext();
            // Set invoice date to current
            invoiceDateEdit.DateTime = DateTime.Now;
            // Populate clinic lookup
            var clinics = context.Clinics.Where(c => !c.isDeleted).ToList();
            clinicLookUpEdit.Properties.DataSource = clinics;
            clinicLookUpEdit.Properties.DisplayMember = "ClinicName";
            clinicLookUpEdit.Properties.ValueMember = "ClinicId";
            clinicLookUpEdit.Properties.Columns.Clear();
            clinicLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClinicName", "Clinic Name"));
            clinicLookUpEdit.EditValue = clinicId;
            // Populate contact lookup (filtered by clinic)
            var contacts = context.ContactPersons.Where(cp => cp.ClinicId == clinicId).ToList();
            contactLookUpEdit.Properties.DataSource = contacts;
            contactLookUpEdit.Properties.DisplayMember = "ContactName";
            contactLookUpEdit.Properties.ValueMember = "ContactId";
            contactLookUpEdit.Properties.Columns.Clear();
            contactLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "Contact Name"));
            //salesman

            // Quotation lookup
            quotationLookUpEdit.EditValue = quotationId;
            if (quotationLookUpEdit.Properties.DataSource == null)
            {
                quotationLookUpEdit.Properties.DataSource = new[] { new { QuotationId = quotationId, QuotationNaMe = quotationName } };
                quotationLookUpEdit.Properties.DisplayMember = "QuotationNaMe";
                quotationLookUpEdit.Properties.ValueMember = "QuotationId";
            }
            quotationLookUpEdit.Properties.Columns.Clear();
            quotationLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuotationNaMe", "Quotation Name"));
            // Fill grid with details
            gridcontrolDetails.DataSource = _details.Select(d => new {
                d.ServiceId,
                ServiceName = d.Service?.Name,
                d.Quantity,
                d.ServicePrice,
                d.Discount,
                d.DiscountType,
                d.TotalService
            }).ToList();
            gridViewdet.OptionsBehavior.Editable = false;

            // Fill phone, email, location for the selected clinic
            var selectedClinic = clinics.FirstOrDefault(c => c.ClinicId == clinicId);
            if (selectedClinic != null)
            {
                phoneTextEdit.Text = selectedClinic.Phone;
                emailTextEdit.Text = selectedClinic.Email;
                locationTextEdit.Text = selectedClinic.Location;
            }

            // Add event handler for clinic change
            clinicLookUpEdit.EditValueChanged += (s, e) =>
            {
                if (clinicLookUpEdit.EditValue == null) return;
                int selectedId = Convert.ToInt32(clinicLookUpEdit.EditValue);
                var clinic = clinics.FirstOrDefault(c => c.ClinicId == selectedId);
                if (clinic != null)
                {
                    phoneTextEdit.Text = clinic.Phone;
                    emailTextEdit.Text = clinic.Email;
                    locationTextEdit.Text = clinic.Location;
                }
                // Update contacts for the selected clinic
                var newContacts = context.ContactPersons.Where(cp => cp.ClinicId == selectedId).ToList();
                contactLookUpEdit.Properties.DataSource = newContacts;
                contactLookUpEdit.Properties.DisplayMember = "ContactName";
                contactLookUpEdit.Properties.ValueMember = "ContactId";
                contactLookUpEdit.Properties.Columns.Clear();
                contactLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "Contact Name"));
                contactLookUpEdit.EditValue = newContacts.FirstOrDefault()?.ContactId;
            };

            // --- Payment GroupBox Logic ---
            // Payment Methods
            paymentmethodlookupedit.Properties.DataSource = context.PaymentMethods.ToList();
            paymentmethodlookupedit.Properties.DisplayMember = "PaymentType";
            paymentmethodlookupedit.Properties.ValueMember = "PaymentMethodId";
            paymentmethodlookupedit.Properties.Columns.Clear();
            paymentmethodlookupedit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentType", "Payment Method"));
            //salesman
            salesmanlookUpEdit.Properties.DataSource = context.SalesMen.Where(c => !c.isDeleted).ToList();
            salesmanlookUpEdit.Properties.DisplayMember = "SalesManName";
            salesmanlookUpEdit.Properties.ValueMember = "SalesManId";
            salesmanlookUpEdit.Properties.Columns.Clear();
            salesmanlookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalesManName", "SalesMan Name"));


            // Discount Type
            comboBoxDiscountType.Properties.Items.Clear();
            comboBoxDiscountType.Properties.Items.AddRange(Enum.GetValues(typeof(Discount)));
            comboBoxDiscountType.EditValue = Discount.NotSelected;

            // Status
            comboBoxStatus.Properties.Items.Clear();
            comboBoxStatus.Properties.Items.AddRange(Enum.GetValues(typeof(InvoiceStatus)));
            comboBoxStatus.EditValue = InvoiceStatus.Pending;

            // Taxes
            checkedListBoxControltax.Items.Clear();
            var taxes = context.Taxeses.Where(t => !t.isDeleted).ToList();
            foreach (var tax in taxes)
            {
                checkedListBoxControltax.Items.Add($"{tax.Name} ({tax.TaxRate}%)");
            }
            // Event handlers for payment logic
            checkedListBoxControltax.ItemCheck += (s, e) => CalculateTotalWithDiscount();
            PaymenttextEdit.EditValueChanged += (s, e) => CalculateReminder();
            Discounttextedit.EditValueChanged += (s, e) => CalculateTotalWithDiscount();
            comboBoxDiscountType.SelectedIndexChanged += (s, e) =>
            {
                if (comboBoxDiscountType.EditValue == null)
                    return;
                var selected = (Discount)comboBoxDiscountType.EditValue;
                if (selected == Discount.NotSelected)
                {
                    Discounttextedit.Text = "0";
                    Discounttextedit.Enabled = false;
                }
                else
                {
                    Discounttextedit.Enabled = true;
                }
                CalculateTotalWithDiscount();
            };
            // Set initial values
            decimal total = _details.Sum(d => d.TotalService);
            TotalPricetextEdit.Text = total.ToString("0.##");
            _finalTotal = total;
            CalculateTotalWithDiscount();
            // Set noterichTextBox color to match form
            noterichTextBox.BackColor = this.BackColor;
            noterichTextBox.ForeColor = System.Drawing.Color.White;
            // Ensure discount is zero and disabled if NotSelected on load
            if (comboBoxDiscountType.EditValue == null || (Discount)comboBoxDiscountType.EditValue == Discount.NotSelected)
            {
                Discounttextedit.Text = "0";
                Discounttextedit.Enabled = false;
            }
            savebutton.Click += savebutton_Click;
        }

        private async void savebutton_Click(object sender, EventArgs e)
        {
            var context = new AppDBContext();
            var invoiceHeaderService = new InvoiceHeaderService(context);
            var invoiceDetailService = new InvoiceDetailService(context);
            var _paymentService = new PaymentService(context);
            decimal totalPrice = decimal.TryParse(TotalPricetextEdit.Text, out var t) ? t : 0;
            decimal payment = decimal.TryParse(PaymenttextEdit.Text, out var p) ? p : 0;
            decimal discount = decimal.TryParse(Discounttextedit.Text, out var d) ? d : 0;
            var header = new InvoiceHeader
            {
                QuotationId = Convert.ToInt32(quotationLookUpEdit.EditValue),
                InvoiceDate = invoiceDateEdit.DateTime.ToString("yyyy-MM-dd"),
                PaymentMethodId = Convert.ToInt32(paymentmethodlookupedit.EditValue),
                Reminder = reminderTextEdit.Text,
                Note = noterichTextBox.Text,
                ContactId = Convert.ToInt32(contactLookUpEdit.EditValue),
                Status = (InvoiceStatus)comboBoxStatus.EditValue,
                DiscountType = (Discount)comboBoxDiscountType.EditValue,
                SalesManId = Convert.ToInt32(salesmanlookUpEdit.EditValue),
                Discount = discount,
                TotalPrice = totalPrice,
                Payment = payment,
                CreatedLog = DateTime.Now.ToString(),
                UpdatedLog = DateTime.Now.ToString(),
                DeletedLog = "",
                isDeleted = false
            };
            var headerAdded = await invoiceHeaderService.AddInvoiceHeader(header);
            if (!headerAdded)
            {
                XtraMessageBox.Show("Failed to add invoice header.");
                return;
            }
            // Add InvoiceDetails (map from QuotationDetail)
            foreach (var qDetail in _details)
            {
                var invoiceDetail = new ServiceSystem.Models.InvoiceDetail
                {
                    InvoiceHeaderId = header.InvoiceHeaderId,
                    QuotationId = header.QuotationId,
                    ServiceId = qDetail.ServiceId,
                    Quantity = qDetail.Quantity,
                    Discount = qDetail.Discount,
                    DiscountType = qDetail.DiscountType,
                    ServicePrice = qDetail.ServicePrice,
                    TotalService = qDetail.TotalService,
                    CreatedLog = DateTime.Now.ToString(),
                    UpdatedLog = DateTime.Now.ToString(),
                    DeletedLog = "",
                    isDeleted = false
                };
                await invoiceDetailService.AddInvoiceDetail(invoiceDetail);
            }
            // ✅ Add Payment
            var newPayment = new Payment
            {
                InvoiceId = header.InvoiceHeaderId,
                AmountPaid = payment, // from PaymenttextEdit
                RemainingAmount = decimal.TryParse(reminderTextEdit.Text, out var rem) ? rem : 0, // from reminder
                PaymentDate = invoiceDateEdit.DateTime, // start date = invoice date
                PaymentMethodId = header.PaymentMethodId,
                PaymentStatus = PaymentStatus.Pending, // using invoice status enum
                CreatedLog = DateTime.Now.ToString(),
                UpdatedLog = DateTime.Now.ToString(),
                DeletedLog = "",
                isDeleted = false
            };

            await _paymentService.AddPayment(newPayment);
            XtraMessageBox.Show("Invoice saved successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private decimal _finalTotal;
        private void CalculateReminder()
        {
            decimal payment = 0;
            decimal.TryParse(PaymenttextEdit.Text, out payment);
            decimal reminder = _finalTotal - payment;
            reminderTextEdit.Text = reminder.ToString("0.##");
        }
        private void CalculateTotalWithDiscount()
        {
            decimal discount = decimal.TryParse(Discounttextedit.Text, out var d) ? d : 0;
            var discountType = comboBoxDiscountType.EditValue != null ? (Discount)comboBoxDiscountType.EditValue : Discount.NotSelected;
            decimal total = _details.Sum(d => d.TotalService);
            if (discountType == Discount.Percentage)
                total -= total * (discount / 100m);
            else if (discountType == Discount.Value)
                total -= discount;
            // Add taxes
            var context = new AppDBContext();
            decimal totalTax = 0;
            var taxes = context.Taxeses.Where(t => !t.isDeleted).ToList();
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
    }
}