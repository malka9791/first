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
        IEnumerable<Advertiser> GetAll();
        Advertiser GetById(int id);
        void AddValue(Advertiser value);
        void PutValue( Advertiser value);
        void Delete(Advertiser a);
        void Status(int id, string status);

    }
}
