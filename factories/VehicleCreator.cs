using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Management_System.Interfaces;

namespace Vehicle_Rental_Management_System.factories
{
    internal abstract class VehicleCreator
    {

        public abstract IVehicle CreateVehicle();

        public IVehicle OrderVehicle(string id,string model,string type,string VehicleState,double price,string description)
        {
            Console.WriteLine("Vehicle Order Revieved");

            IVehicle vehicle =this.CreateVehicle();
            vehicle.id = id;
            vehicle.model = model;
            vehicle.type = type;
            vehicle.VehicleState=VehicleState;
            vehicle.price = price;
            vehicle.description = description;

            vehicle.DisplayInfo();

            return vehicle;
        }
    }
}
