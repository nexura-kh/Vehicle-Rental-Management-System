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
        public PaymentStatus Status { get; set; }
        public DateTime PaymentDate { get; set; }
        public Payment(int id, double amount, PaymentStatus status)
        {
            Id = id;
            Amount = amount;
            Status = status;
            //PaymentDate = paymentDate;
        }
    }
}
