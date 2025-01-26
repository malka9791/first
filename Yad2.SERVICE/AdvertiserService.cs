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
        public async Task<IEnumerable<Advertiser>> GetAllAsync()
        {
            return await _advertiserRepository.Advertisers.GetAllAsync();
        }
        public async Task<Advertiser> GetByIdAsync(int id)
        {
            return await _advertiserRepository.Advertisers.GetByIdAsync(id);
        }
        public async Task<Advertiser> AddValueAsync(Advertiser advertiser) {
            await _advertiserRepository.Advertisers.AddAsync(advertiser);
            await _advertiserRepository.SaveAsync();
            return advertiser;
        }
        public async Task PutValueAsync(Advertiser advertiser) 
        {
           _advertiserRepository.Advertisers.Update(advertiser);
            await _advertiserRepository.SaveAsync();
        }
        public async Task DeleteAsync(Advertiser a) {
          await  _advertiserRepository.Advertisers.DeleteAsync(a);
           await  _advertiserRepository.SaveAsync();
        }
        public async Task Status(int id,string status)
        {
            _advertiserRepository.Advertiser.StatusVal(id, status);
            await _advertiserRepository.SaveAsync();
        }
    }
}
