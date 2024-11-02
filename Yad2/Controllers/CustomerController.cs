using Microsoft.AspNetCore.Mvc;
using Yad2;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>

        static List<Customer> customers = new List<Customer>();
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customers;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return new Customer();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            customers.Add(value);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == id)
                {
                    customers[i] = value;
                    return;
                }
            }
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Id == id)
                {
                    customers.Remove(customer);
                    return;
                }
            }
        }
        [HttpPut("{id}/status")]
        public void Kind(int id, bool status)
        {
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    customer.IsActive = status;
                }
            }
        }
    }
}
