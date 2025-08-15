using System;
using System.Windows.Forms;
using ServiveceSystem.BusinessLayer;
using ServiceSystem.Models;
using ServiveceSystem.Models;

namespace ServiceSystem.PresentationLayer.SalesMam
{
    public partial class AddSalesMan : DevExpress.XtraEditors.XtraForm
    {
        private readonly SalesManService _service;

        public AddSalesMan()
        {
            InitializeComponent();
            _service = new SalesManService(new AppDBContext());
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                labelNameError.Visible = true;
                labelNameError.Text = "Name is required";
                return;
            }

            try
            {
                var model = new SalesMan
                {
                    SalesManName = txtName.Text.Trim(),
                };
                await _service.AddAsync(model);
                MessageBox.Show("Salesman added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


