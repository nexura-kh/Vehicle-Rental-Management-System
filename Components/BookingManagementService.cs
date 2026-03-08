using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Vehicle_Rental_Management_System.Forms;
using Vehicle_Rental_Management_System.Helpers;
using Vehicle_Rental_Management_System.Interfaces;
using Vehicle_Rental_Management_System.Models;
using Vehicle_Rental_Management_System.Repositories;

namespace Vehicle_Rental_Management_System.Components
{
    public class BookingManagementService : IManagementService
    {
        private readonly BookingRepository bookingRepository = new BookingRepository();
        private readonly VehicleRepository vehicleRepository = new VehicleRepository();

        public string Title => "Booking Management";

        public bool CanAdd => true;
        public bool CanEdit => true;
        public bool CanDelete => true;

        public void DeleteRecord(object selectedId)
        {
            if (selectedId == null)
            {
                MessageBox.Show("Please select a booking to delete.");
                return;
            }

            int id = Convert.ToInt32(selectedId);

            bookingRepository.Delete(id);

            MessageBox.Show($"Booking ID {id} deleted successfully.");
        }

        public List<ColumnDefinition> GetColumns()
        {
            return new List<ColumnDefinition>
            {
                new ColumnDefinition { HeaderText = "ID", DataPropertyName = "bookingId", Width = 60 },
                new ColumnDefinition { HeaderText = "Customer", DataPropertyName = "customer", Width = 150 },
                new ColumnDefinition { HeaderText = "Type", DataPropertyName = "type", Width = 120 },
                new ColumnDefinition { HeaderText = "Vehicle", DataPropertyName = "vehicle", Width = 120 },
                new ColumnDefinition { HeaderText = "Start Date", DataPropertyName = "startDate", Width = 120 },
                new ColumnDefinition { HeaderText = "End Date", DataPropertyName = "endDate", Width = 120 },
                new ColumnDefinition { HeaderText = "Duration", DataPropertyName = "duration", Width = 80 }
            };
        }

        public DataTable GetData()
        {
            DataTable table = new DataTable();

            table.Columns.Add("bookingId", typeof(int));
            table.Columns.Add("customer", typeof(string));
            table.Columns.Add("type", typeof(string));
            table.Columns.Add("vehicle", typeof(string));
            table.Columns.Add("startDate", typeof(DateTime));
            table.Columns.Add("endDate", typeof(DateTime));
            table.Columns.Add("duration", typeof(int));

            bookingRepository.Init();

            List<Booking> bookings = BookingRepository.bookings;

            foreach (Booking booking in bookings)
            {
                table.Rows.Add(
                    booking.Id,
                    booking.Customer.FirstName + booking.Customer.LastName,
                    booking.Vehicle.type,
                    booking.Vehicle.model,
                    booking.StartDate,
                    booking.EndDate,
                    booking.Duration
                );
            }
            return table;
        }

        public void ShowAddDialog(IWin32Window owner)
        {
            using (var form = new BookingDialog())
            {
                if (form.ShowDialog(owner) == DialogResult.OK)
                {
                    int nextId = bookingRepository.GetNextId();

                    var customer = new Customer(
                        nextId,
                        form.FirstName,
                        form.LastName,
                        form.Nationality,
                        form.Phone
                    );
                    
                    Vehicle vehicle = vehicleRepository.GetByModel(form.VehicleModel);
                    
                    DateTime startDate = form.StartDate;
                    DateTime endDate = form.EndDate;

                    var payment = new Payment(
                       nextId,
                       vehicle.price * form.Duration,
                       PaymentStatus.Pending
                    );

                    int duration = (endDate - startDate).Days;

                    var booking = new Booking(
                        nextId,
                        customer,
                        vehicle,
                        payment,
                        startDate,
                        endDate,
                        duration
                    );

                    bookingRepository.Add(booking);

                    MessageBox.Show("Booking added successfully.");
                }
            }
        }

        public void ShowEditDialog(IWin32Window owner, object selectedId)
        {
            if (selectedId == null)
            {
                MessageBox.Show("Please select a booking to edit.");
                return;
            }

            int id = Convert.ToInt32(selectedId);

            var booking = bookingRepository.GetById(id);

            if (booking == null)
            {
                MessageBox.Show("Booking not found.");
                return;
            }

            using (var form = new BookingDialog(booking))
            {
                if (form.ShowDialog(owner) == DialogResult.OK)
                {
                    booking.Customer.FirstName = form.FirstName;
                    booking.Customer.LastName = form.LastName;
                    booking.Customer.Nationality = form.Nationality;
                    booking.Customer.PhoneNumber = form.Phone;

                    booking.Vehicle.model = form.VehicleModel;

                    booking.StartDate = form.StartDate;
                    booking.EndDate = form.EndDate;
                    booking.Duration = form.Duration;
                    booking.Payment.Amount = form.Price;

                    bookingRepository.Update(booking);
                }
            }
        }
    }
}