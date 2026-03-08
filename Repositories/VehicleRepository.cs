using System.Collections.Generic;
using System.Linq;
using Vehicle_Rental_Management_System.Models;

namespace Vehicle_Rental_Management_System.Repositories
{
    public class VehicleRepository
    {
        private static List<Vehicle> vehicles = new List<Vehicle>();

        public void Init()
        {
            if (vehicles.Count > 0) return;

            vehicles.Add(new Vehicle(1, "SUV", "Toyota Highlander", 120.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(2, "Sedan", "Mercedes Benz C200", 90.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(3, "SUV", "Honda CR-V", 100.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(4, "Sedan", "BMW 320i", 110.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(5, "Truck", "Ford Ranger", 80.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(6, "Van", "Toyota HiAce", 70.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(7, "Motorbike", "Honda CBR500", 30.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(8, "E-Bike", "Yamaha E-Vino", 20.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(9, "SUV", "Mitsubishi Pajero", 130.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(10, "Sedan", "Toyota Camry", 95.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(11, "SUV", "Mazda CX-5", 105.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(12, "Sedan", "Honda Accord", 85.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(13, "Truck", "Mitsubishi Triton", 75.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(14, "Van", "Nissan Urvan", 65.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(15, "Motorbike", "Yamaha R15", 35.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(16, "E-Bike", "Honda PCX Electric", 25.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(17, "SUV", "Ford Everest", 125.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(18, "Sedan", "Nissan Almera", 80.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(19, "SUV", "Hyundai Tucson", 100.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(20, "Sedan", "Kia Cerato", 88.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(21, "Truck", "Isuzu D-Max", 78.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(22, "Van", "Mercedes Sprinter", 90.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(23, "Motorbike", "Kawasaki Ninja 400", 40.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(24, "E-Bike", "Vespa Elettrica", 28.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(25, "SUV", "Chevrolet Trailblazer", 115.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(26, "Sedan", "Toyota Vios", 75.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(27, "SUV", "Subaru Forester", 108.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(28, "Sedan", "Honda City", 70.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(29, "Truck", "Toyota Hilux", 82.0, VehicleStatus.Available));
            vehicles.Add(new Vehicle(30, "Van", "Ford Transit", 68.0, VehicleStatus.Available));
        }

        public List<Vehicle> GetAll()
        {
            return vehicles;
        }

        public static Vehicle GetById(int id)
        {
            return vehicles.FirstOrDefault(v => v.id == id);
        }

        public Vehicle GetByModel(string model)
        {
            return vehicles.FirstOrDefault(v => v.model == model);
        }

        public int GetNextId()
        {
            if (vehicles.Count == 0)
                return 1;

            return vehicles.Max(v => v.id) + 1;
        }

        public void Add(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void Delete(int id)
        {
            var vehicle = vehicles.FirstOrDefault(v => v.id == id);
            if (vehicle != null)
            {
                vehicles.Remove(vehicle);
            }
        }

        public void Update(Vehicle updatedVehicle)
        {
            var vehicle = vehicles.FirstOrDefault(v => v.id == updatedVehicle.id);
            if (vehicle != null)
            {
                vehicle.model = updatedVehicle.model;
                vehicle.type = updatedVehicle.type;
                vehicle.price = updatedVehicle.price;
                vehicle.status = updatedVehicle.status;
            }
        }
    }
}