using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;
using Yad2.CORE.Repositories;

namespace Yad2.DATA.Repositories
{
    public class RepositoryManager: IRepositoryManager
    {
        private readonly DataContext _context;
        public IRepository<Product> Products { get; }
        public IRepository<Customer> Customers { get; }
        public IRepository<Advertiser> Advertisers { get; }
        public ICustomerRepository Customer { get; }
        public IProductRepository Product { get; } 
        public IAdvertiserRepository Advertiser { get; }
        public RepositoryManager(DataContext context,IRepository<Product>
            productRepository,IRepository<Customer> customerRepository,
            IRepository<Advertiser> advertiserRepository,
            IAdvertiserRepository advertiser,IProductRepository product,ICustomerRepository customer)
        {
            _context = context;
            Products = productRepository;
            Customers = customerRepository;
            Advertisers = advertiserRepository;
            Customer = customer;
            Product = product;  
            Advertiser = advertiser;
        }
        public async Task SaveAsync()
        {
          await  _context.SaveChangesAsync();
        }
    }
}
