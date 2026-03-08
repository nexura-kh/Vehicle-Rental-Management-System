using System;
using System.Collections.Generic;
using System.Linq;
using Vehicle_Rental_Management_System.Models;

namespace Vehicle_Rental_Management_System.Repositories
{
    public class BookingRepository
    {
        public static List<Booking> bookings = new List<Booking>();

        public CustomerRepository customerRepository = new CustomerRepository();
        public void Init()
        {
            if (bookings.Count > 0) return;

            var customer = new Customer(1, "Kong", "Ching", "Malaysia", "0123456789");
            var vehicle = new Vehicle(1, "SUV", "High Lander", 20.0, VehicleStatus.Available);
            var payment = new Payment(1, 60.0,PaymentStatus.Pending);

            int duration = 3;

            customerRepository.createCustomer(customer);

            bookings.Add(
                new Booking(
                    1,
                    customer,
                    vehicle,
                    payment,
                    DateTime.Now,
                    DateTime.Now.AddDays(duration),
                    duration
                )
            );
        }

        public List<Booking> GetAll()
        {
            return bookings;
        }

        public Booking GetById(int id)
        {
            return bookings.FirstOrDefault(b => b.Id == id);
        }

        public int GetNextId()
        {
            if (bookings.Count == 0)
                return 1;

            return bookings.Max(b => b.Id) + 1;
        }

        public void Add(Booking booking)
        {
            if (booking == null)
                throw new ArgumentNullException(nameof(booking));

            bookings.Add(booking);
        }

        public void Delete(int id)
        {
            var booking = bookings.FirstOrDefault(b => b.Id == id);
            if (booking != null)
            {
                bookings.Remove(booking);
            }
        }

        public void Update(Booking updatedBooking)
        {
            var booking = bookings.FirstOrDefault(b => b.Id == updatedBooking.Id);

            if (booking != null)
            {
                booking.Customer = updatedBooking.Customer;
                booking.Vehicle = updatedBooking.Vehicle;
                booking.StartDate = updatedBooking.StartDate;
                booking.EndDate = updatedBooking.EndDate;
                booking.Duration = updatedBooking.Duration;
                booking.Payment = updatedBooking.Payment;
            }
        }
    }
}