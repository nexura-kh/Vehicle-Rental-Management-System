using System;
using System.Linq;
using System.Windows.Forms;
using Vehicle_Rental_Management_System.Repositories;
using Vehicle_Rental_Management_System.Models;

namespace Vehicle_Rental_Management_System.Forms
{
    public partial class BookingDialog : Form
    {
        private readonly Booking _booking;
        private VehicleRepository vehicleRepository = new VehicleRepository();

        public BookingDialog(Booking booking = null)
        {
            InitializeComponent();
            _booking = booking;
        }

        public string FirstName => txtFirstName.Text;
        public string LastName => txtLastName.Text;
        public string Nationality => txtNationality.Text;
        public string Phone => txtPhone.Text;

        public string VehicleType => cboVehicleType.Text;
        public string VehicleModel => cboVehicleName.Text;

        public DateTime StartDate => dtStartDate.Value;
        public DateTime EndDate => dtEndDate.Value;

        public int Duration
        {
            get
            {
                if (int.TryParse(txtDuration.Text, out int d))
                    return d;
                return 0;
            }
        }

        public int PricePerHour
        {
            get
            {
                var vehicle = vehicleRepository.GetByModel(VehicleModel);

                if (vehicle == null)
                    return 0;

                return (int)vehicle.price;
            }
        }

        public double Price => PricePerHour * Duration;

        private void BookingDialog_Load(object sender, EventArgs e)
        {
            vehicleRepository.Init();

            var types = vehicleRepository
                .GetAll()
                .Select(v => v.type)
                .Distinct()
                .ToList();

            cboVehicleType.Items.Clear();
            cboVehicleType.Items.AddRange(types.ToArray());

            if (cboVehicleType.Items.Count > 0)
                cboVehicleType.SelectedIndex = 0;

            dtStartDate.Value = DateTime.Now;
            dtEndDate.Value = DateTime.Now.AddDays(1);

            LoadVehicleModels();

            if (_booking != null)
            {
                txtFirstName.Text = _booking.Customer.FirstName;
                txtLastName.Text = _booking.Customer.LastName;
                txtNationality.Text = _booking.Customer.Nationality;
                txtPhone.Text = _booking.Customer.PhoneNumber;
                txtDuration.Text = _booking.Duration.ToString();
                txtPrice.Text = _booking.Payment.Amount.ToString();
            }
        }

        private void LoadVehicleModels()
        {
            if (cboVehicleType.SelectedItem == null)
                return;

            string selectedType = cboVehicleType.SelectedItem.ToString();

            var models = vehicleRepository
                .GetAll()
                .Where(v => v.type == selectedType)
                .Select(v => v.model)
                .ToList();

            cboVehicleName.Items.Clear();
            cboVehicleName.Items.AddRange(models.ToArray());

            if (cboVehicleName.Items.Count > 0)
                cboVehicleName.SelectedIndex = 0;
        }

        private void cboVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadVehicleModels();
            CalculatePrice();
        }

        private void cboVehicleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            if (int.TryParse(txtDuration.Text, out int duration))
            {
                txtPrice.Text = (PricePerHour * duration).ToString();
            }
            else
            {
                txtPrice.Text = "0";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number is required.");
                return;
            }

            if (Duration <= 0)
            {
                MessageBox.Show("Duration must be greater than 0.");
                return;
            }

            if (dtEndDate.Value <= dtStartDate.Value)
            {
                MessageBox.Show("End date must be after start date.");
                return;
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