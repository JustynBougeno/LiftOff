using System;
namespace LIftOffProject.Models
{
    public class CustomerClass
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string streetAddress { get; set; }
        public string eMail { get; set; }
        public string phoneNumber { get; set; }

        public PaymentClassInfo paymentClassInfo { get; set; }
        //public OrderClass orderClass { get; set; }
        //public ProductInfoClass productInfoClass { get; set; }

        public CustomerClass()
        {
        }
    }
}

