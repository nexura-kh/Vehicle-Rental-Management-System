using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Management_System.Models;

namespace Vehicle_Rental_Management_System.Repositories
{
    public class BookingRepository
    {

      public  List<Booking> bookings = new List<Booking>();

       
        
        
      
        public void bookingInit()
        {
            Customer customer = new Customer(111, "Kong", "Ching", "Malaysia", "0123456789");
            Vehicle vehicle = new Vehicle(111, "Toyota", "Camry", 20.0, 2);
             double totalAmount=vehicle.CalculateRentalCost();

            Payment payment1 = new Payment(111, totalAmount, DateTime.Now);

            Booking booking = new Booking(111, customer, vehicle, "12/2/2026","12/4/2026",payment1);

            bookings.Add(booking);




        }
    }
}
