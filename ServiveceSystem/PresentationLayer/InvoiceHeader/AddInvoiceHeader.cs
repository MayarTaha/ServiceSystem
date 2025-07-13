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
using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;
using DevExpress.CodeParser;
using ServiveceSystem.BusinessLayer;

namespace ServiveceSystem.PresentationLayer.InvoiceHeader
{
    public partial class AddInvoiceHeader : DevExpress.XtraEditors.XtraForm
    {
       
        private readonly AppDBContext _context;
        private readonly InvoiceHeaderService _invoiceHeaderService;

        private int hiddenQuotationId;
        private int selectedServiceId;
        private int enteredQuantity;
        private decimal enteredPrice;







        public AddInvoiceHeader()
        {
            InitializeComponent();
            _context = new AppDBContext();
            _invoiceHeaderService = new InvoiceHeaderService(_context);

            LoadServices();



        }

        private void editFormUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void LoadServices()
        {
            var services = _context.Services
                .Where(s => !s.isDeleted)
                .Select(s => new { s.ServiceId, s.Name }) // فقط القيم المهمة
                .ToList();

            ServicelookUpEdit.Properties.DataSource = services;
            ServicelookUpEdit.Properties.DisplayMember = "Name";
            ServicelookUpEdit.Properties.ValueMember = "ServiceId";
            ServicelookUpEdit.Properties.NullText = "Select Service";
        }

        //private void ServicelookUpEdit_EditValueChanged(object sender, EventArgs e)
        //{
        //    int? serviceId = ServicelookUpEdit.EditValue as int?;

        //    if (serviceId != null)
        //    {
        //        var quotationId = _context.InvoiceDetails
        //            .Include(i => i.QuotationHeader)
        //            .Where(i => i.ServiceId == serviceId)
        //            .OrderByDescending(i => i.QuotationHeader.InitialDate)
        //            .Select(i => i.QuotationId)
        //            .FirstOrDefault();

        //        // تحفظي الـ QuotationId في متغير مثلاً
        //        hiddenQuotationId = quotationId; // متغير private في الكلاس

        //        // أو لو حابة تعرضيه في TextEdit مخفي:
        //        txtQuotationId.Text = quotationId.ToString();
        //        txtQuotationId.Visible = false;
        //    }
        //}

        private void ServicelookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (ServicelookUpEdit.EditValue is int serviceId)
            {
                selectedServiceId = serviceId;

                var quotationId = _context.InvoiceDetails
                    .Include(i => i.QuotationHeader)
                    .Where(i => i.ServiceId == serviceId)
                    .OrderByDescending(i => i.QuotationHeader.InitialDate)
                    .Select(i => i.QuotationId)
                    .FirstOrDefault();

                hiddenQuotationId = quotationId;
                txtQuotationId.Text = quotationId.ToString();
                txtQuotationId.Visible = false;
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            //int quantity = int.Parse(QuantitytextEdit.Text);
            //decimal price = decimal.Parse(ServicePricetextEdit.Text);

            //// ممكن تبعتيهم للفورم الجديدة كمستوى متغيرات
            //var ProcessForm = new InvoiceHeaderProcessForm(hiddenQuotationId, ServicelookUpEdit.EditValue, quantity, price);
            //ProcessForm.Show();


            if (!int.TryParse(QuantitytextEdit.Text, out enteredQuantity))
            {
                MessageBox.Show("برجاء إدخال رقم صحيح في الكمية.");
                return;
            }

            if (!decimal.TryParse(ServicePricetextEdit.Text, out enteredPrice))
            {
                MessageBox.Show("برجاء إدخال سعر صحيح.");
                return;
            }
            if (hiddenQuotationId == 0)
            {
                MessageBox.Show("لا يمكن المتابعة بدون تحديد عرض أسعار صالح.");
                return;
            }

            // افتحي الفورم التانية وابعتي البيانات ليها
            var processForm = new InvoiceHeaderProcessForm(hiddenQuotationId, selectedServiceId, enteredQuantity, enteredPrice);
            processForm.Show();


        }

        public void RefreshGrid()
        {
            InvoicegridControl.DataSource = _context.invoiceHeaders
                .Include(i => i.QuotationHeader)
                .Include(i => i.PaymentMethod)
                .Include(i => i.Contact)
                 .Where(i => !i.isDeleted)
                .ToList();
        }

    }
}