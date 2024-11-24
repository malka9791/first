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
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<Customer> GetAll()
        {
            return _customerRepository.GetList();
        }
        public Customer GetById(int id)
        {
            return _customerRepository.GetId(id);
        }
        public void AddValue(Customer customer) 
        { 
            _customerRepository.AddVal(customer);
        }
        public void Update(int id,Customer customer) {
            _customerRepository.UpdateVal(id, customer);
        }
        public void Delete(int id)
        {
            _customerRepository.DeleteVal(id);
        }
        public void UpdateStatus(int id,bool status) { 
            _customerRepository.Status(id, status);
        }
    }
}
