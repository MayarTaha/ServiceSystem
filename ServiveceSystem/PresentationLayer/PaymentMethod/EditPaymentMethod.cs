using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.PaymentMethod
{
    public partial class EditPaymentMethod : XtraForm
    {
        private readonly PaymentMethodService _service;
        private readonly int _id;
        private ServiveceSystem.Models.PaymentMethod _method;
        public EditPaymentMethod(int id)
        {
            InitializeComponent();
            _service = new PaymentMethodService(new AppDBContext());
            _id = id;
            LoadData();
        }
        private void LoadData()
        {
            _method = _service.GetById(_id);
            if (_method == null)
            {
                XtraMessageBox.Show("Payment method not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtPaymentType.Text = _method.PaymentType;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaymentType.Text))
            {
                XtraMessageBox.Show("Payment type is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaymentType.Focus();
                return;
            }
            _method.PaymentType = txtPaymentType.Text.Trim();
            _service.Update(_method);
            XtraMessageBox.Show("Payment method updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
} 