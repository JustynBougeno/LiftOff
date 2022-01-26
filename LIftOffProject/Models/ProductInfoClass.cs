using System;
namespace LiftOffProject.Models
{
    public class ProductInfoClass
    {

        public string productName { get; set; }
        public string productId { get; set; }
        public string productCatogory { get; set; }
        public string productManufacture { get; set; }
        public string productSeller { get; set; }
        public string productPrice { get; set; }

        public int Id { get; set; }

        public ProductInfoClass()
        {
        }
    }
}
