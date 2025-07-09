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

namespace ServiveceSystem.PresentationLayer.User
{
    public partial class AddUser : DevExpress.XtraEditors.XtraForm
    {
        private readonly UserService _userService;

        public AddUser()
        {
            InitializeComponent();
            _userService = new UserService(new AppDBContext());

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPermission.Text))
            {
                MessageBox.Show("Permission is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPermission.Focus();
                return;
            }

            var newUser = new ServiceSystem.Models.User
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Permission = txtPermission.Text.Trim(),
                CreatedLog = $"{CurrentUser.Username} - {DateTime.Now}",
                isDeleted = false,
                DeletedLog = "",
                UpdatedLog = ""
            };

            await _userService.AddUser(newUser);
            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}