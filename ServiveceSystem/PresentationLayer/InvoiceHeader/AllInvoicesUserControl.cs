using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace ServiveceSystem.PresentationLayer.InvoiceHeader
{
    public partial class AllInvoicesUserControl : XtraUserControl
    {
        public AllInvoicesUserControl()
        {
            //InitializeComponent();
            var label = new LabelControl { Text = "Invoices coming soon", Dock = DockStyle.Fill, Appearance = { TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center, VAlignment = DevExpress.Utils.VertAlignment.Center } } };
            this.Controls.Add(label);
        }
    }
} 