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

        public InvoicePayment(List<ServiceSystem.Models.InvoiceDetail> invoiceDetails, decimal total)
        {
            InitializeComponent();
            _context = new AppDBContext();
            _invoiceDetails = invoiceDetails;
            _total = total;
            _finalTotal = _total;
            _invoiceHeaderService = new InvoiceHeaderService(_context);
            _invoiceDetailService = new InvoiceDetailService(_context);
            LoadLookUps();
            TotalPricetextEdit.Text = _total.ToString("0.##");
            CalculateTotalWithDiscount();
        }
        private void LoadLookUps()
        {
            //paymentmethodlookupedit.Properties.DataSource = _context.PaymentMethods.ToList();
            //paymentmethodlookupedit.Properties.DisplayMember = "PaymentType";
            //paymentmethodlookupedit.Properties.ValueMember = "PaymentMethodId";
            // ... تحميل بيانات أخرى ...

            clinicLookUpEdit.Properties.DataSource = _context.Clinics.Where(c => !c.isDeleted).ToList();
            clinicLookUpEdit.Properties.DisplayMember = "ClinicName";
            clinicLookUpEdit.Properties.ValueMember = "ClinicId";
            clinicLookUpEdit.Properties.Columns.Clear();
            clinicLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClinicName", "ClinicId"));
            // 2. الأشخاص (سيتم تعبئتها عند اختيار العيادة)
            contactLookUpEdit.Properties.DataSource = null;
            contactLookUpEdit.Properties.Columns.Clear();
            contactLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "Contact Name"));

            // 3. العروض (Quotation)
            quotationLookUpEdit.Properties.DataSource = _context.QuotationHeaders.Where(q => !q.isDeleted).ToList();
            quotationLookUpEdit.Properties.DisplayMember = "Note"; // أو أي خاصية تريد عرضها
            quotationLookUpEdit.Properties.ValueMember = "QuotationId";
            quotationLookUpEdit.Properties.Columns.Clear();
            quotationLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuotationNaMe", "Quotation"));

            // 4. طرق الدفع
            paymentmethodlookupedit.Properties.DataSource = _context.PaymentMethods.ToList();
            paymentmethodlookupedit.Properties.DisplayMember = "PaymentType";
            paymentmethodlookupedit.Properties.ValueMember = "PaymentMethodId";
            paymentmethodlookupedit.Properties.Columns.Clear();
            paymentmethodlookupedit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentType", "Payment Method"));
            // 5. نوع الخصم
            comboBoxDiscountType.Properties.Items.Clear();
            comboBoxDiscountType.Properties.Items.AddRange(Enum.GetValues(typeof(Discount)));
        }

        private void Payment_Enter(object sender, EventArgs e)
        {

        }

        private void lookUpClinic_EditValueChanged(object sender, EventArgs e)
        {
            if (clinicLookUpEdit.EditValue == null) return;
            int clinicId = Convert.ToInt32(clinicLookUpEdit.EditValue);
            var clinic = _context.Clinics.FirstOrDefault(c => c.ClinicId == clinicId);
            if (clinic != null)
            {
                phoneTextEdit.Text = clinic.Phone;
                emailTextEdit.Text = clinic.Email;
                locationTextEdit.Text = clinic.Location;

                // جلب الأشخاص المرتبطين بالعيادة
                var contacts = _context.ContactPersons.Where(cp => cp.ClinicId == clinicId).ToList();
                contactLookUpEdit.Properties.DataSource = contacts;
                contactLookUpEdit.Properties.DisplayMember = "ContactName";
                contactLookUpEdit.Properties.ValueMember = "ContactId";
            }
        }

        private void lookUpQuotation_EditValueChanged(object sender, EventArgs e)
        {
            if (quotationLookUpEdit.EditValue == null) return;
            int quotationId = Convert.ToInt32(quotationLookUpEdit.EditValue);
            var quotation = _context.QuotationHeaders.FirstOrDefault(q => q.QuotationId == quotationId);
            if (quotation != null)
            {
                // مثال: عرض الاسم في TextBox أو Label
                //quotationNameTextEdit.Text = quotation.Note; // أو أي خاصية أخرى
            }
        }

        private void comboBoxDiscountType_SelectedIndexChanged(object sender, EventArgs e)
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
            var discountType = comboBoxDiscountType.EditValue != null ? (Discount)comboBoxDiscountType.EditValue : Discount.NotSelected;
            decimal total = _total;
            if (discountType == Discount.Percentage)
                total -= total * (discount / 100m);
            else if (discountType == Discount.Value)
                total -= discount;
            _finalTotal = total; // خزّن القيمة النهائية هنا

            TotalPricetextEdit.Text = _finalTotal.ToString("0.##");
            CalculateReminder();
        }

        private async void savebutton_Click(object sender, EventArgs e)
        {
            var header = new InvoiceHeader
            {
                QuotationId = Convert.ToInt32(quotationLookUpEdit.EditValue),
                InvoiceDate = invoiceDateEdit.DateTime.ToString("yyyy-MM-dd"),
                PaymentMethodId = Convert.ToInt32(paymentmethodlookupedit.EditValue),
                Reminder = reminderTextEdit.Text,
                Note = noterichTextBox.Text,
                ContactId = Convert.ToInt32(contactLookUpEdit.EditValue),
                CreatedLog = DateTime.Now.ToString(),
                UpdatedLog = DateTime.Now.ToString(),
                DeletedLog = "",
                isDeleted = false
            };
            //await _invoiceHeaderService.AddInvoiceHeader(header);
            var headerAdded = await _invoiceHeaderService.AddInvoiceHeader(header);
            if (!headerAdded)
            {
                XtraMessageBox.Show("Failed to add invoice header.");
                return;
            }

            // 2. أضف InvoiceDetails
            foreach (var detail in _invoiceDetails)
            {
                detail.InvoiceHeaderId = header.InvoiceHeaderId;
                detail.QuotationId = header.QuotationId;
                detail.CreatedLog = DateTime.Now.ToString();
                detail.UpdatedLog = DateTime.Now.ToString();
                detail.DeletedLog = "";
                detail.isDeleted = false;
                await _invoiceDetailService.AddInvoiceDetail(detail);
            }

            // 3. أظهر الفاتورة في AllInvoices (يمكنك عمل تحديث للـ DataGrid هناك)
            XtraMessageBox.Show("Invoice saved successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}