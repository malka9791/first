using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace Yad2.CORE.Services
{
    public interface IAdvertiserService:IRepositoryService<Advertiser> 
    {
      
        Task Status(int id, string status);

    }
}
