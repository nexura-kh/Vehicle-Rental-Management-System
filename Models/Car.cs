
using Vehicle_Rental_Management_System.Interfaces;

namespace Vehicle_Rental_Management_System.Models
{
    internal class Car : IVehicle
    {

       public string id { get; set; }
      public  string model { get; set; }
      public  string type { get; set; }

        public double price { get; set; }

        public string description { get; set; }

      public  string VehicleState { get; set; }

      public  void Start()
        {
            Console.WriteLine("Car just starting now !!");
        }
      public  void Stop()
        {
            Console.WriteLine("Car just stoping now !!");
        }
       public void DisplayInfo()
        {
            Console.WriteLine("Just display in info!!!!");
        }

     


    }
}
