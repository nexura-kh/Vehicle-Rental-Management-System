using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Rental_Management_System.Interfaces;

namespace Vehicle_Rental_Management_System.Components
{
    public partial class GenericManagement : UserControl
    {
        private IManagementService _service;
        public GenericManagement()
        {
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.MultiSelect = false;
        }
        public void Configure(IManagementService service)
        {
            _service = service;

            lblTitle.Text = service.Title;

            ConfigureColumns();
            LoadData();
        }
        private void ConfigureColumns()
        {
            dgvData.Columns.Clear();

            foreach (var col in _service.GetColumns())
            {
                dgvData.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = col.HeaderText,
                    DataPropertyName = col.DataPropertyName,
                    Width = col.Width
                });
            }
        }
        private void LoadData()
        {
            dgvData.DataSource = _service.GetData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _service.ShowAddDialog(this);
            LoadData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            var id = dgvData.SelectedRows[0].Cells[0].Value;
            _service.DeleteRecord(id);
            LoadData();
        }
    }
}
