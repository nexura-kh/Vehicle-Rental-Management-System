using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Management_System.Interfaces;

namespace Vehicle_Rental_Management_System.Models
{
     public class Customer : IPerson
    {

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Nationality {  get; set; }

        public string PhoneNumber { get; set; }
    
    }
}
