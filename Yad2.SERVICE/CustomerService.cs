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
        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.Customers.GetAll();
        }
        public Customer GetById(int id)
        {
            return _customerRepository.Customers.GetById(id);
        }
        public void AddValue(Customer customer) 
        { 
            _customerRepository.Customers.Add(customer);
        }
        public void Update(Customer customer) {
            _customerRepository.Customers.Update( customer);
        }
        public void Delete(Customer c)
        {
            _customerRepository.Customers.Delete(c);
        }
        public void UpdateStatus(int id,bool status) {
            _customerRepository.Customer.Status(id, status);
        }
    }
}
