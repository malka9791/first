using Yad2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Yad2.CORE.Services;
using Yad2.CORE.Models;
using AutoMapper;
using Yad2.CORE.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService context,IMapper mapper)
        {
            _productService = context;
            _mapper = mapper;
        }
        // GET: api/<productsController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _productService.GetAll();
            var listdto=_mapper.Map<IEnumerable<ProductDTO>>(list);
            return Ok(listdto);
        }

        // GET api/<productsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var pro=_productService.GetById(id);
            var dto=_mapper.Map<ProductDTO>(pro);
            return Ok(dto);
        }

        // POST api/<productsController>
        [HttpPost]
        public void Post([FromBody] ProductDTO value)
        {
            var dto=_mapper.Map<Product>(value);
            _productService.AddProduct(dto);

        }

        // PUT api/<productsController>/5
        [HttpPut("{products}")]
        public void Put(/*int id,*/ [FromBody] ProductUpdate value)
        {
            var dto=_mapper.Map<Product>(value);
            _productService.PutValue(/*id,*/ dto);
        }

        // DELETE api/<productsController>/5
        [HttpDelete("{product}")]
        public void Delete(ProductUpdate p)
        {
            var dto= _mapper.Map<Product>(p);
            _productService.Delete(dto);
        }
        [HttpPut("{id}/price")]
        public void UpdatePrice(int id, int price)
        {
           _productService.UpdatePrice(id, price);
        }
    }
}
