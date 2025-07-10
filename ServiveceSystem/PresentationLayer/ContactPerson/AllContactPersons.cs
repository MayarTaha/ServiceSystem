using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using ServiveceSystem.BusinessLayer;
using ServiceSystem.Models;
using ServiveceSystem.Models;

namespace ServiveceSystem.PresentationLayer.ContactPerson
{
    public partial class AllContactPersons : DevExpress.XtraEditors.XtraForm
    {
        private readonly ContactPersonService _contactPersonService;
        private readonly ClinicService _clinicService;
        private List<ServiceSystem.Models.ContactPerson> _contactPersons;
        private List<ServiceSystem.Models.Clinic> _clinics;

        public AllContactPersons()
        {
            InitializeComponent();
            _contactPersonService = new ContactPersonService(new AppDBContext());
            _clinicService = new ClinicService(new AppDBContext());
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                _contactPersons = await _contactPersonService.GetAll();
                _clinics = await _clinicService.GetAll();
                BindGrid(_contactPersons);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contact persons: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<ServiceSystem.Models.ContactPerson> contactPersons)
        {
            var displayList = contactPersons.Select(cp => new
            {
                cp.ContactId, // hidden
                cp.ContactName,
                cp.ContactNumber,
                cp.ContactEmail,
                ClinicName = _clinics.FirstOrDefault(c => c.ClinicId == cp.ClinicId)?.ClinicName ?? "Unknown"
            }).ToList();
            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();
            var col = gridView1.Columns["ContactId"];
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
                editButton.Click += EditButton_Click;
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
                deleteButton.Click += DeleteButton_Click;
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
            int contactId = (int)gridView1.GetRowCellValue(rowHandle, "ContactId");
            var editForm = new EditContactPerson(contactId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await LoadDataAsync();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int contactId = (int)gridView1.GetRowCellValue(rowHandle, "ContactId");
            var contactPerson = _contactPersons.FirstOrDefault(cp => cp.ContactId == contactId);
            if (contactPerson != null && MessageBox.Show($"Delete contact person '{contactPerson.ContactName}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await _contactPersonService.DeleteAsync(contactId);
                await LoadDataAsync();
            }
        }

        private async void btnAddContactPerson_Click(object sender, EventArgs e)
        {
            var addForm = new AddContactPerson();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                await LoadDataAsync();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _contactPersons.Where(cp => cp.ContactName != null && cp.ContactName.ToLower().Contains(filter)).ToList();
            BindGrid(filtered);
        }

        private async Task LoadDataAsync()
        {
            try
            {
                _contactPersons = await _contactPersonService.GetAll();
                _clinics = await _clinicService.GetAll();
                BindGrid(_contactPersons);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contact persons: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 