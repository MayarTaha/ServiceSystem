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
using DevExpress.XtraEditors.Controls;
using ServiceSystem.Models;
using ServiveceSystem.Models;
using Microsoft.EntityFrameworkCore;
using ServiceSystem.PresentationLayer.Reports;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.SqlClient;

namespace ServiceSystem.PresentationLayer.InvoiceDetail
{
    public partial class InvoiceDetailReport : DevExpress.XtraEditors.XtraForm
    {
        private readonly AppDBContext _context;
        private BindingList<ServiceSystem.Models.InvoiceDetail> invoiceDetailsList = new BindingList<ServiceSystem.Models.InvoiceDetail>();
        private int _invoiceHeaderId;
        public InvoiceDetailReport(int invoiceHeaderId)
        {
            InitializeComponent();
            _context = new AppDBContext();
            _invoiceHeaderId = invoiceHeaderId;
            this.Size = new Size(670, 620);
            noterichTextBox.BackColor = this.BackColor;
            noterichTextBox.ForeColor = Color.White;
            LoadLookUps();
            LoadInvoiceData();
            SetupGrid();

        }

        private void LoadLookUps()
        {

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

        private void LoadInvoiceData()
        {
            var header = _context.Set<InvoiceHeader>()
                .Include(i => i.QuotationHeader)
                .ThenInclude(i => i.Clinic)
                .Include(i => i.Contact)
                .ThenInclude(c => c.Clinic)
                .Include(i => i.PaymentMethod)
                .FirstOrDefault(i => i.InvoiceHeaderId == _invoiceHeaderId);

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
                // Populate header controls
                quotationLookUpEdit.EditValue = header.QuotationId;
                invoiceDateEdit.DateTime = DateTime.TryParse(header.InvoiceDate, out var dt) ? dt : DateTime.Now;
                paymentmethodlookupedit.EditValue = header.PaymentMethodId;
                noterichTextBox.Text = header.Note;
                comboBoxStatus.EditValue = header.Status;
                clinicLookUpEdit.EditValue = header.ClinicId;
                contactLookUpEdit.EditValue = header.Contact;
                salesmanlookUpEdit.EditValue = header.SalesManId;
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
                //taxes
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
            var details = _context.InvoiceDetails
                .Include(d => d.Service)
                .Where(d => d.InvoiceHeaderId == _invoiceHeaderId && !d.isDeleted)
                .ToList();

            invoiceDetailsList = new BindingList<ServiceSystem.Models.InvoiceDetail>(details);
            gridcontrolDetails.DataSource = invoiceDetailsList;

            // Set TotaltextEdit to match TotalPricetextEdit (both show the same total)
            //TotaltextEdit.Text = TotalPricetextEdit.Text;

            // Calculate payment balance based on loaded values
            //CalculatePaymentBalance();
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





        //private DataSet GetInvoiceData(int invoiceId)
        //{
        //    string connectionString = "Server=.;Database=ServiceSystem;Trusted_Connection=True;Trustservercertificate=true ";
        //    DataSet ds = new DataSet();

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        // Header
        //        using (SqlCommand cmd = new SqlCommand("sp_GetInvoiceHeaderById", conn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);

        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            da.Fill(ds, "InvoiceHeader");
        //        }

        //        // Details
        //        using (SqlCommand cmd = new SqlCommand("sp_GetInvoiceDetailsByInvoiceId", conn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);

        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            da.Fill(ds, "InvoiceHeader");
        //        }
        //    }

        //    //// هنا ممكن تعمل Relation بين الجدولين (Header ↔ Detail)
        //    //if (!ds.Relations.Contains("HeaderDetail"))
        //    //{
        //    //    ds.Relations.Add("HeaderDetail",
        //    //        ds.Tables["InvoiceHeader"].Columns["InvoiceHeaderId"],
        //    //        ds.Tables["InvoiceDetail"].Columns["InvoiceHeaderId"]);
        //    //}

        //    return ds;
        //}
        private DataSet GetInvoiceData(int invoiceId)
        {
            string connectionString = "Server=.;Database=ServiceSystem;Trusted_Connection=True;Trustservercertificate=true ";
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Header
                using (SqlCommand cmd = new SqlCommand("sp_GetInvoiceHeaderById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "InvoiceHeader");
                }

                // Details
                using (SqlCommand cmd = new SqlCommand("sp_GetInvoiceDetailsByInvoiceId", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "InvoiceDetail"); // CORRECTED LINE: Changed "InvoiceHeader" to "InvoiceDetail"
                }
            }

            // IMPORTANT: Re-enable the DataRelation creation, as it's essential for master-detail
            if (!ds.Relations.Contains("HeaderDetail"))
            {
                // Ensure both tables exist before creating the relation
                if (ds.Tables.Contains("InvoiceHeader") && ds.Tables.Contains("InvoiceDetail"))
                {
                    DataColumn parentColumn = ds.Tables["InvoiceHeader"].Columns["InvoiceHeaderId"];
                    DataColumn childColumn = ds.Tables["InvoiceDetail"].Columns["InvoiceHeaderId"];

                    if (parentColumn != null && childColumn != null)
                    {
                        ds.Relations.Add("HeaderDetail", parentColumn, childColumn, false);
                    }
                    else
                    {
                        // Log or handle error: InvoiceHeaderId column not found in one of the DataTables.
                        // This should ideally not happen if your SPs return the ID.
                         MessageBox.Show("InvoiceHeaderId column not found in one of the DataTables.");
                    }
                }
                else
                {
                    MessageBox.Show("InvoiceHeader or InvoiceDetail DataTable not found in DataSet.");
                    // Log or handle error: InvoiceHeader or InvoiceDetail DataTable not found in DataSet.
                }
            }

            return ds;
        }


        private void savebutton_Click(object sender, EventArgs e)
        {

            // InvoiceReport InvoiceReport = new InvoiceReport();
            //InvReport invReport = new InvReport();
            //invReport.DataSource = invoiceDetailsList;
            //invReport.Parameters["InvoiceHeaderId"].Value = _invoiceHeaderId;
            //invReport.ShowPreview();

            //InvoiceReport.DataSource = invoiceDetailsList;
            //// InvoiceReport.Parameters["InvoiceHeaderId"].Value = _invoiceHeaderId;
            //InvoiceReport.ShowPreview();
            //var ds = GetInvoiceData(_invoiceHeaderId);
            //MessageBox.Show(ds.Tables["InvoiceDetail"].Rows.Count.ToString());


            //InvoiceReport report = new InvoiceReport();
            //report.DataSource = ds;
            //report.DataMember = "InvoiceHeader"; // الماستر

            //report.ShowPreview();
            //var ds = GetInvoiceData(_invoiceHeaderId);

            //InvoiceReport report = new InvoiceReport(ds);
            //report.ShowPreview();
            var ds = GetInvoiceData(_invoiceHeaderId);

            InvoiceReport report = new InvoiceReport();
            report.DataSource = ds;
            report.DataMember = "InvoiceHeader"; 
                                                 // Master

            report.ShowPreview();
        }
    }
}