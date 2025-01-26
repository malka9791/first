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
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _productRepository.Products.GetAllAsync();
        }
        public async Task<Product> GetByIdAsync(int id) {
            return await _productRepository.Products.GetByIdAsync(id);
        }
        public async Task<Product> AddValueAsync(Product product) {
            await _productRepository.Products.AddAsync(product);
           await _productRepository.SaveAsync();
            return product;
        }
        public async Task PutValueAsync(Product product)
        {
            _productRepository.Products.Update(product);
           await _productRepository.SaveAsync();

        }
        public async Task DeleteAsync(Product p) {
           await _productRepository.Products.DeleteAsync(p);
           await _productRepository.SaveAsync();

        }
        public async void UpdatePrice(int id,double price)
        {
            _productRepository.Product.UpdatePrice(id,price);
           await _productRepository.SaveAsync();

        }
    }
}
