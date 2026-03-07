using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System.Interfaces
{
    public interface IPerson
    {
        string Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Nationality { get; set; }
        string PhoneNumber { get; set; }


    }
}
