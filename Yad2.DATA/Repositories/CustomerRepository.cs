using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;
using Yad2.CORE.Repositories;

namespace Yad2.DATA.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }
        public List<Customer> GetList()
        {
            return _context.Customers;
        }
        public Customer GetId(int id)
        {
            foreach (Customer customer in _context.Customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return new Customer();
        }
        public void AddVal(Customer customer)
        {
            _context.Customers.Add(customer);
        }
        public void UpdateVal(int id, Customer customer)
        {
            for (int i = 0; i < _context.Customers.Count; i++)
            {
                if (_context.Customers[i].Id == id)
                {
                    _context.Customers[i] = customer;
                    return;
                }
            }
        }
        public void DeleteVal(int id)
        {
            foreach (Customer customer in _context.Customers)
            {
                if (customer.Id == id)
                {
                    _context.Customers.Remove(customer);
                    return;
                }
            }
        }
        public void Status(int id,bool status)
        {
            foreach (var customer in _context.Customers)
            {
                if (customer.Id == id)
                {
                    customer.IsActive=status;
                    return;
                }
            }
        }

    }
}
