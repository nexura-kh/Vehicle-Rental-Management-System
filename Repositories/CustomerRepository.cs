using System;
using System.Collections.Generic;
using System.Linq;
using Vehicle_Rental_Management_System.Interfaces;
using Vehicle_Rental_Management_System.Models;

namespace Vehicle_Rental_Management_System.Repositories
{
    public class CustomerRepository
    {
        public List<IPerson> customers = new List<IPerson>();

        public void customerInit()
        {
         
          
            customers.Add(new Customer(111, "Kong", "Ching", "Malaysia", "0123456789"));
            customers.Add(new Customer(222, "Kong", "Ching", "Malaysia", "0123456789"));

        }

        public Customer getCustomerById(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id) as Customer;
        }

        public void createCustomer(string id, string firstName, string lastName,
                                   string nationality, string phoneNumber)
        {
            if (GetCustomerById(id) != null)
            {
                throw new InvalidOperationException($"Customer with ID '{id}' already exists.");
            }

            //PersonCreator personCreator = new CustomerCreator();
            //IPerson newCustomer = personCreator.OrderPerson(id, firstName, lastName, nationality, phoneNumber);
            //customers.Add(newCustomer);
        }

        public IPerson GetCustomerById(string id)
        {
            
            return customers.FirstOrDefault(c => c.Id.ToString() == id);
        }

        public void updateCustomer(string id, string firstName, string lastName,
                                   string nationality, string phoneNumber)
        {
            var existing = GetCustomerById(id);
            if (existing == null)
            {
                throw new InvalidOperationException($"Customer with ID '{id}' not found.");
            }

            existing.FirstName = firstName;
            existing.LastName = lastName;
            existing.Nationality = nationality;
            existing.PhoneNumber = phoneNumber;
        }                           

        public void deleteCustomer(string id)
        {
            var existing = GetCustomerById(id);
            if (existing == null)
            {
                throw new InvalidOperationException($"Customer with ID '{id}' not found.");
            }

            customers.Remove(existing);
        }
    }
}