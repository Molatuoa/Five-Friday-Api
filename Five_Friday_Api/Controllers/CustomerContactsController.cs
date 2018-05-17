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
    public class CustomerContactsController : ApiController
    {
        // GET: api/CustomerContacts
        public IEnumerable<CustomerContact> Get(string CustomerID)
        {
            return new CustomersFuctions().getCustomerContact(int.Parse(CustomerID));
        }

        // GET: api/CustomerContacts/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CustomerContacts
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CustomerContacts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CustomerContacts/5
        public void Delete(int id)
        {
        }
    }
}
