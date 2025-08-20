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
using DevExpress.XtraEditors.Controls;
using System.Reflection.PortableExecutable;

namespace ServiceSystem.PresentationLayer.Quotation
{
    public partial class EditQuotationForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly AppDBContext _context;
        private readonly QuotationHeaderService _quotationHeaderService;
        private readonly QuotationDetailService _quotationDetailService;
        private BindingList<ServiceSystem.Models.QuotationDetail> quotationDetailsList = new BindingList<ServiceSystem.Models.QuotationDetail>();
        private int _quotationHeaderId;
        private ServiceSystem.Models.QuotationDetail _editingDetail = null;

        public EditQuotationForm(int quotationHeaderId)
        {
            InitializeComponent();
            this.Size = new Size(870, 590);
            _context = new AppDBContext();
            _quotationHeaderService = new QuotationHeaderService(_context);
            _quotationDetailService = new QuotationDetailService(_context);
            _quotationHeaderId = quotationHeaderId;
            noteRichTextBox.BackColor = this.BackColor;
            noteRichTextBox.ForeColor = Color.White;
            LoadLookUps();
            LoadQuotationData();
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

            // Quotation Status
            comboBoxStatus.Properties.Items.Clear();
            comboBoxStatus.Properties.Items.AddRange(Enum.GetValues(typeof(QuotationStatus)));

            // Priority Status
            prioritycomboBoxEdit.Properties.Items.Clear();
            prioritycomboBoxEdit.Properties.Items.AddRange(Enum.GetValues(typeof(priorityStatus)));

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
            //salesman
            SalesManlookUpEdit.Properties.DataSource = _context.SalesMen.Where(c => !c.isDeleted).ToList();
            SalesManlookUpEdit.Properties.DisplayMember = "SalesManName";
            SalesManlookUpEdit.Properties.ValueMember = "SalesManId";
            SalesManlookUpEdit.Properties.Columns.Clear();
            SalesManlookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalesManName", "SalesMan Name"));

            // Contact Persons - will be filtered based on selected clinic
            contactLookUpEdit.Properties.DisplayMember = "ContactName";
            contactLookUpEdit.Properties.ValueMember = "ContactId";
            contactLookUpEdit.Properties.Columns.Clear();
            contactLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "Contact Name"));

            // Taxes
            //checkedListBoxControltax.DataSource = _context.Taxeses.Where(t => !t.isDeleted).ToList();
            //checkedListBoxControltax.DisplayMember = "Name";
            //checkedListBoxControltax.ValueMember = "TaxesID";
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

        private void LoadQuotationData()
        {
            var header = _context.QuotationHeaders
                .Include(q => q.Clinic)
                .Include(q => q.Contact)
                .ThenInclude(c => c.Clinic)
                .FirstOrDefault(q => q.QuotationId == _quotationHeaderId);

            if (header != null)
            {
                // Populate header controls
                clinicLookUpEdit.EditValue = header.ClinicId;

                // Set contact data source based on selected clinic
                if (header.ClinicId > 0)
                {
                    var contacts = _context.ContactPersons.Where(cp => cp.ClinicId == header.ClinicId && !cp.isDeleted).ToList();
                    contactLookUpEdit.Properties.DataSource = contacts;
                }

                initialDateEdit.DateTime = header.InitialDate;
                expireDateEdit.DateTime = header.ExpireDate;
                noteRichTextBox.Text = header.Note;
                SalesManlookUpEdit.EditValue = header.SalesManId;
                quotationNameTextEdit.Text = header.QuotationNaMe;
                comboBoxStatus.EditValue = header.Status;
                prioritycomboBoxEdit.EditValue = header.priority;
                comboBoxDiscountType.EditValue = header.DiscountType;
                textEditDiscountHeader.Text = header.Discount.ToString("0.##");
                TotaltextEdit.Text = header.TotalDuo.ToString("0.##");
                contactLookUpEdit.EditValue = header.ContactId;

                // Load contact details
                if (header.Contact != null)
                {
                    emailTextEdit.Text = header.Contact.ContactEmail;
                    phoneTextEdit.Text = header.Contact.ContactNumber;
                    // Get clinic location for the contact
                    if (header.Contact.Clinic != null)
                    {
                        locationTextEdit.Text = header.Contact.Clinic.Location;
                    }
                    else
                    {
                        locationTextEdit.Text = "";
                    }
                }

                if (header.Taxes != null)
                {
                    foreach (var qTax in header.Taxes)
                    {
                        for (int i = 0; i < checkedListBoxControltax.Items.Count; i++)
                        {
                            if (checkedListBoxControltax.Items[i] is CheckedListBoxItem item &&
                                (int)item.Value == qTax.TaxesID)
                            {
                                checkedListBoxControltax.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                }
            }

            // Load details
            var details = _context.QuotationDetails
                .Include(d => d.Service)
                .Where(d => d.QuotationId == _quotationHeaderId && !d.isDeleted)
                .ToList();

            quotationDetailsList = new BindingList<ServiceSystem.Models.QuotationDetail>(details);
            gridcontrolDetails.DataSource = quotationDetailsList;
            UpdateGrandTotal();
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
            savebutton.Click += CompleteprocessButton_Click;
            btnSubmit.Click += btnSubmit_Click;
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
                    textEditDiscountHeader.Text = "0";
                    textEditDiscountHeader.Enabled = false;
                }
                else
                {
                    textEditDiscountHeader.Text = "0";
                    textEditDiscountHeader.Enabled = true;
                }
                CalculateHeaderTotal();
            };

            // Header discount value change
            textEditDiscountHeader.EditValueChanged += (s, e) => CalculateHeaderTotal();

            // Taxes change
            checkedListBoxControltax.ItemCheck += (s, e) => CalculateHeaderTotal();

            // Contact change
            contactLookUpEdit.EditValueChanged += (s, e) =>
            {
                if (contactLookUpEdit.EditValue != null)
                {
                    int contactId = Convert.ToInt32(contactLookUpEdit.EditValue);
                    var contact = _context.ContactPersons.FirstOrDefault(c => c.ContactId == contactId);
                    if (contact != null)
                    {
                        emailTextEdit.Text = contact.ContactEmail;
                        phoneTextEdit.Text = contact.ContactNumber;
                        // Get clinic location for the contact
                        if (contact.Clinic != null)
                        {
                            locationTextEdit.Text = contact.Clinic.Location;
                        }
                        else
                        {
                            locationTextEdit.Text = "";
                        }
                    }
                }
            };
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
                    textEditDiscountDetail.Text = "0";
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
            foreach (var item in quotationDetailsList)
            {
                subtotal += item.TotalService;
            }

            // Apply header-level discount
            decimal discount = decimal.TryParse(textEditDiscountHeader.Text, out var d) ? d : 0;
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

            TotaltextEdit.Text = total.ToString("0.##");
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
                _editingDetail = quotationDetailsList[e.RowHandle];
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_editingDetail != null)
            {
                // Update existing detail
                _editingDetail.ServiceId = Convert.ToInt32(serviceLookUpEdit.EditValue);
                _editingDetail.Quantity = int.TryParse(quantityTextEdit.Text, out var q) ? q : 0;
                _editingDetail.ServicePrice = decimal.TryParse(textEditServicePrice.Text, out var p) ? p : 0;
                _editingDetail.DiscountType = (Discount)comboBoxDiscountTypeDetail.EditValue;
                _editingDetail.Discount = decimal.TryParse(textEditDiscountDetail.Text, out var d) ? d : 0;
                _editingDetail.TotalService = decimal.TryParse(totalServiceTextEdit.Text, out var t) ? t : 0;

                _editingDetail = null;
                btnSubmit.Text = "Add";
            }
            else
            {
                // Add new detail
                var detail = new ServiceSystem.Models.QuotationDetail
                {
                    ServiceId = Convert.ToInt32(serviceLookUpEdit.EditValue),
                    Quantity = int.TryParse(quantityTextEdit.Text, out var q) ? q : 0,
                    ServicePrice = decimal.TryParse(textEditServicePrice.Text, out var p) ? p : 0,
                    DiscountType = (Discount)comboBoxDiscountTypeDetail.EditValue,
                    Discount = decimal.TryParse(textEditDiscountDetail.Text, out var d) ? d : 0,
                    TotalService = decimal.TryParse(totalServiceTextEdit.Text, out var t) ? t : 0,
                };
                quotationDetailsList.Add(detail);
            }

            gridcontrolDetails.RefreshDataSource();
            UpdateGrandTotal();

            // Clear group box fields after add/update
            serviceLookUpEdit.EditValue = null;
            quantityTextEdit.Text = string.Empty;
            textEditServicePrice.Text = string.Empty;
            comboBoxDiscountTypeDetail.EditValue = Discount.NotSelected;
            textEditDiscountDetail.Text = "0";
            totalServiceTextEdit.Text = string.Empty;
        }

        private async void CompleteprocessButton_Click(object sender, EventArgs e)
        {
            if (quotationDetailsList.Count == 0)
            {
                XtraMessageBox.Show("Please add at least one service before continuing.");
                return;
            }

            // Update header
            var header = _context.QuotationHeaders.FirstOrDefault(q => q.QuotationId == _quotationHeaderId);
            if (header != null)
            {
                header.ClinicId = Convert.ToInt32(clinicLookUpEdit.EditValue);
                header.InitialDate = initialDateEdit.DateTime;
                header.ExpireDate = expireDateEdit.DateTime;
                header.Note = noteRichTextBox.Text;
                header.SalesManId = Convert.ToInt32(SalesManlookUpEdit.EditValue);
                header.QuotationNaMe = quotationNameTextEdit.Text;
                header.Status = (QuotationStatus)comboBoxStatus.EditValue;
                header.priority = (priorityStatus)prioritycomboBoxEdit.EditValue;
                header.DiscountType = (Discount)comboBoxDiscountType.EditValue;
                header.Discount = decimal.TryParse(textEditDiscountHeader.Text, out var d) ? d : 0;
                header.TotalDuo = decimal.TryParse(TotaltextEdit.Text, out var t) ? t : 0;
                header.ContactId = Convert.ToInt32(contactLookUpEdit.EditValue);
                header.UpdatedLog = DateTime.Now.ToString();
                header.Taxes = new List<ServiceSystem.Models.Taxes>();


                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem checkedItem in checkedListBoxControltax.CheckedItems)
                {
                    int taxId = (int)checkedItem.Value;
                    var tax = await _context.Taxeses.FirstOrDefaultAsync(tx => tx.TaxesID == taxId);
                    if (tax != null)
                    {
                        header.Taxes.Add(tax);
                    }
                }
                await _quotationHeaderService.UpdateQuotationHeader(header);
            }

            // Update details
            foreach (var detail in quotationDetailsList)
            {
                if (detail.QuotationDetailId == 0) // New detail
                {
                    detail.QuotationId = _quotationHeaderId;
                    detail.CreatedLog = DateTime.Now.ToString();
                    detail.UpdatedLog = DateTime.Now.ToString();
                    detail.DeletedLog = "";
                    detail.isDeleted = false;
                    await _quotationDetailService.AddQuotationDetails(detail);
                }
                else
                {
                    // Update existing detail
                    await _quotationDetailService.UpdateQuotationDetails(detail);
                }
            }

            await _context.SaveChangesAsync();

            XtraMessageBox.Show("Quotation updated successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditQuotationForm_Load(object sender, EventArgs e)
        {
            // Center all row text
            gridViewdet.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            // Center header text
            gridViewdet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }
    }
}