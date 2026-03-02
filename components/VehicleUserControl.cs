using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System.components
{
    public partial class VehicleUserControl : UserControl
    {
        public VehicleUserControl()
        {
            InitializeComponent();
            LoadVehicleData();
        }
        void LoadVehicleData()
        {
            vehicleData.Columns.Add("Id", "Vehicle ID");
            vehicleData.Columns.Add("Name", "Vehicle Name");
            vehicleData.Columns.Add("Type", "Type");

            vehicleData.Columns.Add("Price", "Price Per Day");
            vehicleData.Rows.Add("V001", "Toyota Corolla", "Car", 50);
            vehicleData.Rows.Add("V002", "Honda Click", "Motorbike", 15);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
