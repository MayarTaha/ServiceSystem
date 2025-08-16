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
using ServiceSystem.PresentationLayer.QuotationHeader;
using ServiceSystem.PresentationLayer.Quotation;


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
            this.Size = new Size(880, 380);

            gridViewdet.GroupPanelText = " ";
            _context = new AppDBContext();
            _quotationHeaderService = new QuotationHeaderService(_context);
            _quotationDetailService = new QuotationDetailService(_context);

            // Set the GridControl's DataSource initially
            gridcontrolDetails.DataSource = quotationDetailsList;

            LoadLookUps();
            SetupGrid();

            // Event handlers for gridViewdet (the GridView)
            gridViewdet.CellValueChanged += (s, e) => UpdateGrandTotal();
            gridViewdet.RowCountChanged += (s, e) => UpdateGrandTotal();
            quantityTextEdit.KeyPress += quantityTextEdit_KeyPress;
        }

        private void LoadLookUps()
        {
            // Discount Type
            comboBoxDiscountTypeDetail.Properties.Items.Clear();
            comboBoxDiscountTypeDetail.Properties.Items.AddRange(Enum.GetValues(typeof(Discount)));
            comboBoxDiscountTypeDetail.EditValue = Discount.NotSelected;

           

            // Service
            serviceLookUpEdit.Properties.DataSource = _context.Services.Where(s => !s.isDeleted).ToList();
            serviceLookUpEdit.Properties.DisplayMember = "Name";
            serviceLookUpEdit.Properties.ValueMember = "ServiceId";
            serviceLookUpEdit.Properties.Columns.Clear();
            serviceLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Service Name"));


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

        private void gridcontrolDetails_Click(object sender, EventArgs e)
        {
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
            TotaltextEdit.Text = sum.ToString("0.##");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void CompleteprocessButton_Click(object sender, EventArgs e)
        {
            if (quotationDetailsList.Count == 0)
            {
                XtraMessageBox.Show("Please add at least one service before continuing.");
                return;
            }
            var total = decimal.TryParse(TotaltextEdit.Text, out var t) ? t : 0;
            var addForm = new QuotationForm(quotationDetailsList.ToList(), total);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void comboBoxDiscountTypeDetail_SelectedIndexChanged(object sender, EventArgs e)
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
                textEditDiscountDetail.Enabled = true;
            }
            CalculateTotalService();
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

        private void quantityTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalService();
        }

        private void textEditDiscountDetail_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalService();
        }

        private void totalServiceTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEditServicePrice_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalService();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Validate input for detail
            if (serviceLookUpEdit.EditValue == null ||
                string.IsNullOrWhiteSpace(textEditServicePrice.Text) ||
                string.IsNullOrWhiteSpace(quantityTextEdit.Text) ||
                comboBoxDiscountTypeDetail.EditValue == null || comboBoxDiscountTypeDetail.EditValue == null ||
                string.IsNullOrWhiteSpace(textEditDiscountDetail.Text) || string.IsNullOrWhiteSpace(textEditDiscountDetail.Text))
            {
                XtraMessageBox.Show("Please fill in all required detail fields.");
                return;
            }


            var detail = new ServiceSystem.Models.QuotationDetail
            {
                ServiceId = Convert.ToInt32(serviceLookUpEdit.EditValue),
                Quantity = int.TryParse(quantityTextEdit.Text, out var q) ? q : 0,
                Discount = decimal.TryParse(textEditDiscountDetail.Text, out var d) ? d : 0,
                DiscountType = (Discount)comboBoxDiscountTypeDetail.EditValue,
                ServicePrice = decimal.TryParse(textEditServicePrice.Text, out var p) ? p : 0,
                TotalService = decimal.TryParse(totalServiceTextEdit.Text, out var t) ? t : 0,
            };

            quotationDetailsList.Add(detail);
            gridcontrolDetails.RefreshDataSource();
            UpdateGrandTotal();

            // Reset fields to default values
            serviceLookUpEdit.EditValue = null;
            textEditServicePrice.Text = "";
            quantityTextEdit.Text = "";
            comboBoxDiscountTypeDetail.EditValue = Discount.NotSelected;
            textEditDiscountDetail.Text = "0";
            totalServiceTextEdit.Text = "";
        }

        private void AddQuotationForm_Load(object sender, EventArgs e)
        {
          

            var column = gridViewdet.Columns["Quotation Header"];
            if (column != null)
            {
                column.Visible = false;
            }
            // Center all row text
            gridViewdet.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            // Center header text
            gridViewdet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            
        }
        private void quantityTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow control keys (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // block input
                XtraMessageBox.Show("Only numbers are allowed in Quantity.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}