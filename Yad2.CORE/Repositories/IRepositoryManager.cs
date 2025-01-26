using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace Yad2.CORE.Repositories
{
    public interface IRepositoryManager
    {
        public IRepository<Product> Products { get; }
        public IRepository<Customer> Customers { get; }
        public IRepository<Advertiser> Advertisers { get; }
        public ICustomerRepository Customer { get; }
        public IProductRepository Product { get; }
        public IAdvertiserRepository Advertiser { get; }
        Task SaveAsync();
    }
}
