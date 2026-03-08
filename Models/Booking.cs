using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System.Models
{
    public class Booking {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }
        public Payment Payment { get; set; }

        public Booking(
            int id,
            Customer customer,
            Vehicle vehicle,
            Payment payment,
            DateTime startDate,
            DateTime endDate,
            int duration)
        {
            Customer = customer;
            Vehicle = vehicle;
            Payment = payment;
            StartDate = startDate;
            EndDate = endDate;
            Id = id;
            Duration = duration;
        }

    


    }
}
