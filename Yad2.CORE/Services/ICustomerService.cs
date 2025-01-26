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
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task<Customer> AddValueAsync(Customer Customer);
        Task PutValueAsync(Customer Customer);
        Task DeleteAsync(Customer a);
        public void UpdateStatus(int id, bool status);


    }
}
