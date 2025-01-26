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
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task<Product> AddValueAsync(Product Product);
        Task PutValueAsync(Product Product);
        Task DeleteAsync(Product a);
        void UpdatePrice(int id, double price);

    }
}
