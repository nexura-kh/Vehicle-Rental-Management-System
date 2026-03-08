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

            vehicles.Add(
              new Vehicle(1,"SUV", "High Lander", 12, VehicleStatus.Available)
            );

            vehicles.Add(
              new Vehicle(2,"Sedan","Mcedes Benz",12, VehicleStatus.Available)
            );
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