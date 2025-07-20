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
using ServiveceSystem.BusinessLayer;
using ServiceSystem.Models;

namespace ServiceSystem.PresentationLayer.Quotation
{
    public partial class QuotationForm : DevExpress.XtraEditors.XtraForm
    {
        private AppDBContext _context;
        private List<ServiceSystem.Models.QuotationDetail> _quotationDetails;
        private decimal _total;
        private decimal _finalTotal;
        private readonly QuotationDetailService _quotationDetailService;
        private QuotationHeaderService _quotationHeaderService;

        public QuotationForm(List<ServiceSystem.Models.QuotationDetail> quotationDetails, decimal total)
        {
            InitializeComponent();
            _context = new AppDBContext();
            _quotationHeaderService = new QuotationHeaderService(_context);
            _quotationDetailService = new QuotationDetailService(_context);
            _quotationDetails = quotationDetails;
            _total = total;
            _finalTotal = _total;
            LoadLookUps();
        }

        private void LoadLookUps()
        {


            clinicLookUpEdit.Properties.DataSource = _context.Clinics.Where(c => !c.isDeleted).ToList();
            clinicLookUpEdit.Properties.DisplayMember = "ClinicName";
            clinicLookUpEdit.Properties.ValueMember = "ClinicId";
            clinicLookUpEdit.Properties.Columns.Clear();
            clinicLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClinicName", "ClinicId"));
            // 2. الأشخاص (سيتم تعبئتها عند اختيار العيادة)
            contactLookUpEdit.Properties.DataSource = null;
            contactLookUpEdit.Properties.Columns.Clear();
            contactLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "Contact Name"));


            // 5. نوع الخصم
            comboBoxDiscountType.Properties.Items.Clear();
            comboBoxDiscountType.Properties.Items.AddRange(Enum.GetValues(typeof(Discount)));

            //Status
            comboBoxStatus.Properties.Items.Clear();
            comboBoxStatus.Properties.Items.AddRange(Enum.GetValues(typeof(QuotationStatus)));

            //priority
            prioritycomboBoxEdit.Properties.Items.Clear();
            prioritycomboBoxEdit.Properties.Items.AddRange(Enum.GetValues(typeof(priorityStatus)));
        }

        private void clinicLookUpEdit_EditValueChanged(object sender, EventArgs e)
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


        private void CalculateTotalWithDiscount()
        {
            decimal discount = decimal.TryParse(textEditDiscountHeader.Text, out var d) ? d : 0;
            var discountType = comboBoxDiscountType.EditValue != null ? (Discount)comboBoxDiscountType.EditValue : Discount.NotSelected;
            decimal total = _total;
            if (discountType == Discount.Percentage)
                total -= total * (discount / 100m);
            else if (discountType == Discount.Value)
                total -= discount;
            _finalTotal = total; // خزّن القيمة النهائية هنا

            totaltextEdit.Text = _finalTotal.ToString("0.##");

        }

        private void comboBoxDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDiscountType.EditValue == null)
                return;

            var selected = (Discount)comboBoxDiscountType.EditValue;
            if (selected == Discount.NotSelected)
            {
                textEditDiscountHeader.Text = "0";
                textEditDiscountHeader.Enabled = false;
            }
            else
            {
                textEditDiscountHeader.Enabled = true;
            }
            CalculateTotalWithDiscount();
        }

        private void textEditDiscountHeader_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalWithDiscount();
        }

        private async void savebutton_Click(object sender, EventArgs e)
        {
           
            // 1. أنشئ QuotationHeader
            var header = new ServiceSystem.Models.QuotationHeader
            {
                ClinicId = Convert.ToInt32(clinicLookUpEdit.EditValue),
                InitialDate = initialDateEdit.DateTime,
                ExpireDate = expireDateEdit.DateTime,
                Note = noteRichTextBox.Text,
                QuotationNaMe = quotationNameTextEdit.Text,
                Status = (QuotationStatus)comboBoxStatus.EditValue,
                priority = (priorityStatus)prioritycomboBoxEdit.EditValue,
                DiscountType = (Discount)comboBoxDiscountType.EditValue,
                Discount = decimal.TryParse(textEditDiscountHeader.Text, out var d) ? d : 0,
                TotalDuo = decimal.TryParse(totaltextEdit.Text, out var t) ? t : 0,
                ContactId = Convert.ToInt32(contactLookUpEdit.EditValue),
                CreatedLog = DateTime.Now.ToString(),
                UpdatedLog = DateTime.Now.ToString(),
                DeletedLog = "",
                isDeleted = false
            };

            // 2. أضف QuotationHeader أولاً
            var headerAdded = await _quotationHeaderService.AddQuotationHeader(header);
            if (!headerAdded)
            {
                XtraMessageBox.Show("Failed to add quotation header.");
                return;
            }

            // 3. أضف QuotationDetails مع ربطها بالـ QuotationId الجديد
            foreach (var detail in _quotationDetails)
            {
                detail.QuotationId = header.QuotationId;
                detail.CreatedLog = DateTime.Now.ToString();
                detail.UpdatedLog = DateTime.Now.ToString();
                detail.DeletedLog = "";
                detail.isDeleted = false;
                await _quotationDetailService.AddQuotationDetails(detail);
            }

            XtraMessageBox.Show("Quotation saved successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        




    }
    }
}