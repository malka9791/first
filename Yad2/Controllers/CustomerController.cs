using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Yad2.CORE.DTOs;
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
        private readonly IMapper _mapper;
        public CustomerController(ICustomerService customerservice,IMapper mapper)
        {
            _mapper=mapper;
            _customerService = customerservice;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var list= _customerService.GetAll();
            var listDto=_mapper.Map<IEnumerable<CustomerDTO>>(list);
            return Ok(listDto);
        }

        //GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var customer=_customerService.GetById(id);
            var dto=_mapper.Map<CustomerDTO>(customer);
            return Ok(dto);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerPost value)
        {
            var dto = _mapper.Map<Customer>(value);
            _customerService.AddValue(dto);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{customer}")]
        public void Put(/*int id,*/ [FromBody] CustomerUpdate value)
        {
            var dto = _mapper.Map<Customer>(value);
            _customerService.Update(dto);
        }

        //// DELETE api/<CustomerController>/5
        [HttpDelete("{customer}")]
        public void Delete(CustomerUpdate c)
        {
            var dto = _mapper.Map<Customer>(c);
            _customerService.Delete(dto);
        }
        [HttpPut("{id}/Status")]
        public void UpdateStatus(int id, bool status)
        {
           _customerService.UpdateStatus(id, status);
        }
    }
}
