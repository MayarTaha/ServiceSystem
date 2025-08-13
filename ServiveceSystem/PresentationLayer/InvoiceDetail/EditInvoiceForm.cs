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
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;
using ServiceSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ServiceSystem.PresentationLayer.InvoiceDetail
{
    public partial class EditInvoiceForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly AppDBContext _context;
        private readonly InvoiceHeaderService _invoiceHeaderService;
        private readonly InvoiceDetailService _invoiceDetailService;
        private BindingList<ServiceSystem.Models.InvoiceDetail> invoiceDetailsList = new BindingList<ServiceSystem.Models.InvoiceDetail>();
        private int _invoiceHeaderId;
        private ServiceSystem.Models.InvoiceDetail _editingDetail = null;

        public EditInvoiceForm(int invoiceHeaderId)
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
            _context = new AppDBContext();
            _invoiceHeaderService = new InvoiceHeaderService(_context);
            _invoiceDetailService = new InvoiceDetailService(_context);
            _invoiceHeaderId = invoiceHeaderId;
            noterichTextBox.BackColor = this.BackColor;
            noterichTextBox.ForeColor = Color.White;
            // Reminder field is now editable
            LoadLookUps();
            LoadInvoiceData();
            SetupGrid();
            SetupEvents();
        }

        private void LoadLookUps()
        {
            // Discount Type Detail
            comboBoxDiscountTypeDetail.Properties.Items.Clear();
            comboBoxDiscountTypeDetail.Properties.Items.AddRange(Enum.GetValues(typeof(Discount)));
            comboBoxDiscountTypeDetail.EditValue = Discount.NotSelected;

            // Discount Type Header
            comboBoxDiscountType.Properties.Items.Clear();
            comboBoxDiscountType.Properties.Items.AddRange(Enum.GetValues(typeof(Discount)));
            comboBoxDiscountType.EditValue = Discount.NotSelected;

            // Invoice Status
            comboBoxStatus.Properties.Items.Clear();
            comboBoxStatus.Properties.Items.AddRange(Enum.GetValues(typeof(InvoiceStatus)));
            //salesman
            salesmanlookUpEdit.Properties.DataSource = _context.SalesMen.Where(c => !c.isDeleted).ToList();
            salesmanlookUpEdit.Properties.DisplayMember = "SalesManName";
            salesmanlookUpEdit.Properties.ValueMember = "SalesManId";
            salesmanlookUpEdit.Properties.Columns.Clear();
            salesmanlookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalesManName", "SalesMan Name"));

            // Services
            serviceLookUpEdit.Properties.DataSource = _context.Services.Where(s => !s.isDeleted).ToList();
            serviceLookUpEdit.Properties.DisplayMember = "Name";
            serviceLookUpEdit.Properties.ValueMember = "ServiceId";
            serviceLookUpEdit.Properties.Columns.Clear();
            serviceLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Service Name"));

            // Clinics
            clinicLookUpEdit.Properties.DataSource = _context.Clinics.Where(c => !c.isDeleted).ToList();
            clinicLookUpEdit.Properties.DisplayMember = "ClinicName";
            clinicLookUpEdit.Properties.ValueMember = "ClinicId";
            clinicLookUpEdit.Properties.Columns.Clear();
            clinicLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClinicName", "Clinic Name"));

            // Contact Persons - will be filtered based on selected clinic
            contactLookUpEdit.Properties.DisplayMember = "ContactName";
            contactLookUpEdit.Properties.ValueMember = "ContactId";
            contactLookUpEdit.Properties.Columns.Clear();
            contactLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "Contact Name"));

            // Payment Methods
            paymentmethodlookupedit.Properties.DataSource = _context.PaymentMethods.ToList();
            paymentmethodlookupedit.Properties.DisplayMember = "PaymentType";
            paymentmethodlookupedit.Properties.ValueMember = "PaymentMethodId";
            paymentmethodlookupedit.Properties.Columns.Clear();
            paymentmethodlookupedit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentType", "Payment Method"));

            // Quotations
            quotationLookUpEdit.Properties.DataSource = _context.QuotationHeaders.Where(q => !q.isDeleted).ToList();
            quotationLookUpEdit.Properties.DisplayMember = "QuotationNaMe";
            quotationLookUpEdit.Properties.ValueMember = "QuotationId";
            quotationLookUpEdit.Properties.Columns.Clear();
            quotationLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuotationNaMe", "Quotation Name"));

            // Taxes
            checkedListBoxControltax.DataSource = _context.Taxeses.Where(t => !t.isDeleted).ToList();
            checkedListBoxControltax.DisplayMember = "Name";
            checkedListBoxControltax.ValueMember = "TaxesID";
        }

        private void LoadInvoiceData()
        {
            var header = _context.Set<InvoiceHeader>()
                .Include(i => i.QuotationHeader)
                .ThenInclude(q => q.Clinic)
                .Include(i => i.Contact)
                .ThenInclude(c => c.Clinic)
                .Include(i => i.PaymentMethod)
                .FirstOrDefault(i => i.InvoiceHeaderId == _invoiceHeaderId);

            if (header != null)
            {
                // Populate header controls
                quotationLookUpEdit.EditValue = header.QuotationId;
                invoiceDateEdit.DateTime = DateTime.TryParse(header.InvoiceDate, out var dt) ? dt : DateTime.Now;
                paymentmethodlookupedit.EditValue = header.PaymentMethodId;
                noterichTextBox.Text = header.Note;
                comboBoxStatus.EditValue = header.Status;
                comboBoxDiscountType.EditValue = header.DiscountType;
                Discounttextedit.Text = header.Discount.ToString("0.##");
                TotalPricetextEdit.Text = header.TotalPrice.ToString("0.##");
                PaymenttextEdit.Text = header.Payment.ToString("0.##");
                reminderTextEdit.Text = header.Reminder ?? ""; // Load existing reminder value

                // Set clinic and contact based on quotation
                if (header.QuotationHeader != null)
                {
                    clinicLookUpEdit.EditValue = header.QuotationHeader.ClinicId;

                    // Load clinic data
                    if (header.QuotationHeader.ClinicId > 0)
                    {
                        var clinic = _context.Clinics.FirstOrDefault(c => c.ClinicId == header.QuotationHeader.ClinicId);
                        if (clinic != null)
                        {
                            locationTextEdit.Text = clinic.Location;
                            emailTextEdit.Text = clinic.Email;
                            phoneTextEdit.Text = clinic.Phone;
                        }

                        // Set contact data source based on selected clinic
                        var contacts = _context.ContactPersons.Where(cp => cp.ClinicId == header.QuotationHeader.ClinicId && !cp.isDeleted).ToList();
                        contactLookUpEdit.Properties.DataSource = contacts;
                    }
                }

                contactLookUpEdit.EditValue = header.ContactId;

                // Load selected taxes - direct relationship
                if (header.Taxes != null)
                {
                    for (int i = 0; i < checkedListBoxControltax.ItemCount; i++)
                    {
                        var tax = checkedListBoxControltax.GetItem(i) as Taxes;
                        if (tax != null && header.Taxes.Any(t => t.TaxesID == tax.TaxesID))
                        {
                            checkedListBoxControltax.SetItemChecked(i, true);
                        }
                    }
                }
            }

            // Load details
            var details = _context.InvoiceDetails
                .Include(d => d.Service)
                .Where(d => d.InvoiceHeaderId == _invoiceHeaderId && !d.isDeleted)
                .ToList();

            invoiceDetailsList = new BindingList<ServiceSystem.Models.InvoiceDetail>(details);
            gridcontrolDetails.DataSource = invoiceDetailsList;

            // Set TotaltextEdit to match TotalPricetextEdit (both show the same total)
            TotaltextEdit.Text = TotalPricetextEdit.Text;

            // Calculate payment balance based on loaded values
            CalculatePaymentBalance();
        }

        private void SetupGrid()
        {
            gridViewdet.OptionsBehavior.Editable = false;
            gridViewdet.Columns.Clear();

            // Service column with lookup to show service name
            var serviceColumn = gridViewdet.Columns.AddVisible("ServiceId", "Service");
            var serviceLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            serviceLookUp.DataSource = _context.Services.Where(s => !s.isDeleted).ToList();
            serviceLookUp.DisplayMember = "Name";
            serviceLookUp.ValueMember = "ServiceId";
            serviceColumn.ColumnEdit = serviceLookUp;

            gridViewdet.Columns.AddVisible("Quantity", "Quantity");
            gridViewdet.Columns.AddVisible("ServicePrice", "Service Price");
            gridViewdet.Columns.AddVisible("DiscountType", "Discount Type");
            gridViewdet.Columns.AddVisible("Discount", "Discount");
            gridViewdet.Columns.AddVisible("TotalService", "Total");
        }

        private void SetupEvents()
        {
            gridViewdet.CellValueChanged += (s, e) => UpdateGrandTotal();
            gridViewdet.RowCountChanged += (s, e) => UpdateGrandTotal();
            gridViewdet.RowClick += gridViewdet_RowClick;
            SetupGroupBoxEvents();
            SetupHeaderEvents();
        }

        private void SetupHeaderEvents()
        {
            // Clinic change - filter contacts and fill clinic data
            clinicLookUpEdit.EditValueChanged += (s, e) =>
            {
                if (clinicLookUpEdit.EditValue != null)
                {
                    int clinicId = Convert.ToInt32(clinicLookUpEdit.EditValue);

                    // Get clinic data
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

                    // Auto-select first contact if available
                    if (contacts.Count > 0)
                    {
                        contactLookUpEdit.EditValue = contacts.First().ContactId;
                    }
                    else
                    {
                        contactLookUpEdit.EditValue = null;
                    }
                }
                else
                {
                    contactLookUpEdit.Properties.DataSource = null;
                    contactLookUpEdit.EditValue = null;
                    emailTextEdit.Text = "";
                    phoneTextEdit.Text = "";
                    locationTextEdit.Text = "";
                }
            };

            // Header discount type change
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
                    Discounttextedit.Text = ""; // Clear text so user can type
                    Discounttextedit.Enabled = true;
                }
                CalculateHeaderTotal();
            };

            // Header discount value change
            Discounttextedit.EditValueChanged += (s, e) => CalculateHeaderTotal();

            // Payment change
            PaymenttextEdit.EditValueChanged += (s, e) => CalculatePaymentBalance();

            // Taxes change
            checkedListBoxControltax.ItemCheck += (s, e) => CalculateHeaderTotal();
        }

        private void SetupGroupBoxEvents()
        {
            quantityTextEdit.EditValueChanged += (s, e) => CalculateTotalService();
            textEditDiscountDetail.EditValueChanged += (s, e) => CalculateTotalService();
            textEditServicePrice.EditValueChanged += (s, e) => CalculateTotalService();

            // Service detail discount type change
            comboBoxDiscountTypeDetail.SelectedIndexChanged += (s, e) =>
            {
                if (comboBoxDiscountTypeDetail.EditValue == null)
                    return;

                var selected = (Discount)comboBoxDiscountTypeDetail.EditValue;
                if (selected == Discount.NotSelected)
                {
                    textEditDiscountDetail.Text = "0";
                    textEditDiscountDetail.Enabled = false;
                }
                else
                {
                    textEditDiscountDetail.Text = ""; // Clear text so user can type
                    textEditDiscountDetail.Enabled = true;
                }
                CalculateTotalService();
            };

            serviceLookUpEdit.EditValueChanged += (s, e) =>
            {
                if (serviceLookUpEdit.EditValue != null)
                {
                    int serviceId = Convert.ToInt32(serviceLookUpEdit.EditValue);
                    var service = _context.Services.FirstOrDefault(sv => sv.ServiceId == serviceId);
                    if (service != null)
                    {
                        textEditServicePrice.Text = service.ServicePrice.ToString("0.##");
                    }
                }
                CalculateTotalService();
            };
        }

        private void UpdateGrandTotal()
        {
            CalculateHeaderTotal();
        }

        private void CalculateHeaderTotal()
        {
            // Calculate subtotal from all services
            decimal subtotal = 0;
            foreach (var item in invoiceDetailsList)
            {
                subtotal += item.TotalService;
            }

            // Apply header-level discount
            decimal discount = decimal.TryParse(Discounttextedit.Text, out var d) ? d : 0;
            var discountType = comboBoxDiscountType.EditValue != null ? (Discount)comboBoxDiscountType.EditValue : Discount.NotSelected;

            decimal total = subtotal;
            if (discountType == Discount.Percentage)
                total -= total * (discount / 100m);
            else if (discountType == Discount.Value)
                total -= discount;

            // Add taxes
            decimal taxTotal = 0;
            for (int i = 0; i < checkedListBoxControltax.ItemCount; i++)
            {
                if (checkedListBoxControltax.GetItemChecked(i))
                {
                    var tax = checkedListBoxControltax.GetItem(i) as Taxes;
                    if (tax != null)
                    {
                        taxTotal += total * (tax.TaxRate / 100m);
                    }
                }
            }
            total += taxTotal;

            TotalPricetextEdit.Text = total.ToString("0.##");
            TotaltextEdit.Text = total.ToString("0.##");
            CalculatePaymentBalance();
        }

        private void CalculatePaymentBalance()
        {
            decimal total = decimal.TryParse(TotalPricetextEdit.Text, out var t) ? t : 0;
            decimal payment = decimal.TryParse(PaymenttextEdit.Text, out var p) ? p : 0;
            decimal balance = total - payment;

            // Always update reminder when payment changes
            reminderTextEdit.Text = balance.ToString("0.##");
        }

        private void CalculateTotalService()
        {
            decimal price = decimal.TryParse(textEditServicePrice.Text, out var p) ? p : 0;
            int qty = int.TryParse(quantityTextEdit.Text, out var q) ? q : 0;
            decimal discount = decimal.TryParse(textEditDiscountDetail.Text, out var d) ? d : 0;
            var discountType = comboBoxDiscountTypeDetail.EditValue != null ? (Discount)comboBoxDiscountTypeDetail.EditValue : Discount.NotSelected;

            decimal total = price * qty;
            if (discountType == Discount.Percentage)
                total -= total * (discount / 100m);
            else if (discountType == Discount.Value)
                total -= discount;

            totalServiceTextEdit.Text = total.ToString("0.##");
        }

        private void gridViewdet_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                _editingDetail = invoiceDetailsList[e.RowHandle];
                // Populate group box fields
                serviceLookUpEdit.EditValue = _editingDetail.ServiceId;
                quantityTextEdit.Text = _editingDetail.Quantity.ToString();
                textEditServicePrice.Text = _editingDetail.ServicePrice.ToString("0.##");
                comboBoxDiscountTypeDetail.EditValue = _editingDetail.DiscountType;
                textEditDiscountDetail.Text = _editingDetail.Discount.ToString("0.##");
                totalServiceTextEdit.Text = _editingDetail.TotalService.ToString("0.##");
                btnSubmit.Text = "Update";
            }
        }



        private async void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (invoiceDetailsList.Count == 0)
                {
                    XtraMessageBox.Show("Please add at least one service before continuing.");
                    return;
                }

                // Update header
                var header = _context.Set<InvoiceHeader>().FirstOrDefault(i => i.InvoiceHeaderId == _invoiceHeaderId);
                if (header != null)
                {
                    header.QuotationId = Convert.ToInt32(quotationLookUpEdit.EditValue);
                    header.InvoiceDate = invoiceDateEdit.DateTime.ToString("yyyy-MM-dd");
                    header.PaymentMethodId = Convert.ToInt32(paymentmethodlookupedit.EditValue);
                    header.Reminder = reminderTextEdit.Text; // Save the edited reminder value
                    header.Note = noterichTextBox.Text;
                    header.SalesManId = Convert.ToInt32(salesmanlookUpEdit.EditValue);
                    header.Status = (InvoiceStatus)comboBoxStatus.EditValue;
                    header.DiscountType = (Discount)comboBoxDiscountType.EditValue;
                    header.Discount = decimal.TryParse(Discounttextedit.Text, out var d) ? d : 0;
                    header.TotalPrice = decimal.TryParse(TotalPricetextEdit.Text, out var t) ? t : 0;
                    header.Payment = decimal.TryParse(PaymenttextEdit.Text, out var p) ? p : 0;
                    header.ContactId = Convert.ToInt32(contactLookUpEdit.EditValue);
                    header.UpdatedLog = DateTime.Now.ToString();

                    _invoiceHeaderService.Update(header);
                }

                // Update details
                foreach (var detail in invoiceDetailsList)
                {
                    if (detail.InvoiceDetailId == 0) // New detail
                    {
                        detail.InvoiceHeaderId = _invoiceHeaderId;
                        detail.CreatedLog = DateTime.Now.ToString();
                        detail.UpdatedLog = DateTime.Now.ToString();
                        detail.DeletedLog = "";
                        detail.isDeleted = false;
                        await _invoiceDetailService.AddInvoiceDetail(detail);
                    }
                    else
                    {
                        // Update existing detail
                        _invoiceDetailService.Update(detail);
                    }
                }

                await _context.SaveChangesAsync();

                XtraMessageBox.Show("Invoice updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error updating invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditInvoiceForm_Load(object sender, EventArgs e)
        {

            // Center all row text
            gridViewdet.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            // Center header text
            gridViewdet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }
    }
}