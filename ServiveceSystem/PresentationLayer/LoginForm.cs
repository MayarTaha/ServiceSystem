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
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly AppDBContext _context;

        public LoginForm()
        {
            InitializeComponent();
            _context = new AppDBContext();
            txtPassword.Properties.UseSystemPasswordChar = true;
            //txtPassword.Properties.PasswordChar = '*';
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }


            var user = _context.Users
                .FirstOrDefault(u => u.Username.ToLower() == username.ToLower()
                                  && u.Password == password
                                  && !u.isDeleted);

            if (user != null)
            {
                CurrentUser.Username = user.Username;
                CurrentUser.Permission = user.Permission;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = !txtPassword.Properties.UseSystemPasswordChar;
            btnShowPassword.Text = txtPassword.Properties.UseSystemPasswordChar ? "Show Password" : "Hide Password";
          //  txtPassword.Properties.UseSystemPasswordChar = false; // Show password

        }
        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}