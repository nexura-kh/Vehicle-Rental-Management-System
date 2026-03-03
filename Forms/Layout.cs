using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Rental_Management_System.Components;
using Vehicle_Rental_Management_System.Interfaces;

namespace Vehicle_Rental_Management_System.Forms
{
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
            LoadDashboard();
        }
        private void LoadDashboard()
        {
            DashboardManagementService dashboard = new DashboardManagementService();
            dashboard.Dock = DockStyle.Fill;
            dynamicPanel.Controls.Clear();
            dynamicPanel.Controls.Add(dashboard);
        }
        private void LoadFeature(IManagementService service)
        {
            dynamicPanel.Controls.Clear();

            var control = new GenericManagement
            {
                Dock = DockStyle.Fill
            };

            control.Configure(service);
            dynamicPanel.Controls.Add(control);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            LoadFeature(new CustomerManagementService());
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            LoadFeature(new VehicleManagementService());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
