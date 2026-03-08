using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vehicle_Rental_Management_System.Forms;
using Vehicle_Rental_Management_System.Helpers;
using Vehicle_Rental_Management_System.Interfaces;
using Vehicle_Rental_Management_System.Models;
using Vehicle_Rental_Management_System.Repositories;

namespace Vehicle_Rental_Management_System.Components
{
    public class PaymentManagementService : IManagementService
    {
        private readonly BookingRepository bookingRepository = new BookingRepository();
        public string Title => "Payment Management";

        public bool CanAdd => false;

        public bool CanEdit => true;

        public bool CanDelete => false;

    public void DeleteRecord(object selectedId)
        {
            if (selectedId == null)
            {
                MessageBox.Show("Please select a payment to delete.");
                return;
            }

            MessageBox.Show($"Payment with ID {selectedId} deleted successfully.");
        }

        public List<ColumnDefinition> GetColumns()
        {
            return new List<ColumnDefinition>
            {
                new ColumnDefinition { HeaderText = "Payment ID", DataPropertyName = "paymentId", Width = 100 },
                new ColumnDefinition { HeaderText = "Customer", DataPropertyName = "customer", Width = 100 },
                new ColumnDefinition { HeaderText = "Type", DataPropertyName = "type", Width = 100 },
                new ColumnDefinition { HeaderText = "Model", DataPropertyName = "model", Width = 100 },
                new ColumnDefinition { HeaderText = "Duration", DataPropertyName = "duration", Width = 100 },
                new ColumnDefinition { HeaderText = "Amount ($)", DataPropertyName = "amount", Width = 100 },
                new ColumnDefinition { HeaderText = "Payment Date", DataPropertyName = "paymentDate", Width = 140 },
                new ColumnDefinition { HeaderText = "Status", DataPropertyName = "paymentStatus", Width = 100 }
            };
        }

        public DataTable GetData()
        {
            DataTable table = new DataTable();

            table.Columns.Add("paymentId", typeof(string));
            table.Columns.Add("customer", typeof(string));
            table.Columns.Add("type", typeof(string));
            table.Columns.Add("model", typeof(string));
            table.Columns.Add("duration", typeof(int));
            table.Columns.Add("amount", typeof(decimal));
            table.Columns.Add("paymentDate", typeof(DateTime));
            table.Columns.Add("paymentStatus", typeof(string));

            bookingRepository.Init();

            List<Booking> bookings = BookingRepository.bookings;

            foreach (Booking booking in bookings)
            {
                table.Rows.Add(
                    booking.Payment.Id,
                    booking.Customer.FirstName + booking.Customer.LastName,
                    booking.Vehicle.type,
                    booking.Vehicle.model,
                    booking.Duration,
                    booking.Payment.Amount,
                    booking.Payment.PaymentDate,
                    booking.Payment.Status
                );
            }
            return table;
        }

        public void ShowAddDialog(IWin32Window owner)
        {
            MessageBox.Show(owner, "Show Add Payment Dialog here.");
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

            using (var form = new PaymentDialog(booking.Payment))
            {
                if (form.ShowDialog(owner) == DialogResult.OK)
                {
                    booking.Payment.PaymentDate = form.PaymentDate;
                    booking.Payment.Status = form.PaymentStatus;
                    bookingRepository.Update(booking);
                }
            }
        }
    }
}