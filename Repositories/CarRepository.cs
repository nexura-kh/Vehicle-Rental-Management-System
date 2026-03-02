using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Management_System.factories;
using Vehicle_Rental_Management_System.Interfaces;

namespace Vehicle_Rental_Management_System.Repositories
{
    internal class CarRepository
    {

       List<IVehicle> vehicles=new List<IVehicle>();
        
        public void CarInit()
        {
            VehicleCreator creator = new CarCreator();
            IVehicle car = creator.OrderVehicle(
                "001",
                "BMW",
                "Truck",
                "AVAILABLE"
                );



            IVehicle truckCar = creator.OrderVehicle(
                "002",
                "Toyota",
                "Van",
                "LOCKED"


                );



            IVehicle Car1 = creator.OrderVehicle(
                "003",
                "Honda",
                "Van",
                "LOCKED"

                );

           vehicles.Add( car );
           vehicles.Add ( truckCar );
           vehicles.Add( Car1 );
             
        }




    }
}
