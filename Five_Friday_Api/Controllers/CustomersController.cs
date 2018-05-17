using Five_Friday_Api.Functionals;
using Five_Friday_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Five_Friday_Api.Controllers
{
    public class CustomersController : ApiController
    {
        // GET: api/Customers
        public IEnumerable<Customer> Get(string sSearch)
        {
            return new CustomersFuctions().GetCustomerList(sSearch);
        }
        
        [System.Web.Mvc.HttpPost]
        public int Customers(string Name, string Latitude, string Longitude)
        {
            return new CustomersFuctions()._addNewCustomer(new Customer()
            {
                Name = Name,
                Latitude = Latitude,
                Longitude = Longitude
            });   
        }
        [System.Web.Mvc.HttpPost]
        public void Customers(string ContactName, string CustomerID, string ContactEmail,string Numbers)
        {
            new CustomersFuctions()._addNewContact(new CustomerContact()
            {
                Name = ContactName,
                email = ContactEmail,
                CustomerID = int.Parse(CustomerID),
                Contact_Number = Numbers
            });
        }
        // POST: api/Customers
        public void Post([FromBody]string value)
        {
        }
        
    }
}
