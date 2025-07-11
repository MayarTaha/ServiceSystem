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

namespace ServiveceSystem.PresentationLayer.InvoiceDetail
{
    public partial class AddInvoiceForm : DevExpress.XtraEditors.XtraForm
    {

        private AppDBContext _context;
        private InvoiceHeaderService _invoiceHeaderService;
        private BindingList<ServiceSystem.Models.InvoiceDetail> invoiceDetailsList = new BindingList<ServiceSystem.Models.InvoiceDetail>();
        private readonly InvoiceDetailService _invoiceDetailService;

        public AddInvoiceForm()
        {
            InitializeComponent();
            gridViewdet.GroupPanelText = " ";
            _context = new AppDBContext();
            _invoiceHeaderService = new InvoiceHeaderService(_context);
            _invoiceDetailService = new InvoiceDetailService(_context);

            // Set the GridControl's DataSource initially
            gridcontrolDetails.DataSource = invoiceDetailsList;

            LoadLookUps();
            SetupGrid(); // Call SetupGrid synchronously as it primarily configures columns

            // Event handlers for gridViewdet (the GridView)
            gridViewdet.CellValueChanged += (s, e) => UpdateGrandTotal();
            gridViewdet.RowCountChanged += (s, e) => UpdateGrandTotal();
        }

