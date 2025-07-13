using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using ServiveceSystem.BusinessLayer;
using ServiveceSystem.Models; // For AppDBContext
using ServiceSystem.Models; // For User

namespace ServiveceSystem.PresentationLayer.User
{
    public partial class AllUsers : DevExpress.XtraEditors.XtraForm
    {
        private readonly UserService _userService;
        private List<ServiceSystem.Models.User> _users;

        public AllUsers()
        {
            InitializeComponent();
            _userService = new UserService(new AppDBContext());
            gridView1.RowCellClick += gridView1_RowCellClick;
            LoadUsers();
        }

        private async void LoadUsers()
        {
            try
            {
                _users = await _userService.GetAll();
                BindGrid(_users);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<ServiceSystem.Models.User> users)
        {
            var displayList = users.Select(u => new
            {
                u.UserId, // hidden
                u.Username,
                u.Permission
            }).ToList();
            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();
            var col = gridView1.Columns["UserId"];
            if (col != null)
                col.Visible = false;
            InitGridButtons();
        }

        private void InitGridButtons()
        {
            if (gridView1.Columns["Edit"] == null)
            {
                var editButton = new RepositoryItemButtonEdit();
                editButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                editButton.Buttons[0].Caption = "Edit";
                editButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
                editButton.Buttons[0].Appearance.ForeColor = System.Drawing.Color.Blue;
                gridControl1.RepositoryItems.Add(editButton);

                var editCol = gridView1.Columns.AddField("Edit");
                editCol.Visible = true;
                editCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                editCol.ColumnEdit = editButton;
                editCol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
                editCol.VisibleIndex = 0;
            }

            if (gridView1.Columns["Delete"] == null)
            {
                var deleteButton = new RepositoryItemButtonEdit();
                deleteButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                deleteButton.Buttons[0].Caption = "Delete";
                deleteButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
                deleteButton.Buttons[0].Appearance.ForeColor = System.Drawing.Color.Red;
                gridControl1.RepositoryItems.Add(deleteButton);

                var deleteCol = gridView1.Columns.AddField("Delete");
                deleteCol.Visible = true;
                deleteCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                deleteCol.ColumnEdit = deleteButton;
                deleteCol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
                deleteCol.VisibleIndex = 1;
            }
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int userId = (int)gridView1.GetRowCellValue(rowHandle, "UserId");
            var editForm = new EditUser(userId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await LoadUsersAsync();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int userId = (int)gridView1.GetRowCellValue(rowHandle, "UserId");
            var user = _users.FirstOrDefault(u => u.UserId == userId);
            if (user != null && MessageBox.Show($"Delete user '{user.Username}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await _userService.DeleteAsync(userId);
                await LoadUsersAsync();
            }
        }

        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            var addForm = new AddUser();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                await LoadUsersAsync();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _users.Where(u => u.Username != null && u.Username.ToLower().Contains(filter)).ToList();
            BindGrid(filtered);
        }

        private async Task LoadUsersAsync()
        {
            try
            {
                _users = await _userService.GetAll();
                BindGrid(_users);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "Edit")
            {
                EditButton_Click(sender, EventArgs.Empty);
            }
            else if (e.Column.FieldName == "Delete")
            {
                DeleteButton_Click(sender, EventArgs.Empty);
            }
        }
    }
} 