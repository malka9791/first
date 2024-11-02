using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecreteryController : ControllerBase
    {
        static List<Secretary> secreteries = new List<Secretary>();
        // GET: api/<secreteriesController>
        [HttpGet]
        public IEnumerable<Secretary> Get()
        {
            return secreteries;
        }

        // GET api/<secreteriesController>/5
        [HttpGet("{id}")]
        public Secretary Get(int id)
        {
            foreach (var secretery in secreteries)
            {
                if(secretery.Id == id) 
                    return secretery;
            }
            return new Secretary();
        }

        // POST api/<secreteriesController>
        [HttpPost]
        public void Post([FromBody] Secretary value)
        {
            secreteries.Add(value);
        }

        // PUT api/<secreteriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Secretary value)
        {
            for(int i=0;i<secreteries.Count; i++)
            {
                if (secreteries[i].Id == id)
                {
                    secreteries[i] = value;
                    return;
                }
            }
        }

        // DELETE api/<secreteriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach(var item in secreteries)
            {
                if(item.Id==id)
                {
                    secreteries.Remove(item);
                    return;
                }    
            }
        }
        [HttpPut("{id}/hours")]
        public void Hours(int id,int hours)
        {
            foreach(var  item in secreteries)   
            {
                if (item.Id == id)
                    item.HoursOfWorking = hours;
            }
        }
    }
}
