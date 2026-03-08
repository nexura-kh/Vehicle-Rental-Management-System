using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vehicle_Rental_Management_System.Forms;
using Vehicle_Rental_Management_System.Helpers;
using Vehicle_Rental_Management_System.Interfaces;
using Vehicle_Rental_Management_System.Models;
using Vehicle_Rental_Management_System.Repositories;

namespace Vehicle_Rental_Management_System.Components
{
    internal class VehicleManagementService : IManagementService
    {
        private readonly VehicleRepository vehicleRepository = new VehicleRepository();

        public string Title => "Vehicle Management";
        public bool CanAdd => true;
        public bool CanEdit => true;
        public bool CanDelete => true;

        public List<ColumnDefinition> GetColumns()
        {
            return new List<ColumnDefinition>
            {
                new ColumnDefinition { HeaderText = "ID", DataPropertyName = "vehicleId", Width = 80 },
                new ColumnDefinition { HeaderText = "Type", DataPropertyName = "vehicleType", Width = 120 },
                new ColumnDefinition { HeaderText = "Name", DataPropertyName = "vehicleName", Width = 150 },
                new ColumnDefinition { HeaderText = "Price/Hour ($)", DataPropertyName = "pricePerHour", Width = 110 },
                new ColumnDefinition { HeaderText = "Status", DataPropertyName = "vehicleStatus", Width = 200 }
            };
        }

        public DataTable GetData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("vehicleId", typeof(string));
            table.Columns.Add("vehicleType", typeof(string));
            table.Columns.Add("vehicleName", typeof(string));
            table.Columns.Add("pricePerHour", typeof(decimal));
            table.Columns.Add("vehicleStatus", typeof(string));

            vehicleRepository.Init();

            foreach (var vehicle in vehicleRepository.GetAll())
            {
                table.Rows.Add(
                    vehicle.id,
                    vehicle.type,
                    vehicle.model,
                    vehicle.price,
                    vehicle.status
                );
            }

            return table;
        }

        public void ShowAddDialog(IWin32Window owner)
        {
            using (var form = new VehicleDialog())
            {
                if (form.ShowDialog(owner) == DialogResult.OK)
                {
                    int nextId = vehicleRepository.GetNextId();
                   Vehicle vehicle= new Vehicle(nextId, form.VehicleType, form.VehicleName, (double)form.PricePerHour,2);
                   
                    vehicleRepository.Add(vehicle);
                }
            }
        }

        public void ShowEditDialog(IWin32Window owner, object selectedId)
        {
            if (selectedId == null)
            {
                MessageBox.Show("Please select a vehicle to edit.");
                return;
            }

            if (!int.TryParse(selectedId.ToString(), out int vehicleId))
            {
                MessageBox.Show("Invalid vehicle ID.");
                return;
            }

            var vehicle = VehicleRepository.GetById(vehicleId);
            if (vehicle == null)
            {
                MessageBox.Show("Vehicle not found.");
                return;
            }

            using (var form = new VehicleDialog(vehicle))
            {
                if (form.ShowDialog(owner) == DialogResult.OK)
                {
                    vehicleRepository.Update(vehicle); 
                }
            }
        }

        public void DeleteRecord(object selectedId)
        {
            if (selectedId == null)
            {
                MessageBox.Show("Please select a vehicle to delete.");
                return;
            }

            int vehicleId;
            if (selectedId is int id)
            {
                vehicleId = id;
            }
            else if (!int.TryParse(selectedId.ToString(), out vehicleId))
            {
                MessageBox.Show("Invalid vehicle ID.");
                return;
            }

            var vehicle = VehicleRepository.GetById(vehicleId);
            if (vehicle == null)
            {
                MessageBox.Show("Vehicle not found.");
                return;
            }

            vehicleRepository.Delete(vehicleId);
        }
    }
}