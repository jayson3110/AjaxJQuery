using AjaxJQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxJQuery.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        Customer customer;
        List<Customer> customers;

        public CustomerController()
        {
            //get some data- usually comes from a database

            // in this case we will hard code- data.

            customers = new List<Customer>();
            customers.Add(new Customer(0, "Sherry", 37));
            customers.Add(new Customer(1, "Tom", 12));
            customers.Add(new Customer(2, "Jayson", 21));
            customers.Add(new Customer(3, "Boston", 20));
            customers.Add(new Customer(4, "Cherry", 43));
            customers.Add(new Customer(5, "CL", 30));
            customers.Add(new Customer(6, "Hoody", 30));
        }

        public ActionResult Index()
        {



            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[0]);





            return View("Customer", tuple);
        }


        [HttpPost]
        public ActionResult OnSelectedCustomer(string CustomerNumber)
        {



            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[Int32.Parse(CustomerNumber)]);





            return PartialView("~/Views/Shared/_CustomerDetails.cshtml", customers[Int32.Parse(CustomerNumber)]);
        }
    }
}