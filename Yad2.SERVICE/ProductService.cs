using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;
using Yad2.CORE.Repositories;
using Yad2.CORE.Services;

namespace Yad2.SERVICE
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository repository)
        {
            _productRepository = repository;
        }
        public List<Product> GetAll()
        {
            return _productRepository.GetList();
        }
        public Product GetById(int id) {
            return _productRepository.SearchId(id);
        }
        public void AddProduct(Product product) {
             _productRepository.AddPro(product);
        }
        public void PutValue(int id, Product product)
        {
            _productRepository.PutVal(id,product);
        }
        public void Delete(int id) {
            _productRepository.DeleteVal(id);
        }
        public void UpdatePrice(int id,double price)
        {
            _productRepository.Update(id,price);
        }
    }
}
