using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vehicle_Rental_Management_System.Helpers;
using Vehicle_Rental_Management_System.Interfaces;

namespace Vehicle_Rental_Management_System.Components
{
    internal class VehicleManagementService : IManagementService
    {
        public string Title => "Vehicle Management";

        public void DeleteRecord(object selectedId)
        {
            if (selectedId == null)
            {
                MessageBox.Show("Please select a vehicle to delete.");
                return;
            }

            MessageBox.Show($"Vehicle with ID {selectedId} deleted successfully.");
        }

        public List<ColumnDefinition> GetColumns()
        {
            return new List<ColumnDefinition>
            {
                new ColumnDefinition { HeaderText = "ID", DataPropertyName = "vehicleId", Width = 80 },
                new ColumnDefinition { HeaderText = "Type", DataPropertyName = "vehicleType", Width = 120 },
                new ColumnDefinition { HeaderText = "Name", DataPropertyName = "vehicleName", Width = 150 },
                new ColumnDefinition { HeaderText = "Price/Hour ($)", DataPropertyName = "pricePerHour", Width = 110 },
                new ColumnDefinition { HeaderText = "Description", DataPropertyName = "vehicleDescription", Width = 200 }
            };
        }

        public DataTable GetData()
        {
            DataTable table = new DataTable();

            // Define proper data types
            table.Columns.Add("vehicleId", typeof(string));
            table.Columns.Add("vehicleType", typeof(string));
            table.Columns.Add("vehicleName", typeof(string));
            table.Columns.Add("pricePerHour", typeof(decimal));
            table.Columns.Add("vehicleDescription", typeof(string));

            table.Rows.Add("V001", "Car", "Toyota Corolla", 15m, "Compact sedan, fuel efficient");
            table.Rows.Add("V002", "Car", "Honda Civic", 18m, "Sporty sedan, comfortable ride");
            table.Rows.Add("V003", "Car", "Ford Ranger", 25m, "Pickup truck, strong engine");
            table.Rows.Add("V004", "Motorbike", "Honda Click", 5m, "Automatic scooter, easy to ride");
            table.Rows.Add("V005", "Motorbike", "Yamaha NMAX", 7m, "Premium scooter, smooth performance");
            table.Rows.Add("V006", "Van", "Toyota Hiace", 30m, "12-seat van, good for family trips");
            table.Rows.Add("V007", "SUV", "Toyota Fortuner", 28m, "Spacious SUV, powerful engine");
            table.Rows.Add("V008", "SUV", "Hyundai Tucson", 22m, "Modern SUV, comfortable interior");
            table.Rows.Add("V009", "Car", "Mazda 2", 14m, "Small city car, fuel saving");
            table.Rows.Add("V010", "Car", "BMW 3 Series", 40m, "Luxury sedan, premium comfort");
            table.Rows.Add("V011", "Motorbike", "Suzuki GSX", 10m, "Sport motorbike, fast acceleration");
            table.Rows.Add("V012", "Truck", "Isuzu D-Max", 27m, "Pickup truck, heavy duty");
            table.Rows.Add("V013", "Car", "Kia Picanto", 12m, "Compact hatchback, easy parking");
            table.Rows.Add("V014", "SUV", "Nissan X-Trail", 23m, "Family SUV, spacious cabin");
            table.Rows.Add("V015", "Van", "Ford Transit", 32m, "Large van, suitable for groups");
            table.Rows.Add("V016", "Motorbike", "Honda Dream", 4m, "Manual motorbike, fuel efficient");
            table.Rows.Add("V017", "Car", "Tesla Model 3", 45m, "Electric car, advanced technology");
            table.Rows.Add("V018", "SUV", "Lexus RX350", 50m, "Luxury SUV, smooth and quiet ride");
            table.Rows.Add("V019", "Truck", "Toyota Tundra", 35m, "Full-size truck, powerful performance");
            table.Rows.Add("V020", "Car", "Chevrolet Malibu", 20m, "Mid-size sedan, comfortable seats");

            return table;
        }

        public void ShowAddDialog(IWin32Window owner)
        {
            MessageBox.Show(owner, "Show Add Vehicle Dialog here.");
        }
    }
}