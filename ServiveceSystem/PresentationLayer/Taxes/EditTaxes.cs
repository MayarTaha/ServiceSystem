using System;
using System.Windows.Forms;
using ServiveceSystem.BusinessLayer;
using ServiceSystem.Models;
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.Taxes
{
    public partial class EditTaxes : DevExpress.XtraEditors.XtraForm
    {
        private readonly TaxesService _taxesService;
        private readonly int _taxesId;
        private ServiceSystem.Models.Taxes _taxes;

        public EditTaxes(int taxesId)
        {
            InitializeComponent();
            _taxesService = new TaxesService(new AppDBContext());
            _taxesId = taxesId;
            LoadTaxes();
        }

        private async void LoadTaxes()
        {
            try
            {
                _taxes = await _taxesService.GetById(_taxesId);
                if (_taxes != null)
                {
                    txtName.Text = _taxes.Name;
                    txtTaxRate.Text = _taxes.TaxRate.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tax: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter a tax name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtTaxRate.Text, out decimal taxRate))
                {
                    MessageBox.Show("Please enter a valid tax rate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _taxes.Name = txtName.Text.Trim();
                _taxes.TaxRate = taxRate;

                await _taxesService.UpdateAsync(_taxes);
                MessageBox.Show("Tax updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating tax: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 