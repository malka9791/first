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
        List<Advertiser> GetAll();
        Advertiser GetById(int id);
        void AddValue(Advertiser value);
        void PutValue(int id, Advertiser value);
        void Delete(int id);
        public void Status(int id, string status);

    }
}
