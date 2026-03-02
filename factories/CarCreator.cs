using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Management_System.Interfaces;
using Vehicle_Rental_Management_System.Models;

namespace Vehicle_Rental_Management_System.factories
{
    internal class CarCreator : VehicleCreator
    {
        public override IVehicle CreateVehicle()=> new Car();

    }
}
