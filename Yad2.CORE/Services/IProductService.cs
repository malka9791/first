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
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void AddProduct(Product product); 
        void PutValue( Product value);
        void Delete(Product p);
        void UpdatePrice(int id, double price);

    }
}
