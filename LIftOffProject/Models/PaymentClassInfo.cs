using System;
namespace LiftOffProject.Models
{
    public class PaymentClassInfo
    {

        public int cardNumber { get; set; }
        public string streetAddress { get; set; }
        public int expDate { get; set; }
        public int secCode { get; set; }

        public int customerId { get; set; }
        public int Id { get; set; }
        //public string billingAddress { get; set; }

        public PaymentClassInfo()
        {
        }
    }
}
