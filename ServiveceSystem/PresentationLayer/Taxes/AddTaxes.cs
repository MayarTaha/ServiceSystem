using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.Taxes
{
    public partial class AddTaxes : DevExpress.XtraEditors.XtraForm
    {
        private readonly TaxesService _taxesService;

        public AddTaxes()
        {
            InitializeComponent();
            _taxesService = new TaxesService(new AppDBContext());

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tax name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (spinRatio.Value <= 0)
            {
                MessageBox.Show("Tax rate must be greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spinRatio.Focus();
                return;
            }
            var tax = new ServiceSystem.Models.Taxes
            {
                Name = txtName.Text.Trim(),
                TaxRate = spinRatio.Value,
                CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}",
                UpdatedLog = "",
                DeletedLog = "",
                isDeleted = false
            };

            await _taxesService.AddTaxes(tax);
            MessageBox.Show("Tax added successfully");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}