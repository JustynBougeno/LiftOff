using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiftOffProject.Data;
using LiftOffProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LIftOffProject.Controllers
{  //creating controller for registration page. Going to add custers Id to the data base.
    public class CustomerController : Controller
    {
        private DataDbContext context;

        public CustomerController(DataDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {  //gives access to list of customers.
            List<CustomerClass> customers = context.Customers.ToList();
            return View(customers);
        }

        [HttpPost] // Tells it wether it is create update funtion.
        public IActionResult processNewCustomer()
        {
            /* once the view model is made, we will take the information the user
             input from the view model in to a new Address object and Payment
             Info object. we will then take those new objects and assign them
             to the address and payment info properties on the Customer class
             before saving it to the database */

            CustomerClass newCustomer = new CustomerClass /*{ eMail, frstName, LastName, address}*/
            return View();
        }


    }
}
