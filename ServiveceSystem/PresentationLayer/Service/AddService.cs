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

namespace ServiveceSystem.PresentationLayer.Service
{
    public partial class AddService : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceService _serviceService;

        public AddService()
        {
            InitializeComponent();
            _serviceService = new ServiceService(new AppDBContext());

        }

        private  void btnSave_Click(object sender, EventArgs e)
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

            var service = new ServiceSystem.Models.Service
            {
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                ServicePrice = spinPrice.Value,
                CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}",
                isDeleted = false,
                UpdatedLog = "",
                DeletedLog = ""
            };

             _serviceService.AddService(service);
            MessageBox.Show("Service added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}