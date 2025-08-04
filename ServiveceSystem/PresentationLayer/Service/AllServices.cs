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

namespace ServiveceSystem.PresentationLayer.Service
{
    public partial class AllServices : Form
    {
        private List<ServiceSystem.Models.Service> _services;
        private RepositoryItemButtonEdit editButton;
        private RepositoryItemButtonEdit deleteButton;

        public AllServices()
        {
            InitializeComponent();
            gridView1.RowCellClick += gridView1_RowCellClick;
            LoadServicesAsync();
        }

        private async Task LoadServicesAsync()
        {
            var serviceService = new ServiceService(new AppDBContext());
            _services = await serviceService.GetAll();
            BindGrid(_services);
        }

        private void BindGrid(List<ServiceSystem.Models.Service> services)
        {
            var displayList = services.Select(s => new
            {
                s.ServiceId, 
                s.Name,
                s.Description,
                ServicePrice = s.ServicePrice
            }).ToList();
            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();
            var col = gridView1.Columns["ServiceId"];
            if (col != null)
                col.Visible = false;
            InitGridButtons(); 
        }

        private void InitGridButtons()
        {
            if (editButton == null)
            {
                editButton = new RepositoryItemButtonEdit();
                editButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                editButton.Buttons[0].Caption = "Edit";
                editButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
                editButton.Buttons[0].Appearance.ForeColor = System.Drawing.Color.Blue;
                editButton.ButtonClick += EditButton_ClickAsync;
                gridControl1.RepositoryItems.Add(editButton);
            }
            if (gridView1.Columns["Edit"] == null)
            {
                var editCol = gridView1.Columns.AddField("Edit");
                editCol.Visible = true;
                editCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                editCol.ColumnEdit = editButton;
                editCol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
                editCol.VisibleIndex = 0;
            }
            if (deleteButton == null)
            {
                deleteButton = new RepositoryItemButtonEdit();
                deleteButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                deleteButton.Buttons[0].Caption = "Delete";
                deleteButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
                deleteButton.Buttons[0].Appearance.ForeColor = System.Drawing.Color.Red;
                deleteButton.ButtonClick += DeleteButton_Click;
                gridControl1.RepositoryItems.Add(deleteButton);
            }
            if (gridView1.Columns["Delete"] == null)
            {
                var deleteCol = gridView1.Columns.AddField("Delete");
                deleteCol.Visible = true;
                deleteCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                deleteCol.ColumnEdit = deleteButton;
                deleteCol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
                deleteCol.VisibleIndex = 1;
            }
        }

        private async void EditButton_ClickAsync(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int serviceId = (int)gridView1.GetRowCellValue(rowHandle, "ServiceId");
            var editForm = new EditService(serviceId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await LoadServicesAsync();
            }
            
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int serviceId = (int)gridView1.GetRowCellValue(rowHandle, "ServiceId");
            var service = _services.FirstOrDefault(s => s.ServiceId == serviceId);
            if (service != null && MessageBox.Show($"Delete service '{service.Name}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var serviceService = new ServiceService(new AppDBContext());
                await serviceService.DeleteService(serviceId);
                await LoadServicesAsync();
            }
        }

        private async void btnAddService_Click(object sender, EventArgs e)
        {
            var addForm = new AddService();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
               await LoadServicesAsync();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _services.Where(s => s.Name != null && s.Name.ToLower().Contains(filter)).ToList();
            BindGrid(filtered);
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "Edit")
            {
                gridView1.FocusedRowHandle = e.RowHandle;
                EditButton_ClickAsync(sender, EventArgs.Empty);
            }
            else if (e.Column.FieldName == "Delete")
            {
                gridView1.FocusedRowHandle = e.RowHandle;
                DeleteButton_Click(sender, EventArgs.Empty);
            }
        }
    }
} 