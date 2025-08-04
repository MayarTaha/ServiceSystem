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
using DevExpress.XtraEditors.DXErrorProvider;

namespace ServiveceSystem.PresentationLayer.Clinic
{
    public partial class AddClinic : DevExpress.XtraEditors.XtraForm
    {
        private readonly ClinicService _clinicService;
        private readonly AppDBContext _context;

        public AddClinic()
        {
            InitializeComponent();
            _context = new AppDBContext();
            _clinicService = new ClinicService(_context);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;
            try
            {
               
                var clinic = new ServiceSystem.Models.Clinic
                {
                    ClinicName = ClinicnametextEdit.Text.Trim(),
                    CompanyName = CompanyNametextEdit.Text.Trim(),
                    Phone = PhonetextEdit.Text.Trim(),
                    Email = EmailtextEdit.Text.Trim(),
                    Location = LocationtextEdit.Text.Trim(),
                    CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}",
                    UpdatedLog = "",
                    DeletedLog = "",
                    isDeleted = false
                };

                _clinicService.AddClinic(clinic);

                MessageBox.Show("Clinic added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the clinic:\n" + ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // UAE mobile number regex: starts with 05 and 8 digits after
                var phoneRegex = new System.Text.RegularExpressions.Regex(@"^05[0-9]{8}$");

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