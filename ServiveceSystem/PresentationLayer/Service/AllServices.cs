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
        private readonly ServiceService _serviceService;
        private List<ServiceSystem.Models.Service> _services;

        public AllServices()
        {
            InitializeComponent();
            _serviceService = new ServiceService(new AppDBContext());
            LoadServicesAsync();
        }

        private async void LoadServicesAsync()
        {
            _services = await _serviceService.GetAll();
            BindGrid(_services);
        }

        private void BindGrid(List<ServiceSystem.Models.Service> services)
        {
            // Only show Name, Description, ServicePrice
            var displayList = services.Select(s => new
            {
                s.ServiceId, // hidden
                s.Name,
                s.Description,
                ServicePrice = s.ServicePrice
            }).ToList();
            gridControl1.DataSource = displayList;
            gridControl1.ForceInitialize();
            var col = gridView1.Columns["ServiceId"];
            if (col != null)
                col.Visible = false;
            InitGridButtons(); // Now called here
        }

        private void InitGridButtons()
        {
            // Only add if not already present
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle < 0) return;
            int serviceId = (int)gridView1.GetRowCellValue(rowHandle, "ServiceId");
            var editForm = new EditService(serviceId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadServicesAsync();
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
                await _serviceService.DeleteService(serviceId);
                LoadServicesAsync();
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            var addForm = new AddService();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadServicesAsync();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var filtered = _services.Where(s => s.Name != null && s.Name.ToLower().Contains(filter)).ToList();
            BindGrid(filtered);
        }
    }
} 