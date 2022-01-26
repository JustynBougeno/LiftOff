using System;
using LiftOffProject.Models;

namespace LiftOffProject.Models
{
    public class CustomerClass
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string eMail { get; set; }
        public string phoneNumber { get; set; }

        public int customerId { get; set; }
        public int Id { get; set; }
        
        public Address address { get; set; }

        public PaymentClassInfo paymentClassInfo { get; set; }
        //public OrderClass orderClass { get; set; }
        //public ProductInfoClass productInfoClass { get; set; }

        public CustomerClass()
        {
        }
    }
}

