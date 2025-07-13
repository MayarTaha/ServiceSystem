using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ServiveceSystem.BusinessLayer;
using ServiceSystem.Models;
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.Service
{
    public partial class EditService : XtraForm
    {
        private readonly ServiceService _serviceService;
        private readonly int _serviceId;
        private ServiceSystem.Models.Service _service;

        public EditService(int serviceId)
        {
            InitializeComponent();
            _serviceService = new ServiceService(new AppDBContext());
            _serviceId = serviceId;
            LoadServiceAsync();
        }

        private async void LoadServiceAsync()
        {
            _service = await _serviceService.GetById(_serviceId);
            if (_service == null)
            {
                MessageBox.Show("Service not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtName.Text = _service.Name;
            txtDescription.Text = _service.Description;
            spinPrice.Value = _service.ServicePrice;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Service name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (spinPrice.Value <= 0)
            {
                MessageBox.Show("Service price must be greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spinPrice.Focus();
                return;
            }
            _service.Name = txtName.Text.Trim();
            _service.Description = txtDescription.Text.Trim();
            _service.ServicePrice = spinPrice.Value;
            _service.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
            await _serviceService.UpdateService(_service);
            MessageBox.Show("Service updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
} 