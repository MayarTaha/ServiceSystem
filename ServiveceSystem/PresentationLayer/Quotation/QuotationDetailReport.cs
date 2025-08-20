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
using DevExpress.XtraEditors.Controls;
using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;

namespace ServiceSystem.PresentationLayer.Quotation
{
    public partial class QuotationDetailReport : DevExpress.XtraEditors.XtraForm
    {
        private readonly AppDBContext _context;
        private BindingList<ServiceSystem.Models.QuotationDetail> quotationDetailsList = new BindingList<ServiceSystem.Models.QuotationDetail>();
        private int _quotationHeaderId;
        public QuotationDetailReport(int quotationHeaderId)
        {
            InitializeComponent();
            this.Size = new Size(900, 460);
            _context = new AppDBContext();
            _quotationHeaderId = quotationHeaderId;
            noteRichTextBox.BackColor = this.BackColor;
            noteRichTextBox.ForeColor = Color.White;
            LoadLookUps();
            LoadQuotationData();
            SetupGrid();

        }
        private void LoadLookUps()
        {

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
            // UpdateGrandTotal();
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

        private void QuotationDetailReport_Load(object sender, EventArgs e)
        {
            gridViewdet.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            // Center header text
            gridViewdet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }
    }
}