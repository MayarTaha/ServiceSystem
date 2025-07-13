using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace ServiveceSystem.PresentationLayer.Quotation
{
    public partial class AllQuotationsUserControl : XtraUserControl
    {
        public AllQuotationsUserControl()
        {
            //InitializeComponent();
            var label = new LabelControl { Text = "Quotations coming soon", Dock = DockStyle.Fill, Appearance = { TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center, VAlignment = DevExpress.Utils.VertAlignment.Center } } };
            this.Controls.Add(label);
        }
    }
} 