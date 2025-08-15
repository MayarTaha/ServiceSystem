using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.Clinic
{
    public partial class EditClinic : DevExpress.XtraEditors.XtraForm
    {
        private readonly ClinicService _clinicService;
        private ServiceSystem.Models.Clinic _clinic;
        private readonly int _clinicId;

        public EditClinic(int clinicId)
        {
            InitializeComponent();
            _clinicService = new ClinicService(new AppDBContext());
            _clinicId = clinicId;
            LoadClinic();
            //this.SaveButton.Click += new EventHandler(SaveButton_Click); // Ensure event is hooked
        }

        private void LoadClinic()
        {
            using (var context = new AppDBContext())
            {
                _clinic = context.Clinics.Find(_clinicId);
                if (_clinic == null)
                {
                    MessageBox.Show("Clinic not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                ClinicnametextEdit.Text = _clinic.ClinicName;
                CompanyNametextEdit.Text = _clinic.CompanyName;
                PhonetextEdit.Text = _clinic.Phone;
                EmailtextEdit.Text = _clinic.Email;
                LocationtextEdit.Text = _clinic.Location;
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;
            try
            {
                using (var context = new AppDBContext())
                {
                    var clinic = context.Clinics.Find(_clinicId);
                    if (clinic == null)
                    {
                        MessageBox.Show("Clinic not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    clinic.ClinicName = ClinicnametextEdit.Text.Trim();
                    clinic.CompanyName = CompanyNametextEdit.Text.Trim();
                    clinic.Phone = PhonetextEdit.Text.Trim();
                    clinic.Email = EmailtextEdit.Text.Trim();
                    clinic.Location = LocationtextEdit.Text.Trim();
                    clinic.UpdatedLog = $"{CurrentUser.Username} - {DateTime.Now}";
                    await context.SaveChangesAsync();
                }
                MessageBox.Show("Clinic updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the clinic:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            labelClinicNameError.Visible = false;
            labelCompanynameError.Visible = false;
            labelemailerror.Visible = false;
            labelPhoneError.Visible = false;
            labelLocationError.Visible = false;

            if (string.IsNullOrWhiteSpace(ClinicnametextEdit.Text))
            {
                labelClinicNameError.Visible = true;
                labelClinicNameError.Text = "Clinic Name is required";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(CompanyNametextEdit.Text))
            {
                labelCompanynameError.Visible = true;
                labelCompanynameError.Text = "Company Name is required.";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailtextEdit.Text))
            {
                labelemailerror.Visible = true;
                labelemailerror.Text = "Email is required.";
                isValid = false;
            }
            else if (!IsValidEmail(EmailtextEdit.Text))
            {
                labelemailerror.Visible = true;
                labelemailerror.Text = "Invalid email format.";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(PhonetextEdit.Text))
            {
                labelPhoneError.Visible = true;
                labelPhoneError.Text = "Phone is required.";
                isValid = false;
            }
            else
            {
                // UAE mobile number regex: starts with +971
                var phoneRegex = new System.Text.RegularExpressions.Regex(@"^\+971\s[0-9]{2}\s[0-9]{3}\s[0-9]{4}$");

                if (!phoneRegex.IsMatch(PhonetextEdit.Text))
                {
                    labelPhoneError.Visible = true;
                    labelPhoneError.Text = "Invalid UAE phone number format.";
                    isValid = false;
                }
                else
                {
                    labelPhoneError.Visible = false;
                }
            }

            if (string.IsNullOrWhiteSpace(LocationtextEdit.Text))
            {
                labelLocationError.Visible = true;
                labelLocationError.Text = "Location is required.";
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