using System;
namespace LIftOffProject.Models
{
    public class OrderClass
    {
        public string orderStatus { get; set; }
        public string orderInfo { get; set; }
        public string orderAmount { get; set; }
          
        public CustomerClass customerClass { get; set; }
        //public PaymentClassInfo paymentInfo { get; set; }
        public ProductInfoClass productInfoClass { get; set; }

        public OrderClass()
        {
        }
    }
}
