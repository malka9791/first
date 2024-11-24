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
    public class AdvertiserService: IAdvertiserService
    {
        private readonly IAdvertiserRepository _advertiserRepository;
        public AdvertiserService(IAdvertiserRepository advertiserRepository)
        {
            _advertiserRepository = advertiserRepository;
        }
        public List<Advertiser> GetAll()
        {
            return _advertiserRepository.GetList();
        }
        public Advertiser GetById(int id)
        {
            return _advertiserRepository.SearchId(id);
        }
        public void AddValue(Advertiser advertiser) {
            _advertiserRepository.AddVal(advertiser);
        }
        public void PutValue(int id,Advertiser advertiser) 
        {
            _advertiserRepository.PutVal(id,advertiser);
        }
        public void Delete(int id) {
            _advertiserRepository.DeleteVal(id);
        }
        public void Status(int id,string status)
        {
            _advertiserRepository.StatusVal(id,status);
        }
    }
}
