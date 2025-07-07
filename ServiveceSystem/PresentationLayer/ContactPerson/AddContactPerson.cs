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
            //ClinicLookUpEdit.Properties.ValueMember = "ClinicId";
            ClinicLookUpEdit.Properties.NullText = "Select Clinic";
        }

        private void SaveContactButton_Click(object sender, EventArgs e)
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
                    ClinicId = Convert.ToInt32(ClinicLookUpEdit.EditValue)
                };

                _contactService.AddContactPerson(contact);
                MessageBox.Show("Contact person added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                labelPhoneError.Text = "Phone is required";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(EmailtextEdit.Text))
            {
                labelemailerror.Visible = true;
                labelemailerror.Text = "Email is required";
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

    }
}