using Microsoft.AspNetCore.Mvc;
using Yad2.CORE.Models;
using Yad2.CORE.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertiserController : ControllerBase
    {
        
        private readonly IAdvertiserService _advertiserService;
        // GET: api/<advertisersController>
        public AdvertiserController(IAdvertiserService context)
        {
            _advertiserService = context;
        }
        [HttpGet]
        public IEnumerable<Advertiser> Get()
        {
            return _advertiserService.GetAll() ;
        }

        // GET api/<AdvertisersController>/5
        [HttpGet("{id}")]
        public Advertiser Get(int id)
        {
            return _advertiserService.GetById(id);
        }

        // POST api/<AdvertisersController>
        [HttpPost]
        public void Post([FromBody] Advertiser value)
        {
           _advertiserService.AddValue(value);
        }

        // PUT api/<AdvertisersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Advertiser value)
        {
            _advertiserService.PutValue(id, value);
        }

        // DELETE api/<AdvertisersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _advertiserService.Delete(id);
        }
        [HttpPut("{id}/status")]
        public void Status(int id, string status)
        {
            _advertiserService.Status(id, status);
        }
    }
}
