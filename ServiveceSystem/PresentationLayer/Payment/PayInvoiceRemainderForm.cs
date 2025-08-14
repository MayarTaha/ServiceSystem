using ServiceSystem.Models;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;

namespace ServiveceSystem.PresentationLayer.Payment
{
    public partial class PayInvoiceRemainderForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly InvoiceHeaderService _invoiceHeaderService;
        private List<InvoiceHeader> _invoicesWithRemainder = new List<InvoiceHeader>();
        //private readonly AppDBContext _context;

        //public PayInvoiceRemainderForm(AppDBContext context)
        //{
        //    context = _context;
        //}
        public PayInvoiceRemainderForm()
        {
            InitializeComponent();
            _invoiceHeaderService = new InvoiceHeaderService(new AppDBContext());
            LoadInvoicesWithRemainder();
        }

        private async void LoadInvoicesWithRemainder()
        {
            //var allInvoices = await _invoiceHeaderService.GetAllAsync();
            //_invoicesWithRemainder = allInvoices.Where(i =>
            //    decimal.TryParse(i.Reminder, out var rem) && rem > 0
            //).ToList();
            BindGrid(GetInvoicesWithRemainder());
        }

        private void BindGrid(List<InvoiceHeader> invoices)
        {
            var displayList = invoices.Select(i => new
            {
                i.InvoiceHeaderId,
                //Name = i.QuotationHeader != null ? i.QuotationHeader.QuotationNaMe : "",
                Name=i.Note,
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
            BindGrid(GetInvoicesWithRemainder());
        }

        public List<InvoiceHeader> GetInvoicesWithRemainder()
        {
            using (var context = new AppDBContext())
            {
                // Load invoices 
                var invoices = context.invoiceHeaders
                    .Where(i => !i.isDeleted)
                    .Include(i => i.PaymentMethod)
                    .Include(i => i.Contact)
                    .Include(i => i.QuotationHeader)
                    .ToList();

                // Group payments by invoice
                var paymentsByInvoice = context.payments
                    .Where(p => !p.isDeleted)
                    .GroupBy(p => p.InvoiceId)
                    .Select(g => new { InvoiceId = g.Key, TotalPaid = g.Sum(x => x.AmountPaid) })
                    .ToDictionary(x => x.InvoiceId, x => x.TotalPaid);

                var withRemainder = new List<InvoiceHeader>();
                foreach (var inv in invoices)
                {
                    decimal paidFromPayments = paymentsByInvoice.TryGetValue(inv.InvoiceHeaderId, out var sum) ? sum : 0m;
                    //decimal totalPaid = inv.Payment ;
                    decimal totalPaid =  paidFromPayments; // include header.Payment as initial payment if any
                     decimal remainder = inv.TotalPrice - totalPaid;
                    //decimal remainder = inv.TotalPrice;

                    if (remainder > 0)
                    {
                        inv.Reminder = remainder.ToString(); 
                        withRemainder.Add(inv);
                    }
                }

                return withRemainder;
            }
        }
    }

}