using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System.Models
{
    public class Booking
    {

        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public Payment Payment { get; set; }

    


        public Booking(
            int id,
            Customer customer,
            Vehicle vehicle,
            string startDate,
            string endDate,
            Payment payment)
        {
            Customer = customer;
            Vehicle = vehicle;
            StartDate = startDate;
            EndDate = endDate;
            Id = id;
            Payment = payment;
        }

    


    }
}
