using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;
using Yad2.CORE.Repositories;

namespace Yad2.DATA.Repositories
{
    public class AdvertiserRepository: Repository<Advertiser>,IAdvertiserRepository
    {
        public AdvertiserRepository(DataContext context):base(context) 
        { 
        }
      
        #region no
        //private readonly DataContext _dataContext;
        
        //public List<Advertiser> GetList()
        //{
        //    return _dataContext.Advertisers.ToList();
        //}
        //public Advertiser SearchId(int id)
        //{
        //    foreach (var advertiser in _dataContext.Advertisers)
        //    {
        //        if (advertiser.Id == id)
        //            return advertiser;
        //    }
        //    return new Advertiser();
        //}
        //public void AddVal(Advertiser advertiser)
        //{
        //    _dataContext.Advertisers.Add(advertiser);

        //}
        //public void PutVal(int id, Advertiser advertiser)
        //{
            
        //  Advertiser advertiser1= _dataContext.Advertisers.ToList().Find(x => x.Id == id);
        //    advertiser1 = advertiser;
        //}
        //public void DeleteVal(int id)
        //{
        //    foreach (var item in _dataContext.Advertisers)
        //    {
        //        if (item.Id == id)
        //        {
        //            _dataContext.Advertisers.Remove(item);
        //            return;
        //        }
        //    }
        //}
        #endregion
        

        public void StatusVal(int id,string status)
        {
            foreach(var item in _dbSet)
            {
                if(item.Id == id)
                {
                    item.Status = status;
                    return;
                }
            }
        }
    }
}
