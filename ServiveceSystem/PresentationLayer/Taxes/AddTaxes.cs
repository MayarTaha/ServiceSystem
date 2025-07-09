using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ServiveceSystem.BusinessLayer;
using ServiceSystem.Models;

namespace ServiveceSystem.PresentationLayer.Taxes
{
    public partial class AddTaxes : DevExpress.XtraEditors.XtraForm
    {
        private readonly TaxesService _taxesService;
        private readonly AppDBContext _context;

        public AddTaxes()
        {
            InitializeComponent();
            _context = new AppDBContext();
            _taxesService = new TaxesService(_context);
            btnSave.Click += btnSave_Click;
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
            var tax = new Taxes
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
    }
}