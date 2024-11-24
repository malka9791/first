using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace Yad2.CORE.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void AddProduct(Product product); 
        void PutValue(int id, Product value);
        void Delete(int id);
        void UpdatePrice(int id, double price);

    }
}
