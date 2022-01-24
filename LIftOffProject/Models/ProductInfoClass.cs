using System;
namespace LIftOffProject.Models
{
    public class ProductInfoClass
    {

        public string productName { get; set; }
        public string productId { get; set; }
        public string productCatogory { get; set; }
        public string productManufacture { get; set; }
        public string productSeller { get; set; }
        public string productPrice { get; set; }

        public PaymentClassInfo paymentInfo { get; set; }
        public OrderClass orderClass { get; set; }
        public CustomerClass customerClass { get; set; }

        public ProductInfoClass()
        {
        }
    }
}
