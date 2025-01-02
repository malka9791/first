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
        private readonly IRepositoryManager _productRepository;
        public ProductService(IRepositoryManager productrepository)
        {
            _productRepository = productrepository;
        }
        public IEnumerable<Product> GetAll()
        {
            return _productRepository.Products.GetAll();
        }
        public Product GetById(int id) {
            return _productRepository.Products.GetById(id);
        }
        public void AddProduct(Product product) {
             _productRepository.Products.Add(product);
            _productRepository.Save();
        }
        public void PutValue(Product product)
        {
            _productRepository.Products.Update(product);
            _productRepository.Save();

        }
        public void Delete(Product p) {
            _productRepository.Products.Delete(p);
            _productRepository.Save();

        }
        public void UpdatePrice(int id,double price)
        {
            _productRepository.Product.UpdatePrice(id,price);
            _productRepository.Save();

        }
    }
}
