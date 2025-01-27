using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace Yad2.CORE.Services
{
    public interface ICustomerService:IRepositoryService<Customer>
    {
      
        public void UpdateStatus(int id, bool status);


    }
}
