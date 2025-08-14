using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.ContactPerson
{
    public partial class AddContactPerson : DevExpress.XtraEditors.XtraForm
    {
        private readonly AppDBContext _context;
        private readonly ContactPersonService _contactService;
        public AddContactPerson()
        {
            InitializeComponent();
            _context = new AppDBContext();
            _contactService = new ContactPersonService(_context);

            LoadClinicsIntoDropDown();
        }

        private void LoadClinicsIntoDropDown()
        {
            var clinics = _context.Clinics
                .Where(c => !c.isDeleted)
                .Select(c => new { c.ClinicId, c.ClinicName })
                .ToList();

            ClinicLookUpEdit.Properties.DataSource = clinics;
            ClinicLookUpEdit.Properties.DisplayMember = "ClinicName";
            ClinicLookUpEdit.Properties.ValueMember = "ClinicId";
            ClinicLookUpEdit.Properties.NullText = "Select Clinic";
        }

        private async void SaveContactButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;
            try
            {
                if (ClinicLookUpEdit.EditValue == null)
                {
                    MessageBox.Show("Please select a clinic.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var contact = new ServiceSystem.Models.ContactPerson
                {
                    ContactName = nametextEdit.Text.Trim(),
                    ContactNumber = PhonetextEdit.Text.Trim(),
                    ContactEmail = EmailtextEdit.Text.Trim(),
                    ClinicId = Convert.ToInt32(ClinicLookUpEdit.EditValue),
                    CreatedLog = "",
                    UpdatedLog = "",
                    DeletedLog = ""
                };

                await _contactService.AddContactPerson(contact);
                MessageBox.Show("Contact person added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateForm()
        {
            bool isValid = true;

          
            labelNameError.Visible = false;
            labelPhoneError.Visible = false;
            labelemailerror.Visible = false;
            ClinicLookUpEditErrorlabel.Visible = false;

            if (string.IsNullOrWhiteSpace(nametextEdit.Text))
            {
                labelNameError.Visible = true;
                labelNameError.Text = "Name is required";
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


            if (string.IsNullOrWhiteSpace(EmailtextEdit.Text))
            {
                labelemailerror.Visible = true;
                labelemailerror.Text = "Email is required";
                isValid = false;
            }
            else if (!IsValidEmail(EmailtextEdit.Text))
            {
                labelemailerror.Visible = true;
                labelemailerror.Text = "Invalid email format.";
                isValid = false;
            }
            if (ClinicLookUpEdit.EditValue == null)
            {
                ClinicLookUpEditErrorlabel.Visible = true;
                ClinicLookUpEditErrorlabel.Text = "You Must Choose Clinic ";
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