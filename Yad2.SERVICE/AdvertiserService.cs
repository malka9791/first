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
        private readonly IRepositoryManager _advertiserRepository;
        public AdvertiserService(IRepositoryManager advertiserRepository)
        {
            _advertiserRepository = advertiserRepository;
        }
        public IEnumerable<Advertiser> GetAll()
        {
            return _advertiserRepository.Advertisers.GetAll();
        }
        public Advertiser GetById(int id)
        {
            return _advertiserRepository.Advertisers.GetById(id);
        }
        public void AddValue(Advertiser advertiser) {
            _advertiserRepository.Advertisers.Add(advertiser);
            _advertiserRepository.Save();
        }
        public void PutValue(Advertiser advertiser) 
        {
            _advertiserRepository.Advertisers.Update(advertiser);
            _advertiserRepository.Save();
        }
        public void Delete(Advertiser a) {
            _advertiserRepository.Advertisers.Delete(a);
            _advertiserRepository.Save();
        }
        public void Status(int id,string status)
        {
            _advertiserRepository.Advertiser.StatusVal(id, status);
            _advertiserRepository.Save();
        }
    }
}
