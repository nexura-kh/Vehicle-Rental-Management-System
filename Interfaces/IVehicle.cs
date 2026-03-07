using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System.Interfaces
{
    public interface IVehicle
    {
     public   string id { get; set; }
     public   string model { get; set; }
    public    string type { get; set; }

     public   string VehicleState { get; set; }

    public double price { get; set; }

    public string description { get; set; }


        public  void Start();
      public  void Stop();
      public void DisplayInfo();



    }
}
