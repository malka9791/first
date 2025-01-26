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
    public class CustomerService: ICustomerService
    {
        private readonly IRepositoryManager _customerRepository;
        public CustomerService(IRepositoryManager customerepository)
        {
            _customerRepository = customerepository;
        }
        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerRepository.Customers.GetAllAsync();
        }
        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _customerRepository.Customers.GetByIdAsync(id);
        }
        public async Task<Customer> AddValueAsync(Customer customer)
        {
            await _customerRepository.Customers.AddAsync(customer);
            await _customerRepository.SaveAsync();
            return customer;
        }
        public async Task PutValueAsync(Customer customer)
        {
            _customerRepository.Customers.Update(customer);
            await _customerRepository.SaveAsync();
        }
        public async Task DeleteAsync(Customer a)
        {
            await _customerRepository.Customers.DeleteAsync(a);
            await _customerRepository.SaveAsync();
        }
        public void UpdateStatus(int id,bool status) {
            _customerRepository.Customer.Status(id, status);
            _customerRepository.SaveAsync();
        }
    }
}
