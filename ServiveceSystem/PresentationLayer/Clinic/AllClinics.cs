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

namespace ServiveceSystem.PresentationLayer.Clinic
{
    public partial class AllClinics : DevExpress.XtraEditors.XtraForm
    {
        private List<ServiceSystem.Models.Clinic> _clinics;

        public AllClinics()
        {
            InitializeComponent();
            gridView1.RowCellClick += gridView1_RowCellClick;
            LoadClinics();
        }

        private async void LoadClinics()
        {
            try
            {
                var clinicService = new ClinicService(new AppDBContext());
                _clinics = await clinicService.GetAll();
                BindGrid(_clinics);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading clinics: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<ServiceSystem.Models.Clinic> clinics)
        {
            var displayList = clinics.Select(c => new
            {
                c.ClinicId, // hidden
                c.ClinicName,
                c.CompanyName,
                c.Phone,
                c.Email,
                c.Location
            }).ToList();
            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();
            var col = gridView1.Columns["ClinicId"];
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
            int clinicId = (int)gridView1.GetRowCellValue(rowHandle, "ClinicId");
            var editForm = new EditClinic(clinicId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await LoadClinicsAsync();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int clinicId = (int)gridView1.GetRowCellValue(rowHandle, "ClinicId");
            var clinic = _clinics.FirstOrDefault(c => c.ClinicId == clinicId);
            if (clinic != null && MessageBox.Show($"Delete clinic '{clinic.ClinicName}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var clinicService = new ClinicService(new AppDBContext());
                await clinicService.DeleteAsync(clinicId);
                await LoadClinicsAsync();
            }
        }

        private  void btnAddClinic_Click(object sender, EventArgs e)
        {
            var addForm = new AddClinic();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                 LoadClinicsAsync();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _clinics.Where(c => c.ClinicName != null && c.ClinicName.ToLower().Contains(filter)).ToList();
            BindGrid(filtered);
        }

        private async Task LoadClinicsAsync()
        {
            try
            {
                var clinicService = new ClinicService(new AppDBContext());
                _clinics = await clinicService.GetAll();
                BindGrid(_clinics);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading clinics: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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