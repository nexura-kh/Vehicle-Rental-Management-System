using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Management_System.Helpers;
using Vehicle_Rental_Management_System.Interfaces;

namespace Vehicle_Rental_Management_System.Components
{
    public class BookingManagementService : IManagementService
    {
        public string Title => "Booking Management";

        public void DeleteRecord(object selectedId)
        {
            MessageBox.Show($"Delete Customer ID: {selectedId}");
        }

        public List<ColumnDefinition> GetColumns()
        {
            return new List<ColumnDefinition>
            {
                new ColumnDefinition { HeaderText = "ID", DataPropertyName = "bookingId", Width = 60 },
                new ColumnDefinition { HeaderText = "Customer", DataPropertyName = "customer", Width = 150 },
                new ColumnDefinition { HeaderText = "Vehicle", DataPropertyName = "vehicle", Width = 120 },
                new ColumnDefinition { HeaderText = "Start Date", DataPropertyName = "startDate", Width = 120 },
                new ColumnDefinition { HeaderText = "End Date", DataPropertyName = "EndDate", Width = 120 },
                new ColumnDefinition { HeaderText = "Duration", DataPropertyName = "duration", Width = 120 },
                new ColumnDefinition { HeaderText = "Payment Status", DataPropertyName = "paymentStatus", Width = 120 }
            };
        }

        public DataTable GetData()
        {
            DataTable table = new DataTable();

            table.Columns.Add("bookingId", typeof(string));
            table.Columns.Add("customer", typeof(string));
            table.Columns.Add("vehicle", typeof(string));
            table.Columns.Add("startDate", typeof(DateTime));
            table.Columns.Add("endDate", typeof(DateTime));
            table.Columns.Add("duration", typeof(int));
            table.Columns.Add("paymentStatus", typeof(string));

            table.Rows.Add("B001", "John Doe", "Toyota Corolla", new DateTime(2026, 3, 1), new DateTime(2026, 3, 3), 2, "Paid");
            table.Rows.Add("B002", "Anna Smith", "Honda Civic", new DateTime(2026, 3, 2), new DateTime(2026, 3, 5), 3, "Pending");
            table.Rows.Add("B003", "David Kim", "Ford Ranger", new DateTime(2026, 3, 3), new DateTime(2026, 3, 6), 3, "Paid");
            table.Rows.Add("B004", "Sok Dara", "Honda Click", new DateTime(2026, 3, 4), new DateTime(2026, 3, 5), 1, "Pending");
            table.Rows.Add("B005", "Linda Chen", "Yamaha NMAX", new DateTime(2026, 3, 5), new DateTime(2026, 3, 8), 3, "Paid");
            table.Rows.Add("B006", "Michael Lee", "Toyota Hiace", new DateTime(2026, 3, 6), new DateTime(2026, 3, 10), 4, "Paid");
            table.Rows.Add("B007", "Chris Brown", "Toyota Fortuner", new DateTime(2026, 3, 7), new DateTime(2026, 3, 9), 2, "Pending");
            table.Rows.Add("B008", "Emily Davis", "Hyundai Tucson", new DateTime(2026, 3, 8), new DateTime(2026, 3, 11), 3, "Paid");
            table.Rows.Add("B009", "Kevin White", "Mazda 2", new DateTime(2026, 3, 9), new DateTime(2026, 3, 12), 3, "Pending");
            table.Rows.Add("B010", "Sophia Green", "BMW 3 Series", new DateTime(2026, 3, 10), new DateTime(2026, 3, 15), 5, "Paid");

            return table;
        }

        public void ShowAddDialog(IWin32Window owner)
        {
            throw new NotImplementedException();
        }
    }
}
