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

            // ── Customers ──────────────────────────────────────────────────────────
            var customers = new List<Customer>
    {
        new Customer(1,  "Kong",   "Ching",   "Malaysia", "0123456789"),
        new Customer(2,  "Ali",    "Hassan",  "Malaysia", "0112345678"),
        new Customer(3,  "Wei",    "Lim",     "China",    "0198765432"),
        new Customer(4,  "Sarah",  "Jones",   "UK",       "0134567890"),
        new Customer(5,  "Ahmed",  "Khalid",  "UAE",      "0145678901"),
        new Customer(6,  "Priya",  "Sharma",  "India",    "0156789012"),
        new Customer(7,  "John",   "Smith",   "USA",      "0167890123"),
        new Customer(8,  "Yuki",   "Tanaka",  "Japan",    "0178901234"),
        new Customer(9,  "Carlos", "Reyes",   "Mexico",   "0189012345"),
        new Customer(10, "Emma",   "Muller",  "Germany",  "0190123456"),
    };
            foreach (var c in customers)
                customerRepository.createCustomer(c);

            // ── Vehicles (must match VehicleRepository IDs & prices) ───────────────
            var vehicles = new List<Vehicle>
    {
        new Vehicle(1,  "SUV",       "Toyota Highlander",  120.0, VehicleStatus.Available),
        new Vehicle(2,  "Sedan",     "Mercedes Benz C200",  90.0, VehicleStatus.Available),
        new Vehicle(3,  "SUV",       "Honda CR-V",         100.0, VehicleStatus.Available),
        new Vehicle(4,  "Sedan",     "BMW 320i",           110.0, VehicleStatus.Available),
        new Vehicle(5,  "Truck",     "Ford Ranger",         80.0, VehicleStatus.Available),
        new Vehicle(6,  "Van",       "Toyota HiAce",        70.0, VehicleStatus.Available),
        new Vehicle(7,  "Motorbike", "Honda CBR500",        30.0, VehicleStatus.Available),
        new Vehicle(8,  "E-Bike",    "Yamaha E-Vino",       20.0, VehicleStatus.Available),
        new Vehicle(9,  "SUV",       "Mitsubishi Pajero",  130.0, VehicleStatus.Available),
        new Vehicle(10, "Sedan",     "Toyota Camry",        95.0, VehicleStatus.Available),
    };

            // ── Seeds: (bookingId, customerIdx, vehicleIdx, duration, daysAgo, paymentStatus) ──
            var seeds = new (int bId, int cIdx, int vIdx, int dur, int daysAgo, PaymentStatus ps)[]
            {
        (1,  0, 0, 3,  0,  PaymentStatus.Pending),
        (2,  1, 1, 5,  10, PaymentStatus.Paid),
        (3,  2, 2, 2,  20, PaymentStatus.Paid),
        (4,  3, 3, 7,  30, PaymentStatus.Pending),
        (5,  4, 4, 1,  5,  PaymentStatus.Paid),
        (6,  5, 5, 4,  15, PaymentStatus.Paid),
        (7,  6, 6, 3,  25, PaymentStatus.Paid),
        (8,  7, 7, 6,  35, PaymentStatus.Pending),
        (9,  8, 8, 2,  8,  PaymentStatus.Paid),
        (10, 9, 9, 5,  18, PaymentStatus.Paid),
        (11, 0, 1, 3,  28, PaymentStatus.Pending),
        (12, 1, 2, 4,  12, PaymentStatus.Paid),
        (13, 2, 3, 7,  22, PaymentStatus.Pending),
        (14, 3, 4, 1,  3,  PaymentStatus.Paid),
        (15, 4, 5, 2,  45, PaymentStatus.Paid),
        (16, 5, 6, 5,  50, PaymentStatus.Paid),
        (17, 6, 7, 3,  6,  PaymentStatus.Pending),
        (18, 7, 8, 4,  16, PaymentStatus.Paid),
        (19, 8, 9, 6,  26, PaymentStatus.Pending),
        (20, 9, 0, 2,  36, PaymentStatus.Paid),
        (21, 0, 3, 3,  9,  PaymentStatus.Paid),
        (22, 1, 4, 5,  19, PaymentStatus.Pending),
        (23, 2, 5, 1,  29, PaymentStatus.Paid),
        (24, 3, 6, 7,  11, PaymentStatus.Paid),
        (25, 4, 7, 4,  21, PaymentStatus.Pending),
        (26, 5, 8, 2,  31, PaymentStatus.Paid),
        (27, 6, 9, 3,  7,  PaymentStatus.Paid),
        (28, 7, 0, 6,  17, PaymentStatus.Pending),
        (29, 8, 1, 5,  27, PaymentStatus.Paid),
        (30, 9, 2, 1,  4,  PaymentStatus.Paid),
        (31, 0, 4, 3,  60, PaymentStatus.Paid),
        (32, 1, 5, 4,  55, PaymentStatus.Paid),
        (33, 2, 6, 2,  48, PaymentStatus.Pending),
        (34, 3, 7, 5,  43, PaymentStatus.Paid),
        (35, 4, 8, 7,  38, PaymentStatus.Pending),
        (36, 5, 9, 3,  33, PaymentStatus.Paid),
        (37, 6, 0, 1,  23, PaymentStatus.Paid),
        (38, 7, 1, 4,  13, PaymentStatus.Pending),
        (39, 8, 2, 6,  2,  PaymentStatus.Paid),
        (40, 9, 3, 2,  42, PaymentStatus.Paid),
        (41, 0, 5, 5,  37, PaymentStatus.Pending),
        (42, 1, 6, 3,  32, PaymentStatus.Paid),
        (43, 2, 7, 4,  14, PaymentStatus.Paid),
        (44, 3, 8, 7,  24, PaymentStatus.Pending),
        (45, 4, 9, 2,  34, PaymentStatus.Paid),
        (46, 5, 0, 3,  44, PaymentStatus.Paid),
        (47, 6, 1, 1,  54, PaymentStatus.Paid),
        (48, 7, 2, 5,  49, PaymentStatus.Pending),
        (49, 8, 3, 4,  39, PaymentStatus.Paid),
        (50, 9, 4, 6,  29, PaymentStatus.Pending),
            };

            foreach (var (bId, cIdx, vIdx, dur, daysAgo, ps) in seeds)
            {
                var customer = customers[cIdx];
                var vehicle = vehicles[vIdx];
                var startDate = DateTime.Now.AddDays(-daysAgo);
                var endDate = startDate.AddDays(dur);
                var amount = vehicle.price * dur;   // auto-calculated ✅
                var payment = new Payment(bId, amount, ps);

                bookings.Add(new Booking(bId, customer, vehicle, payment, startDate, endDate, dur));
            }
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