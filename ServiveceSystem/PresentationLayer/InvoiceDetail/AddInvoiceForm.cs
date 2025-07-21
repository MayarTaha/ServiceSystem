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
using ServiceSystem.PresentationLayer.InvoiceDetail;
using DevExpress.XtraEditors.Controls;

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
            //this.Size = new Size(900, 400);
            gridViewdet.GroupPanelText = " ";
            _context = new AppDBContext();
            _invoiceHeaderService = new InvoiceHeaderService(_context);
            _invoiceDetailService = new InvoiceDetailService(_context);

            // Set the GridControl's DataSource initially
            gridcontrolDetails.DataSource = invoiceDetailsList;

            LoadLookUps();
            SetupGrid(); 

            // Event handlers for gridViewdet (the GridView)
            gridViewdet.CellValueChanged += (s, e) => UpdateGrandTotal();
            gridViewdet.RowCountChanged += (s, e) => UpdateGrandTotal();
           
        }

        private void LoadLookUps()
        {
            comboBoxDiscountType.Properties.Items.Clear();
            comboBoxDiscountType.Properties.Items.AddRange(Enum.GetValues(typeof(Discount)));
            // Service
            serviceLookUpEdit.Properties.DataSource = _context.Services.Where(s => !s.isDeleted).ToList(); ;
            serviceLookUpEdit.Properties.DisplayMember = "Name";
            serviceLookUpEdit.Properties.ValueMember = "ServiceId";
            serviceLookUpEdit.Properties.Columns.Clear();
            serviceLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Service Name"));
        }
        private void SetupGrid()
        {
            
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "ServiceId", Caption = "Service" });
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "Quantity", Caption = "Quantity" });
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "ServicePrice", Caption = "Unit Price" });
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "Discount", Caption = "Discount" });
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "DiscountType", Caption = "Discount Type" });
            gridViewdet.Columns.Add(new GridColumn() { FieldName = "TotalService", Caption = "Total" });

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
   
        private void UpdateGrandTotal()
        {
           

            decimal sum = 0;
            foreach (var item in invoiceDetailsList)
            {
                sum += item.TotalService;
            }
            TotaltextEdit.Text = sum.ToString("0.##"); 
        }
        private void CompleteprocessButton_Click(object sender, EventArgs e)
        {
           
            var total = decimal.TryParse(TotaltextEdit.Text, out var t) ? t : 0;
            var addForm = new InvoicePayment(invoiceDetailsList.ToList(), total);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                
            }
            this.Close();

        }
        private void comboBoxDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDiscountType.EditValue == null)
                return;

            var selected = (Discount)comboBoxDiscountType.EditValue;
            if (selected == Discount.NotSelected)
            {
                discountValueTextEdit.Text = "0";
                discountValueTextEdit.Enabled = false;
            }
            else
            {
                discountValueTextEdit.Enabled = true;
            }
            CalculateTotalService();
        }

        private void CalculateTotalService()
        {
            decimal price = decimal.TryParse(textEditServicePrice.Text, out var p) ? p : 0;
            int qty = int.TryParse(quantityTextEdit.Text, out var q) ? q : 0;
            decimal discount = decimal.TryParse(discountValueTextEdit.Text, out var d) ? d : 0;
            var discountType = comboBoxDiscountType.EditValue != null ? (Discount)comboBoxDiscountType.EditValue : Discount.NotSelected;

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

        private void discountValueTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalService();
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
            var detail = new ServiceSystem.Models.InvoiceDetail
            {
                ServiceId = Convert.ToInt32(serviceLookUpEdit.EditValue),
                Quantity = int.TryParse(quantityTextEdit.Text, out var q) ? q : 0,
                Discount = decimal.TryParse(discountValueTextEdit.Text, out var d) ? d : 0,
                DiscountType = (Discount)comboBoxDiscountType.EditValue,
                ServicePrice = decimal.TryParse(textEditServicePrice.Text, out var p) ? p : 0,
                TotalService = decimal.TryParse(totalServiceTextEdit.Text, out var t) ? t : 0,
            };

            invoiceDetailsList.Add(detail);
            gridcontrolDetails.RefreshDataSource();
            UpdateGrandTotal();

            // امسح الحقول
            serviceLookUpEdit.EditValue = null;
            textEditServicePrice.Text = "";
            quantityTextEdit.Text = "";
            comboBoxDiscountType.EditValue = null;
            discountValueTextEdit.Text = "";
            totalServiceTextEdit.Text = "";
        }
    }
}