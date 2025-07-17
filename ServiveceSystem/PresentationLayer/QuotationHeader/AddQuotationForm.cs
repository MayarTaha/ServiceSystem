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
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraGrid.Columns;

namespace ServiveceSystem.PresentationLayer.QuotationHeader
{
    public partial class AddQuotationForm : DevExpress.XtraEditors.XtraForm
    {
        private AppDBContext _context;
        private QuotationHeaderService _quotationHeaderService;
        private BindingList<ServiceSystem.Models.QuotationDetail> quotationDetailsList = new BindingList<ServiceSystem.Models.QuotationDetail>();
        private readonly QuotationDetailService _quotationDetailService;

        public AddQuotationForm()
        {
            InitializeComponent();
            this.Size = new Size(935, 500);
            gridViewdet.GroupPanelText = " ";
            _context = new AppDBContext();
            _quotationHeaderService = new QuotationHeaderService(_context);
            _quotationDetailService = new QuotationDetailService(_context);

            // Set the GridControl's DataSource initially
            gridcontrolDetails.DataSource = quotationDetailsList;

            LoadLookUps();
            SetupGrid(); // Call SetupGrid synchronously as it primarily configures columns

            // Event handlers for gridViewdet (the GridView)
            gridViewdet.CellValueChanged += (s, e) => UpdateGrandTotal();
            gridViewdet.RowCountChanged += (s, e) => UpdateGrandTotal();
        }

