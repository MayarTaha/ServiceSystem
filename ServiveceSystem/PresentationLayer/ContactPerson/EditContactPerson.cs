using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiveceSystem.BusinessLayer;
using ServiceSystem.Models;
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.ContactPerson
{
    public partial class EditContactPerson : DevExpress.XtraEditors.XtraForm
    {
        private readonly ContactPersonService _contactPersonService;
        private readonly ClinicService _clinicService;
        private readonly int _contactId;
        private ServiceSystem.Models.ContactPerson _contactPerson;
        private List<ServiceSystem.Models.Clinic> _clinics;

        public EditContactPerson(int contactId)
        {
            InitializeComponent();
            _contactPersonService = new ContactPersonService(new AppDBContext());
            _clinicService = new ClinicService(new AppDBContext());
            _contactId = contactId;
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                _contactPerson = await _contactPersonService.GetById(_contactId);
                _clinics = await _clinicService.GetAll();
                
                if (_contactPerson != null)
                {
                    txtContactName.Text = _contactPerson.ContactName;
                    txtContactNumber.Text = _contactPerson.ContactNumber;
                    txtContactEmail.Text = _contactPerson.ContactEmail;
                    
                    // Populate clinic combo box
                    cmbClinic.Properties.Items.Clear();
                    foreach (var clinic in _clinics)
                    {
                        cmbClinic.Properties.Items.Add(clinic.ClinicName);
                    }
                    
                    // Set selected clinic
                    var selectedClinic = _clinics.FirstOrDefault(c => c.ClinicId == _contactPerson.ClinicId);
                    if (selectedClinic != null)
                    {
                        cmbClinic.SelectedItem = selectedClinic.ClinicName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contact person: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtContactName.Text))
                {
                    MessageBox.Show("Please enter a contact name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtContactEmail.Text))
                {
                    MessageBox.Show("Please enter an email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbClinic.SelectedItem == null)
                {
                    MessageBox.Show("Please select a clinic.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedClinicName = cmbClinic.SelectedItem.ToString();
                var selectedClinic = _clinics.FirstOrDefault(c => c.ClinicName == selectedClinicName);

                _contactPerson.ContactName = txtContactName.Text.Trim();
                _contactPerson.ContactNumber = txtContactNumber.Text.Trim();
                _contactPerson.ContactEmail = txtContactEmail.Text.Trim();
                _contactPerson.ClinicId = selectedClinic.ClinicId;

                await _contactPersonService.UpdateAsync(_contactPerson);
                MessageBox.Show("Contact person updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating contact person: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 