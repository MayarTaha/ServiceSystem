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
using DevExpress.Office.Services.Implementation;
using ServiceSystem.Models;
using ServiveceSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ServiveceSystem.BusinessLayer;

namespace ServiveceSystem.PresentationLayer.InvoiceHeader
{

    public partial class InvoiceHeaderProcessForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly AppDBContext _context;
        private readonly InvoiceHeaderService _invoiceService;
        private readonly InvoiceDetailService _invoiceDetailService;

        private int quotationId;
        private int serviceId;
        private int quantity;
        private decimal price;
        public InvoiceHeaderProcessForm(int qId, int sId, int qty, decimal p)
        {
            InitializeComponent();
            _context = new AppDBContext();
            _invoiceService = new InvoiceHeaderService(_context);
            _invoiceDetailService = new InvoiceDetailService(_context);
            quotationId = qId;
            serviceId = sId;
            quantity = qty;
            price = p;
            //clinic 
            ClinicNamelookUpEdit.Properties.DataSource = _context.Clinics.ToList();
            ClinicNamelookUpEdit.Properties.DisplayMember = "ClinicName"; // اللي هيتعرض
            ClinicNamelookUpEdit.Properties.ValueMember = "ClinicId"; // اللي هيتخزن
            //contact
            ContactNamelookUpEdit.Properties.DataSource = _context.ContactPersons.ToList();
            ContactNamelookUpEdit.Properties.DisplayMember = "ContactPersonName";
            ContactNamelookUpEdit.Properties.ValueMember = "ContactId";
            // paymentmethod
            paymentmethodlookUpEdit.Properties.DataSource = _context.PaymentMethods.ToList();
            paymentmethodlookUpEdit.Properties.DisplayMember = "PaymentType";
            paymentmethodlookUpEdit.Properties.ValueMember = "PaymentMethodId";
            // discount 
            var discountTypes = Enum.GetValues(typeof(Discount))
                .Cast<Discount>()
                .Select(d => new { Value = (int)d, Name = d.ToString() })
                .ToList();

            DiscountTypelookUpEdit.Properties.DataSource = discountTypes;
            DiscountTypelookUpEdit.Properties.DisplayMember = "Name";
            DiscountTypelookUpEdit.Properties.ValueMember = "Value";



        }

        private async void AddInvoiceButton_Click(object sender, EventArgs e)
        {
            var selectedClinicName = Convert.ToInt32(ClinicNamelookUpEdit.EditValue);
            var selectedPaymentMethodId = Convert.ToInt32(paymentmethodlookUpEdit.EditValue);
            var selectedContactId = Convert.ToInt32(ContactNamelookUpEdit.EditValue);
            var paid = Convert.ToDecimal(paidtextEdit.Text);
            var discountValue = Convert.ToDecimal(DiscounttextEdit.Text);
            var discountType = (Discount)Convert.ToInt32(DiscountTypelookUpEdit.EditValue);


            // 1. أضف الـ InvoiceHeader
            var invoice = new ServiceSystem.Models.InvoiceHeader
            {
                QuotationId = quotationId,
                InvoiceDate = DateTime.Now.ToShortDateString(),
                TotalPrice = quantity * price - discountValue,
                Payment = paid,
                PaymentMethodId = selectedPaymentMethodId,
                ContactId = selectedContactId,
                Reminder = "تمت الإضافة",
                CreatedLog = $"system - {DateTime.Now}",
                UpdatedLog = $" {DateTime.Now}",
                DeletedLog = "", // ✅ مهم علشان ما يحصلش error
                isDeleted = false
            };

            // _ = _invoiceService.AddInvoiceHeader(invoice);
            var success = await _invoiceService.AddInvoiceHeader(invoice);
            if (!success)
            {
                MessageBox.Show("فشل حفظ الفاتورة. تحقق من صحة البيانات");
                return;
            }


            //_context.SaveChanges();

            // 2. أضف الـ InvoiceDetail
            var detail = new ServiceSystem.Models.InvoiceDetail
            {
                QuotationId = quotationId,
                ServiceId = serviceId,
                Quantity = quantity,
                Discount = discountValue,
                DiscountType = discountType,
                ServicePrice = price,
                TotalService = price * quantity - discountValue,
                TotalDuo = price * quantity - discountValue,
                //CreatedLog = $"{DateTime.Now}",
                UpdatedLog = $" {DateTime.Now}",
              
                DeletedLog = "", // ✅ مهم علشان ما يحصلش error
                CreatedLog = $"system - {DateTime.Now}",
                isDeleted = false
            };
            var added = await _invoiceDetailService.AddInvoiceDetail(detail);
            if (added)
                MessageBox.Show("تمت الإضافة بنجاح");
            else
                MessageBox.Show("فشل حفظ تفاصيل الفاتورة");

            //_invoiceDetailService.AddInvoiceDetail(detail);
            // _context.SaveChanges();

//            MessageBox.Show("تمت إضافة الفاتورة بنجاح");
//#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
//            ((AddInvoiceHeader)Application.OpenForms["AddInvoiceHeader"]).RefreshGrid(); // لو فيه Grid
//#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            this.Close();


        }
    }
}