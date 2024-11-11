using Yad2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        static List<Product> products = new List<Product> { new Product{ Id=1} };
        // GET: api/<productsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/<productsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
           
            foreach (var product in products)
            {
                if (product.Id == id)
                    return Ok(product);
            }
            return NotFound();
        }

        // POST api/<productsController>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            products.Add(value);

        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id)
                {
                    products[i] = value;
                }
            }
        }

        // DELETE api/<productsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                { products.Remove(product); return; }
            }
        }
        [HttpPut("{id}/price")]
        public void Status(int id, int price)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    product.Price = price;
                    return;
                }
            }
        }
    }
}
