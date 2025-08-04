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
            if (!ValidateForm())
                return;

            try
            {
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

        private bool ValidateForm()
        {
            bool isValid = true;

            labelNameError.Visible = false;
            labelPhoneError.Visible = false;
            labelemailerror.Visible = false;
            ClinicLookUpEditErrorlabel.Visible = false;

            if (string.IsNullOrWhiteSpace(txtContactName.Text))
            {
                labelNameError.Visible = true;
                labelNameError.Text = "Name is required.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                labelPhoneError.Visible = true;
                labelPhoneError.Text = "Phone is required.";
                isValid = false;
            }
            else
            {
                var phoneRegex = new System.Text.RegularExpressions.Regex(@"^05[0-9]{8}$");
                if (!phoneRegex.IsMatch(txtContactNumber.Text))
                {
                    labelPhoneError.Visible = true;
                    labelPhoneError.Text = "Invalid UAE phone number format.";
                    isValid = false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtContactEmail.Text))
            {
                labelemailerror.Visible = true;
                labelemailerror.Text = "Email is required.";
                isValid = false;
            }
            else if (!IsValidEmail(txtContactEmail.Text))
            {
                labelemailerror.Visible = true;
                labelemailerror.Text = "Invalid email format.";
                isValid = false;
            }

            if (cmbClinic.SelectedItem == null)
            {
                ClinicLookUpEditErrorlabel.Visible = true;
                ClinicLookUpEditErrorlabel.Text = "You must choose a clinic.";
                isValid = false;
            }

            return isValid;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


    }
} 