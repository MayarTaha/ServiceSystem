using System;
using System.Windows.Forms;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models; // For AppDBContext
using ServiceSystem.Models; // For User

namespace ServiveceSystem.PresentationLayer.User
{
    public partial class EditUser : DevExpress.XtraEditors.XtraForm
    {
        private readonly UserService _userService;
        private readonly int _userId;
        private ServiceSystem.Models.User _user;

        public EditUser(int userId)
        {
            InitializeComponent();
            _userService = new UserService(new AppDBContext());
            _userId = userId;
            LoadUser();
        }

        private async void LoadUser()
        {
            try
            {
                _user = await _userService.GetById(_userId);
                if (_user != null)
                {
                    txtUsername.Text = _user.Username;
                    txtRole.Text = _user.Permission;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _user.Username = txtUsername.Text.Trim();
                _user.Permission = txtRole.Text.Trim();

                // Change password if provided
                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    _user.Password = txtPassword.Text;
                    MessageBox.Show("Password changed successfully!", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                await _userService.UpdateAsync(_user);
                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 