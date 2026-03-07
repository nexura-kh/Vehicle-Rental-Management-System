using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vehicle_Rental_Management_System.Helpers;
using Vehicle_Rental_Management_System.Interfaces;
using Vehicle_Rental_Management_System.Repositories;

namespace Vehicle_Rental_Management_System.Components
{
    internal class VehicleManagementService : IManagementService
    {

        CarRepository carRepository=new CarRepository();

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
                new ColumnDefinition { HeaderText = "Description", DataPropertyName = "vehicleDescription", Width = 200 },
                new ColumnDefinition { HeaderText = "Vehicle state", DataPropertyName = "vehicleState", Width = 200 }

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
            table.Columns.Add("vehicleState", typeof(string));

            carRepository.CarInit();


            foreach (IVehicle car in carRepository.vehicles)
            {
                table.Rows.Add(car.id,car.type, car.model, car.price,car.description,car.VehicleState);
            }

            Console.WriteLine("Hello world");


            return table;
        }

        public void ShowAddDialog(IWin32Window owner)
        {
            MessageBox.Show(owner, "Show Add Vehicle Dialog here.");
        }
    }
}