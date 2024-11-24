using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace Yad2.CORE.Services
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        void AddValue(Customer customer);
        void Update(int id,Customer customer);
        void Delete(int id);
        public void UpdateStatus(int id, bool status);


    }
}
