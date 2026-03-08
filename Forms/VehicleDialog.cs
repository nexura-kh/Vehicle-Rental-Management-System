using System;
using System.Windows.Forms;
using Vehicle_Rental_Management_System.Models;

namespace Vehicle_Rental_Management_System.Forms
{
    public partial class VehicleDialog : Form
    {
        private readonly Vehicle _vehicle; 

        public VehicleDialog(Vehicle vehicle = null)
        {
            InitializeComponent();

            txtType.Items.AddRange(new string[] { "SUV", "Sedan", "Truck", "Van", "Motorbike", "E-Bike" });
            txtStatus.Items.AddRange(new Enum[] { VehicleStatus.Available, VehicleStatus.Rented, VehicleStatus.Maintenance });

            txtType.SelectedIndex = 0;
            txtStatus.SelectedIndex = 0;

            _vehicle = vehicle;

            if (_vehicle != null)
            {
                txtName.Text = _vehicle.model;
                txtType.Text = _vehicle.type;
                txtPrice.Text = _vehicle.price.ToString();
                btnAdd.Text = "Save"; 
            }
        }

        public string VehicleType => txtType.Text;
        public string VehicleName => txtName.Text;
        public decimal PricePerHour => decimal.TryParse(txtPrice.Text, out var p) ? p : 0;
        public VehicleStatus Status => (VehicleStatus)txtStatus.SelectedItem;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vehicle model is required.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Invalid price.");
                return;
            }

            if (_vehicle != null)
            {
                _vehicle.model = VehicleName;
                _vehicle.type = VehicleType;
                _vehicle.price = (double)PricePerHour;
                _vehicle.status = Status;

            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}