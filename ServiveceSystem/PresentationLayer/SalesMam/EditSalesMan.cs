using System;
using System.Windows.Forms;
using ServiveceSystem.BusinessLayer;
using ServiceSystem.Models;
using ServiveceSystem.Models;

namespace ServiceSystem.PresentationLayer.SalesMam
{
    public partial class EditSalesMan : DevExpress.XtraEditors.XtraForm
    {
        private readonly SalesManService _service;
        private readonly int _id;
        private SalesMan _salesMan;

        public EditSalesMan(int id)
        {
            InitializeComponent();
            _service = new SalesManService(new AppDBContext());
            _id = id;
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                _salesMan = await _service.GetById(_id);
                if (_salesMan == null)
                {
                    MessageBox.Show("Salesman not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }
                txtName.Text = _salesMan.SalesManName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading salesman: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                _salesMan.SalesManName = txtName.Text.Trim();
                await _service.UpdateAsync(_salesMan);
                MessageBox.Show("Salesman updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