        private void LoadLookUps()
        {
            // Discount Type
            comboBoxDiscountTypeDetail.Properties.Items.Clear();
            comboBoxDiscountTypeDetail.Properties.Items.AddRange(Enum.GetValues(typeof(Discount)));

            // Discount Type header
            comboBoxDiscountTypeHeader.Properties.Items.Clear();
            comboBoxDiscountTypeHeader.Properties.Items.AddRange(Enum.GetValues(typeof(Discount)));

            // Quotation Status
            comboBoxStatus.Properties.Items.Clear();
            comboBoxStatus.Properties.Items.AddRange(Enum.GetValues(typeof(QuotationStatus)));

            // Service
            serviceLookUpEdit.Properties.DataSource = _context.Services.Where(s => !s.isDeleted).ToList();
            serviceLookUpEdit.Properties.DisplayMember = "Name";
            serviceLookUpEdit.Properties.ValueMember = "ServiceId";
            serviceLookUpEdit.Properties.Columns.Clear();
            serviceLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Service Name"));

            // Clinic
            lookUpClinic.Properties.DataSource = _context.Clinics.Where(c => !c.isDeleted).ToList();
            lookUpClinic.Properties.DisplayMember = "ClinicName";
            lookUpClinic.Properties.ValueMember = "ClinicId";
            lookUpClinic.Properties.Columns.Clear();
            lookUpClinic.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClinicName", "Clinic Name"));

            // Contact
            lookUpContact.Properties.DataSource = _context.ContactPersons.ToList();
            lookUpContact.Properties.DisplayMember = "ContactName";
            lookUpContact.Properties.ValueMember = "ContactId";
            lookUpContact.Properties.Columns.Clear();
            lookUpContact.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "Contact Name"));
        }

        private void SetupGrid()
        {
            // Disable auto column generation
            gridViewdet.OptionsBehavior.AutoPopulateColumns = false;

            // Clear any existing columns
            //gridViewdet.Columns.Clear();

            // Add only the columns you want to display
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "ServiceName", Caption = "Service" });
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "QuotationNote", Caption = "Quotation Note" }); // Optional: remove if you don't want to show
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "Quantity", Caption = "Quantity" });
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "ServicePrice", Caption = "Unit Price" });
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "DiscountType", Caption = "Discount Type" });
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "Discount", Caption = "Discount" });
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "TotalService", Caption = "Total" });

            // Set up DiscountType column as ComboBox
            var discountTypeCol = gridViewdet.Columns["DiscountType"];
            if (discountTypeCol != null)
            {
                var repoDiscountType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
                repoDiscountType.Items.AddRange(Enum.GetValues(typeof(Discount)));
                discountTypeCol.ColumnEdit = repoDiscountType;
            }
        }

        private void gridcontrolDetails_Click(object sender, EventArgs e)
        {
        }

        private void serviceLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (serviceLookUpEdit.EditValue != null)
            {
                int serviceId = Convert.ToInt32(serviceLookUpEdit.EditValue);
                var service = _context.Services.FirstOrDefault(s => s.ServiceId == serviceId);
                if (service != null)
                {
                    textEditServicePrice.Text = service.ServicePrice.ToString("0.##");
                }
            }
        }

        private void clinicLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpClinic.EditValue != null)
            {
                int clinicId = Convert.ToInt32(lookUpClinic.EditValue);
                var clinic = _context.Clinics.FirstOrDefault(c => c.ClinicId == clinicId);
                if (clinic != null)
                {
                    txtPhone.Text = clinic.Phone;
                    txtLocation.Text = clinic.Location;
                    txtEmail.Text = clinic.Email;
                }
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate input for header
            if (lookUpClinic.EditValue == null ||
                lookUpContact.EditValue == null ||
                comboBoxStatus.EditValue == null ||
                string.IsNullOrWhiteSpace(textEditNote.Text) ||
                dateEditInitialDate.EditValue == null ||
                dateEditExpireDate.EditValue == null)
            {
                XtraMessageBox.Show("Please fill in all required header fields.");
                return;
            }

            // Validate input for detail
            if (serviceLookUpEdit.EditValue == null ||
                string.IsNullOrWhiteSpace(textEditServicePrice.Text) ||
                string.IsNullOrWhiteSpace(quantityTextEdit.Text) ||
                comboBoxDiscountTypeDetail.EditValue == null || comboBoxDiscountTypeHeader.EditValue == null ||
                string.IsNullOrWhiteSpace(textEditDiscountDetail.Text)|| string.IsNullOrWhiteSpace(textEditDiscountHeader.Text))
            {
                XtraMessageBox.Show("Please fill in all required detail fields.");
                return;
            }

            // Save header first
            var header = new ServiceSystem.Models.QuotationHeader
            {
                ClinicId = Convert.ToInt32(lookUpClinic.EditValue),
                ContactId = Convert.ToInt32(lookUpContact.EditValue),
                InitialDate = dateEditInitialDate.DateTime,
                ExpireDate = dateEditExpireDate.DateTime,
                Note = textEditNote.Text,
                Status = (QuotationStatus)comboBoxStatus.EditValue,
                DiscountType = (Discount)comboBoxDiscountTypeHeader.EditValue,
                Discount = decimal.TryParse(textEditDiscountHeader.Text, out var d) ? d : 0,
                TotalDuo = 0, // Will be calculated from details
                CreatedLog = DateTime.Now.ToString(),
                UpdatedLog = DateTime.Now.ToString(),
                DeletedLog = "",
                isDeleted = false
            };

            var headerAdded = await _quotationHeaderService.AddQuotationHeader(header);
            if (!headerAdded)
            {
                XtraMessageBox.Show("Failed to add quotation header. Check your data.");
                return;
            }

            int newQuotationId = header.QuotationId;

            // Get details
            int serviceId = Convert.ToInt32(serviceLookUpEdit.EditValue);
            int quantity = int.TryParse(quantityTextEdit.Text, out var q) ? q : 0;
            decimal unitPrice = decimal.TryParse(textEditServicePrice.Text, out var p) ? p : 0;
            decimal discount = decimal.TryParse(textEditDiscountDetail.Text, out var disc) ? disc : 0;
            Discount discountType = (Discount)comboBoxDiscountTypeDetail.EditValue;

            decimal total = quantity * unitPrice;
            if (discountType == Discount.Percentage)
                total -= total * (discount / 100m);
            else
                total -= discount;

            // Save detail to database
            var detail = new ServiceSystem.Models.QuotationDetail
            {
                QuotationId = newQuotationId,
                ServiceId = serviceId,
                Quantity = quantity,
                Discount = discount,
                DiscountType = (Discount)comboBoxDiscountTypeDetail.EditValue,
               // Discount = decimal.TryParse(textEditDiscountDetail.Text, out var dic) ? disc : 0,
                ServicePrice = unitPrice,
                TotalService = total,
                CreatedLog = DateTime.Now.ToString(),
                UpdatedLog = DateTime.Now.ToString(),
                DeletedLog = "",
                isDeleted = false
            };

            var detailAdded = await _quotationDetailService.AddQuotationDetails(detail);
            if (!detailAdded)
            {
                XtraMessageBox.Show("Failed to add quotation detail. Check your data.");
                return;
            }

            // Add to BindingList and refresh the GridControl
            quotationDetailsList.Add(detail);
            gridcontrolDetails.RefreshDataSource(); // Refresh the GridControl

            UpdateGrandTotal();

            XtraMessageBox.Show("Quotation header and detail added successfully!");
            ClearAllInputs();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ClearDetailFields()
        {
            serviceLookUpEdit.EditValue = null;
            textEditServicePrice.Text = "";
            quantityTextEdit.Text = "";
            textEditDiscountDetail.Text = "";
        }

        private void UpdateGrandTotal()
        {
            decimal sum = 0;
            for (int i = 0; i < gridViewdet.RowCount; i++)
            {
                var totalValue = gridViewdet.GetRowCellValue(i, "TotalService");

                if (totalValue != null && decimal.TryParse(totalValue.ToString(), out decimal rowTotal))
                {
                    sum += rowTotal;
                }
            }
            totalServiceTextEdit.Text = sum.ToString("0.##");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddQuotationForm_Load(object sender, EventArgs e)
        {
            gridViewdet.Columns["ServiceId"].Visible = false;
            gridViewdet.Columns["QuotationDetailId"].Visible = false;
            gridViewdet.Columns["QuotationId"].Visible = false;
            gridViewdet.Columns["CreatedLog"].Visible = false;
            gridViewdet.Columns["UpdatedLog"].Visible = false;
            gridViewdet.Columns["DeletedLog"].Visible = false;
            gridViewdet.Columns["QuotationHeader"].Visible = false;
            gridViewdet.Columns["Service"].Visible = false;
            gridViewdet.Columns["isDeleted"].Visible = false;
            //gridViewdet.Columns["ServiceName"].Caption = "Service";


            //
            ///
            ///





        }

        private void ClearAllInputs()
        {
            // Detail section
            serviceLookUpEdit.EditValue = null;
            textEditServicePrice.Text = string.Empty;
            quantityTextEdit.Text = string.Empty;
            comboBoxDiscountTypeDetail.EditValue = null;
            textEditDiscountDetail.Text = string.Empty;
            totalServiceTextEdit.Text = string.Empty;

            // Header section
            lookUpClinic.EditValue = null;
            txtPhone.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtEmail.Text = string.Empty;
            lookUpContact.EditValue = null;
            textEditNote.Text = string.Empty;
            comboBoxStatus.EditValue = null;
            dateEditInitialDate.EditValue = null;
            dateEditExpireDate.EditValue = null;
            comboBoxDiscountTypeHeader.EditValue = null;
            textEditDiscountHeader.Text = string.Empty;
        }
    }
} 