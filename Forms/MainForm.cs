using System.ComponentModel;
using Vehicle_Rental_Management_System.components;
using Vehicle_Rental_Management_System.factories;
using Vehicle_Rental_Management_System.Interfaces;

namespace Vehicle_Rental_Management_System
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            LoadVehicleUserControl();
        }

        void LoadVehicleUserControl()
        {
            VehicleUserControl vehicleUserControl = new VehicleUserControl();
            vehicleUserControl.Dock = DockStyle.Fill;
            dynamicLayout.Controls.Clear();
            dynamicLayout.Controls.Add(vehicleUserControl);
        }


        private void btnVehicle_Click(object sender, EventArgs e)
        {
            LoadVehicleUserControl();
        }

        private void logo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VehicleUserControl vehicleUserControl = new VehicleUserControl();
            vehicleUserControl.Dock = DockStyle.Fill;
            dynamicLayout.Controls.Clear();
            dynamicLayout.Controls.Add(vehicleUserControl);
        }
    }
}
