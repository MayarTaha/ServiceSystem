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
using Microsoft.EntityFrameworkCore;


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
        private int? _editQuotationHeaderId = null;

        public QuotationForm(List<ServiceSystem.Models.QuotationDetail> quotationDetails, decimal total)
        {
            InitializeComponent();
            noteRichTextBox.BackColor = this.BackColor;
            noteRichTextBox.ForeColor = Color.White;
            initialDateEdit.DateTime = DateTime.Now;
            expireDateEdit.DateTime = DateTime.Now.AddMonths(1);
            _context = new AppDBContext();
            _quotationHeaderService = new QuotationHeaderService(_context);
            _quotationDetailService = new QuotationDetailService(_context);
            _quotationDetails = quotationDetails;
            _total = total;
            _finalTotal = _total;
            LoadLookUps();
            checkedListBoxControltax.ItemCheck += (s, e) => CalculateTotalWithDiscount();
        }

        public QuotationForm(int quotationHeaderId)
        {
            InitializeComponent();
            _editQuotationHeaderId = quotationHeaderId;
            _context = new AppDBContext();
            _quotationHeaderService = new QuotationHeaderService(_context);
            _quotationDetailService = new QuotationDetailService(_context);
            // Load header and details
            var header = _context.QuotationHeaders.FirstOrDefault(q => q.QuotationId == quotationHeaderId);
            if (header != null)
            {
                clinicLookUpEdit.EditValue = header.ClinicId;
                initialDateEdit.DateTime = header.InitialDate;
                expireDateEdit.DateTime = header.ExpireDate;
                noteRichTextBox.Text = header.Note;
                quotationNameTextEdit.Text = header.QuotationNaMe;
                comboBoxStatus.EditValue = header.Status;
                prioritycomboBoxEdit.EditValue = header.priority;
                comboBoxDiscountType.EditValue = header.DiscountType;
                textEditDiscountHeader.Text = header.Discount.ToString();
                totaltextEdit.Text = header.TotalDuo.ToString();
                contactLookUpEdit.EditValue = header.ContactId;
                // Load taxes, etc. as needed
            }
            // Load details
            _quotationDetails = _context.QuotationDetails.Where(d => d.QuotationId == quotationHeaderId && !d.isDeleted).ToList();
            _total = _quotationDetails.Sum(d => d.TotalService);
            _finalTotal = _total;
            LoadLookUps();
            checkedListBoxControltax.ItemCheck += (s, e) => CalculateTotalWithDiscount();
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

            //salesman
            salesmanlookUpEdit.Properties.DataSource = _context.SalesMen.Where(c => !c.isDeleted).ToList();
            salesmanlookUpEdit.Properties.DisplayMember = "SalesManName";
            salesmanlookUpEdit.Properties.ValueMember = "SalesManId";
            salesmanlookUpEdit.Properties.Columns.Clear();
            salesmanlookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalesManName", "SalesMan Name"));

            // 5. نوع الخصم
            comboBoxDiscountType.Properties.Items.Clear();
            comboBoxDiscountType.Properties.Items.AddRange(Enum.GetValues(typeof(Discount)));
            comboBoxDiscountType.EditValue = Discount.NotSelected;

            //Status
            comboBoxStatus.Properties.Items.Clear();
            comboBoxStatus.Properties.Items.AddRange(Enum.GetValues(typeof(QuotationStatus)));
            comboBoxStatus.EditValue = QuotationStatus.Pending;

            //priority
            prioritycomboBoxEdit.Properties.Items.Clear();
            prioritycomboBoxEdit.Properties.Items.AddRange(Enum.GetValues(typeof(priorityStatus)));
            prioritycomboBoxEdit.EditValue = priorityStatus.LowLevel;

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
            var newHeader = new ServiceSystem.Models.QuotationHeader
            {
                ClinicId = Convert.ToInt32(clinicLookUpEdit.EditValue),
                InitialDate = initialDateEdit.DateTime,
                ExpireDate = expireDateEdit.DateTime,
                Note = noteRichTextBox.Text,
                QuotationNaMe = quotationNameTextEdit.Text,
                //SalesManId = Convert.ToInt32(salesmanlookUpEdit.EditValue),
                SalesManId = salesmanlookUpEdit.EditValue == null
    ? (int?)null
    : Convert.ToInt32(salesmanlookUpEdit.EditValue),
                Status = (QuotationStatus)comboBoxStatus.EditValue,
                priority = (priorityStatus)prioritycomboBoxEdit.EditValue,
                DiscountType = (Discount)comboBoxDiscountType.EditValue,
                Discount = decimal.TryParse(textEditDiscountHeader.Text, out var d2) ? d2 : 0,
                TotalDuo = decimal.TryParse(totaltextEdit.Text, out var t2) ? t2 : 0,
                ContactId = Convert.ToInt32(contactLookUpEdit.EditValue),
                CreatedLog = DateTime.Now.ToString(),
                UpdatedLog = DateTime.Now.ToString(),
                DeletedLog = "",
                isDeleted = false
            };

            // Add Taxes to the new quotation
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
            if (!ValidateQuotationForm())
                return;
            // 2. أضف QuotationHeader أولاً
            var headerAdded = await _quotationHeaderService.AddQuotationHeader(newHeader);
            if (!headerAdded)
            {
                XtraMessageBox.Show("Failed to add quotation header.");
                return;
            }

            // 3. أضف QuotationDetails مع ربطها بالـ QuotationId الجديد
            foreach (var detail in _quotationDetails)
            {
                detail.QuotationId = newHeader.QuotationId;
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
        private bool ValidateQuotationForm()
        {
            // Clinic required
            if (clinicLookUpEdit.EditValue == null)
            {
                XtraMessageBox.Show("Please select a clinic.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Initial Date required
            if (initialDateEdit.EditValue == null)
            {
                XtraMessageBox.Show("Please select an initial date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Expire Date required
            if (expireDateEdit.EditValue == null)
            {
                XtraMessageBox.Show("Please select an expire date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Quotation name required
            if (string.IsNullOrWhiteSpace(quotationNameTextEdit.Text))
            {
                XtraMessageBox.Show("Please enter a quotation name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //// Salesman required
            //if (salesmanlookUpEdit.EditValue == null)
            //{
            //    XtraMessageBox.Show("Please select a salesman.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            // Status required
            if (comboBoxStatus.EditValue == null)
            {
                XtraMessageBox.Show("Please select a quotation status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Priority required
            if (prioritycomboBoxEdit.EditValue == null)
            {
                XtraMessageBox.Show("Please select a priority.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Discount type required
            if (comboBoxDiscountType.EditValue == null)
            {
                XtraMessageBox.Show("Please select a discount type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Contact required
            if (contactLookUpEdit.EditValue == null)
            {
                XtraMessageBox.Show("Please select a contact.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // At least one detail required
            if (_quotationDetails == null || !_quotationDetails.Any())
            {
                XtraMessageBox.Show("Please add at least one service to the quotation.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}