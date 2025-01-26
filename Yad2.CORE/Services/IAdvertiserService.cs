using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace Yad2.CORE.Services
{
    public interface IAdvertiserService
    {
        Task<IEnumerable<Advertiser>> GetAllAsync();
        Task<Advertiser> GetByIdAsync(int id);
        Task<Advertiser> AddValueAsync(Advertiser advertiser);
        Task PutValueAsync(Advertiser advertiser);
        Task DeleteAsync(Advertiser a);
        Task Status(int id, string status);

    }
}
