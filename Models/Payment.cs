using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System.Models
{
    public class Payment
    {

        public int Id { get; set; }

        public double Amount { get; set; }

        public PaymentStatus status { get; set; }
        public DateTime PaymentDate { get; set; }
        public Payment(int id, double amount, DateTime paymentDate)
        {
            Id = id;
            Amount = amount;
            PaymentDate = paymentDate;
        }
    }
}
