using System;
namespace LiftOffProject.Models
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string zipCode { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public int addressId { get; set; }
        public int customerId { get; set; }
        public int Id { get; set; }


        public Address()
        {
        }
    }
}
