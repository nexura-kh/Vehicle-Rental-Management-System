using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Management_System.Interfaces;
using Vehicle_Rental_Management_System.Helpers;
using System.Data;
using Vehicle_Rental_Management_System.Repositories;
using Vehicle_Rental_Management_System.Models;

namespace Vehicle_Rental_Management_System.Components
{
    public class CustomerManagementService : IManagementService
    {

        CustomerRepository customerRepository=new CustomerRepository();
        BookingRepository bookingRepository=new BookingRepository();

        public string Title => "Customer Management";

        public bool CanAdd => false;

        public bool CanEdit => false;

        public bool CanDelete => false;

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

            table.Columns.Add("CustomerId", typeof(int));
            table.Columns.Add("firstName", typeof(string));
            table.Columns.Add("lastName", typeof(string));
            table.Columns.Add("Nationality", typeof(string));
            table.Columns.Add("phone", typeof(string));

            bookingRepository.Init();

            foreach (var cus in bookingRepository.GetAll())
            {
                table.Rows.Add(cus.Id, cus.Customer.FirstName, cus.Customer.LastName, cus.Customer.Nationality, cus.Customer.PhoneNumber);
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

        public void ShowEditDialog(IWin32Window owner, object selectedId)
        {
            throw new NotImplementedException();
        }
    }
}
