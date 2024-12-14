using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;
using Yad2.CORE.Repositories;

namespace Yad2.DATA.Repositories
{
    public class CustomerRepository : Repository<Customer>,ICustomerRepository
    {
        public CustomerRepository(DataContext context):base(context) 
        {
        }
        #region no 
        //private readonly DataContext _context;

        //public List<Customer> GetList()
        //{
        //    return _context.Customers.ToList();
        //}
        //public Customer GetId(int id)
        //{
        //    foreach (Customer customer in _context.Customers)
        //    {
        //        if (customer.Id == id)
        //            return customer;
        //    }
        //    return new Customer();
        //}
        //public void AddVal(Customer customer)
        //{
        //    _context.Customers.Add(customer);
        //}
        //public void UpdateVal(int id, Customer customer)
        //{
        //    Customer item = _context.Customers.ToList().Find(x => x.Id == id);
        //    item = customer;
        //}
        //public void DeleteVal(int id)
        //{
        //    foreach (Customer customer in _context.Customers)
        //    {
        //        if (customer.Id == id)
        //        {
        //            _context.Customers.Remove(customer);
        //            return;
        //        }
        //    }
        //}
        #endregion
        public void Status(int id,bool status)
        {
            foreach (var customer in this._dbSet)
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
