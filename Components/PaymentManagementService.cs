using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vehicle_Rental_Management_System.Helpers;
using Vehicle_Rental_Management_System.Interfaces;

namespace Vehicle_Rental_Management_System.Components
{
    public class PaymentManagementService : IManagementService
    {
        public string Title => "Payment Management";

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
                new ColumnDefinition { HeaderText = "Booking ID", DataPropertyName = "bookingId", Width = 100 },
                new ColumnDefinition { HeaderText = "Amount ($)", DataPropertyName = "amount", Width = 100 },
                new ColumnDefinition { HeaderText = "Method", DataPropertyName = "paymentMethod", Width = 120 },
                new ColumnDefinition { HeaderText = "Payment Date", DataPropertyName = "paymentDate", Width = 140 },
                new ColumnDefinition { HeaderText = "Status", DataPropertyName = "paymentStatus", Width = 100 }
            };
        }

        public DataTable GetData()
        {
            DataTable table = new DataTable();

            table.Columns.Add("paymentId", typeof(string));
            table.Columns.Add("bookingId", typeof(string));
            table.Columns.Add("amount", typeof(decimal));
            table.Columns.Add("paymentMethod", typeof(string));
            table.Columns.Add("paymentDate", typeof(DateTime));
            table.Columns.Add("paymentStatus", typeof(string));

            table.Rows.Add("P001", "B001", 120m, "Cash", new DateTime(2026, 3, 1), "Paid");
            table.Rows.Add("P002", "B002", 150m, "Credit Card", new DateTime(2026, 3, 2), "Paid");
            table.Rows.Add("P003", "B003", 200m, "ABA Pay", new DateTime(2026, 3, 3), "Paid");
            table.Rows.Add("P004", "B004", 80m, "Cash", new DateTime(2026, 3, 4), "Pending");
            table.Rows.Add("P005", "B005", 175m, "Wing", new DateTime(2026, 3, 5), "Paid");
            table.Rows.Add("P006", "B006", 300m, "Credit Card", new DateTime(2026, 3, 6), "Paid");
            table.Rows.Add("P007", "B007", 210m, "ABA Pay", new DateTime(2026, 3, 7), "Pending");
            table.Rows.Add("P008", "B008", 195m, "Cash", new DateTime(2026, 3, 8), "Paid");
            table.Rows.Add("P009", "B009", 160m, "Wing", new DateTime(2026, 3, 9), "Paid");
            table.Rows.Add("P010", "B010", 350m, "Credit Card", new DateTime(2026, 3, 10), "Paid");

            return table;
        }

        public void ShowAddDialog(IWin32Window owner)
        {
            MessageBox.Show(owner, "Show Add Payment Dialog here.");
        }
    }
}