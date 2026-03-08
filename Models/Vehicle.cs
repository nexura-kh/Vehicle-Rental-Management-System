using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Management_System.Interfaces;

namespace Vehicle_Rental_Management_System.Models
{
    public class Vehicle : IVehicle
    {
        public int id { get; set; }
        public string model { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public double price { get; set; }
    }
}
