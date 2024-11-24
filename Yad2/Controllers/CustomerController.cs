using Microsoft.AspNetCore.Mvc;
using Yad2.CORE.Models;
using Yad2.CORE.Services;
using Yad2.SERVICE;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>

        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerservice)
        {
            _customerService = customerservice;
        }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerService.GetAll();
        }

        //GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customerService.GetById(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            _customerService.AddValue(value);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            _customerService.Update(id, value);
        }

        //// DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          _customerService.Delete(id);
        }
        [HttpPut("{id}/Status")]
        public void UpdateStatus(int id, bool status)
        {
           _customerService.UpdateStatus(id, status);
        }
    }
}
