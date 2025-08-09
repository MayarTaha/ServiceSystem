using ServiceSystem.Models;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ServiceSystem.Models;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.Payment
{
    public partial class PayInvoiceRemainderForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly InvoiceHeaderService _invoiceHeaderService;
        private List<InvoiceHeader> _invoicesWithRemainder = new List<InvoiceHeader>();

        public PayInvoiceRemainderForm()
        {
            InitializeComponent();
            _invoiceHeaderService = new InvoiceHeaderService(new AppDBContext());
            LoadInvoicesWithRemainder();
        }

        private async void LoadInvoicesWithRemainder()
        {
            var allInvoices = await _invoiceHeaderService.GetAll();
            _invoicesWithRemainder = allInvoices.Where(i =>
                decimal.TryParse(i.Reminder, out var rem) && rem > 0
            ).ToList();
            BindGrid(_invoicesWithRemainder);
        }

        private void BindGrid(List<InvoiceHeader> invoices)
        {
            var displayList = invoices.Select(i => new
            {
                i.InvoiceHeaderId,
                Name = i.QuotationHeader != null ? i.QuotationHeader.Note : "",
                i.InvoiceDate,
                PaymentMethod = i.PaymentMethod != null ? i.PaymentMethod.PaymentType : "",
                Remainder = i.Reminder,
                ContactName = i.Contact != null ? i.Contact.ContactName : ""
            }).ToList();

            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();
            InitGridButtons();
        }

        private void InitGridButtons()
        {
            if (gridView1.Columns["PayNow"] == null)
            {
                var payNowButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
                payNowButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                payNowButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
                payNowButton.Buttons[0].Caption = "Pay Now";
                payNowButton.ButtonClick += PayNowButton_ButtonClick;
                gridControl1.RepositoryItems.Add(payNowButton);
                var col = gridView1.Columns.AddField("PayNow");
                col.Visible = true;
                col.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                col.ColumnEdit = payNowButton;
                col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            }
        }

        private void PayNowButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = gridView1.GetFocusedRow();
            if (row != null)
            {
                dynamic invoice = row;
                int invoiceId = invoice.InvoiceHeaderId;
                decimal remainder = decimal.Parse(invoice.Remainder);
                var payNowForm = new PayNowForm(invoiceId, remainder);
                payNowForm.PaymentCompleted += PayNowForm_PaymentCompleted;
                payNowForm.ShowDialog();
            }
        }

        private void PayNowForm_PaymentCompleted(object sender, PaymentCompletedEventArgs e)
        {
            // Update invoice in database
            using (var context = new AppDBContext())
            {
                var dbInvoice = context.invoiceHeaders.FirstOrDefault(i => i.InvoiceHeaderId == e.InvoiceId);
                if (dbInvoice != null)
                {
                    dbInvoice.Reminder = e.NewRemainder.ToString();
                    context.SaveChanges();
                }
            }
            // Update or remove invoice from grid based on new remainder
            var invoice = _invoicesWithRemainder.FirstOrDefault(i => i.InvoiceHeaderId == e.InvoiceId);
            if (invoice != null)
            {

                invoice.Reminder = e.NewRemainder.ToString();
                if (e.NewRemainder == 0)
                {
                    _invoicesWithRemainder.Remove(invoice);

                }
                BindGrid(_invoicesWithRemainder);
            }
        }
    
    
    }

}