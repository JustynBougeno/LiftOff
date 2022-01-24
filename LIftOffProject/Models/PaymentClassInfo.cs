using System;
namespace LIftOffProject.Models
{
    public class PaymentClassInfo
    {

        public int cardNumber { get; set; }
        public string streetAddress { get; set; }
        public int expDate { get; set; }
        public int secCode { get; set; }
        public string billAddress { get; set; }

        public CustomerClass customerClass { get; set; }
        public PaymentClassInfo paymentClassInfo { get; set; }
        public ProductInfoClass productInfoClass { get; set; }



        public PaymentClassInfo()
        {
        }
    }
}
