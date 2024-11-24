using Yad2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Yad2.CORE.Services;
using Yad2.CORE.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static IProductService _productService;

        public ProductsController(IProductService context)
        {
            _productService = context;
        }
        // GET: api/<productsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAll();
        }

        // GET api/<productsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {

            return _productService.GetById(id);
  
        }

        // POST api/<productsController>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            _productService.AddProduct(value);

        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            _productService.PutValue(id, value);
        }

        // DELETE api/<productsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.Delete(id);
        }
        [HttpPut("{id}/price")]
        public void UpdatePrice(int id, int price)
        {
           _productService.UpdatePrice(id, price);
        }
    }
}
