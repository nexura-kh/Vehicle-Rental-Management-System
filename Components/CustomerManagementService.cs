using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Management_System.Interfaces;
using Vehicle_Rental_Management_System.Helpers;
using System.Data;

namespace Vehicle_Rental_Management_System.Components
{
    public class CustomerManagementService : IManagementService
    {
        public string Title => "Customer Management";

        public List<ColumnDefinition> GetColumns()
        {
            return new List<ColumnDefinition>
            {
                new ColumnDefinition { HeaderText = "ID", DataPropertyName = "CustomerId", Width = 60 },
                new ColumnDefinition { HeaderText = "First Name", DataPropertyName = "firstName", Width = 150 },
                new ColumnDefinition { HeaderText = "Last Name", DataPropertyName = "lastName", Width = 120 },
                new ColumnDefinition { HeaderText = "Nationality", DataPropertyName = "nationality", Width = 120 },
                new ColumnDefinition { HeaderText = "Phone", DataPropertyName = "phone", Width = 120 }
            };
        }

        public DataTable GetData()
        {
            DataTable table = new DataTable();

            // Define proper data types
            table.Columns.Add("CustomerId", typeof(int));
            table.Columns.Add("firstName", typeof(string));
            table.Columns.Add("lastName", typeof(string));
            table.Columns.Add("Nationality", typeof(string));
            table.Columns.Add("phone", typeof(string));

            string[] firstNames = { "John", "Jane", "Michael", "Sarah", "David", "Emma", "Chris", "Sophia", "Daniel", "Olivia" };
            string[] lastNames = { "Smith", "Johnson", "Brown", "Williams", "Jones", "Garcia", "Miller", "Davis", "Wilson", "Taylor" };
            string[] nationalities = { "Cambodian", "American", "French", "Japanese", "Korean", "Thai", "Vietnamese", "Chinese", "Australian", "Canadian" };

            Random rand = new Random();

            for (int i = 1; i <= 100; i++)
            {
                string firstName = firstNames[rand.Next(firstNames.Length)];
                string lastName = lastNames[rand.Next(lastNames.Length)];
                string nationality = nationalities[rand.Next(nationalities.Length)];
                string phone = "0" + rand.Next(10000000, 99999999).ToString();

                table.Rows.Add(i, firstName, lastName, nationality, phone);
            }

            return table;
        }

        public void ShowAddDialog(IWin32Window owner)
        {
            MessageBox.Show(owner, "Show Add Customer Dialog here");
        }
        public void DeleteRecord(object selectedId)
        {
            MessageBox.Show($"Delete Customer ID: {selectedId}");
        }
    }
}
