using System;
using System.Collections.Generic;

namespace LiftOffProject.Models
{
    public class OrderClass
    {
        public int orderId { get; set; }
        public int customerId { get; set; }

        public string orderStatus { get; set; }
        public string orderInfo { get; set; }
        
        public string orderPrice { get; set; }
        public int Id { get; set; }

        public CustomerClass customer { get; set; }
        public List<ProductInfoClass> products { get; set; }

        public OrderClass()
        {
        }
    }
}