        private void LoadLookUps()
        {
            // ... (your existing LoadLookUps code)
            comboBoxDiscountType.Properties.Items.Clear();
            comboBoxDiscountType.Properties.Items.AddRange(Enum.GetValues(typeof(Discount)));
            // Service
            serviceLookUpEdit.Properties.DataSource = _context.Services.Where(s => !s.isDeleted).ToList(); ;
            serviceLookUpEdit.Properties.DisplayMember = "Name";
            serviceLookUpEdit.Properties.ValueMember = "ServiceId";
            serviceLookUpEdit.Properties.Columns.Clear();
            serviceLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Service Name"));

            //clinic
            lookUpClinic.Properties.DataSource = _context.Clinics.Where(c => !c.isDeleted).ToList();
            lookUpClinic.Properties.DisplayMember = "ClinicName"; // or another property
            lookUpClinic.Properties.ValueMember = "ClinicId";
            lookUpClinic.Properties.Columns.Clear();
            lookUpClinic.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClinicName", "ClinicId"));
            // Quotation
            lookUpQuotation.Properties.DataSource = _context.QuotationHeaders.Where(q => !q.isDeleted).ToList();
            lookUpQuotation.Properties.DisplayMember = "QuotationId"; // or another property
            lookUpQuotation.Properties.ValueMember = "QuotationId";
            lookUpQuotation.Properties.Columns.Clear();
            lookUpQuotation.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Note", "Quotation"));

            // Payment Method
            lookUpPaymentMethod.Properties.DataSource = _context.PaymentMethods.ToList();
            lookUpPaymentMethod.Properties.DisplayMember = "PaymentType";
            lookUpPaymentMethod.Properties.ValueMember = "PaymentMethodId";
            lookUpPaymentMethod.Properties.Columns.Clear();
            lookUpPaymentMethod.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentType", "Payment Method"));

            // Contact
            lookUpContact.Properties.DataSource = _context.ContactPersons.ToList();
            lookUpContact.Properties.DisplayMember = "ContactName";
            lookUpContact.Properties.ValueMember = "ContactId";
            lookUpContact.Properties.Columns.Clear();
            lookUpContact.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "Contact Name"));
        }

        private void SetupGrid()
        {
            // Clear existing columns to prevent duplicates if SetupGrid is called multiple times
            gridViewdet.Columns.Clear();

            // Add columns to the GridView. FieldName MUST match properties of InvoiceDetail.
            gridViewdet.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "ServiceId", Caption = "Service" });
            gridViewdet.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "PaymentType", Caption = "PaymentMethod" });
            gridViewdet.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Quantity", Caption = "Quantity" });
            gridViewdet.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "ServicePrice", Caption = "Unit Price" });
            gridViewdet.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Discount", Caption = "Discount" });
            gridViewdet.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "DiscountType", Caption = "Discount Type" });
            gridViewdet.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "TotalService", Caption = "Total" });

            // Set up Service column as LookUpEdit
            var serviceCol = gridViewdet.Columns["ServiceId"];
            if (serviceCol != null)
            {
                var repoService = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
                repoService.DataSource = _context.Services.ToList();
                repoService.DisplayMember = "Name";
                repoService.ValueMember = "ServiceId";
                serviceCol.ColumnEdit = repoService;
            }

            var paymentcol = gridViewdet.Columns["PaymentType"];
            if (paymentcol != null)
            {
                var repopayment = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
                repopayment.DataSource = _context.Services.ToList();
                repopayment.DisplayMember = "PaymentType";
                repopayment.ValueMember = "PaymentType";
                paymentcol.ColumnEdit = repopayment;
            }

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
            int clinicId = Convert.ToInt32(lookUpClinic.EditValue);
            var clinic = _context.Clinics.FirstOrDefault(c => c.ClinicId == clinicId);
            if (clinic != null)
            {
                txtPhone.Text = clinic.Phone;
                txtLocation.Text = clinic.Location;
                txtEmail.Text = clinic.Email;
            }
        }
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate input
            if (serviceLookUpEdit.EditValue == null ||
                string.IsNullOrWhiteSpace(textEditServicePrice.Text) ||
                string.IsNullOrWhiteSpace(quantityTextEdit.Text) ||
                comboBoxDiscountType.EditValue == null ||
                string.IsNullOrWhiteSpace(discountValueTextEdit.Text) ||
                lookUpQuotation.EditValue == null ||
                lookUpPaymentMethod.EditValue == null ||
                lookUpContact.EditValue == null)
            {
                XtraMessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Save header
            var header = new ServiceSystem.Models.InvoiceHeader
            {
                QuotationId = Convert.ToInt32(lookUpQuotation.EditValue),
                InvoiceDate = dateEditInvoiceDate.DateTime.ToString("yyyy-MM-dd"),
                PaymentMethodId = Convert.ToInt32(lookUpPaymentMethod.EditValue),
                Reminder = textEditReminder.Text,
                ContactId = Convert.ToInt32(lookUpContact.EditValue),
                CreatedLog = DateTime.Now.ToString(),
                UpdatedLog = DateTime.Now.ToString(),
                DeletedLog = "",
                isDeleted = false
            };

            var added = await _invoiceHeaderService.AddInvoiceHeader(header);
            if (!added)
            {
                XtraMessageBox.Show("Failed to add invoice header. Check your data.");
                return;
            }

            int newInvoiceHeaderId = header.InvoiceHeaderId;

            // Get details
            int serviceId = Convert.ToInt32(serviceLookUpEdit.EditValue);
            int quantity = int.TryParse(quantityTextEdit.Text, out var q) ? q : 0;
            decimal unitPrice = decimal.TryParse(textEditServicePrice.Text, out var p) ? p : 0;
            decimal discount = decimal.TryParse(discountValueTextEdit.Text, out var d) ? d : 0;
            Discount discountType = (Discount)comboBoxDiscountType.EditValue;

            decimal total = quantity * unitPrice;
            if (discountType == Discount.Percentage)
                total -= total * (discount / 100m);
            else
                total -= discount;

            // Save to database
            var detail = new ServiceSystem.Models.InvoiceDetail
            {
                ServiceId = serviceId,
                QuotationId = header.QuotationId,
                Quantity = quantity,
                Discount = discount,
                DiscountType = discountType,
                ServicePrice = unitPrice,
                TotalService = total,
                CreatedLog = DateTime.Now.ToString(),
                UpdatedLog = DateTime.Now.ToString(),
                DeletedLog = "",
                isDeleted = false
            };

            await _invoiceDetailService.AddInvoiceDetail(detail);

            // Add to BindingList and refresh the GridControl
            invoiceDetailsList.Add(detail);
            gridcontrolDetails.RefreshDataSource(); // Refresh the GridControl

            UpdateGrandTotal();

            XtraMessageBox.Show("Invoice and detail added successfully!");
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

    }
}