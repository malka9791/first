﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;
using Yad2.CORE.Repositories;

namespace Yad2.DATA.Repositories
{
    public class AdvertiserRepository: IAdvertiserRepository
    {
        private readonly DataContext _dataContext;
        public AdvertiserRepository(DataContext context)
        {
            _dataContext = context;
        }
        public List<Advertiser> GetList()
        {
            return _dataContext.Advertisers;
        }
        public Advertiser SearchId(int id)
        {
            foreach (var advertiser in _dataContext.Advertisers)
            {
                if (advertiser.Id == id)
                    return advertiser;
            }
            return new Advertiser();
        }
        public void AddVal(Advertiser advertiser)
        {
            _dataContext.Advertisers.Add(advertiser);

        }
        public void PutVal(int id, Advertiser advertiser)
        {
            for (int i = 0; i < _dataContext.Advertisers.Count; i++)
            {
                if (_dataContext.Advertisers[i].Id == id)
                {
                    _dataContext.Advertisers[i] = advertiser;
                    return;
                }
            }
        }
        public void DeleteVal(int id)
        {
            foreach (var item in _dataContext.Advertisers)
            {
                if (item.Id == id)
                {
                    _dataContext.Advertisers.Remove(item);
                    return;
                }
            }
        }
        public void StatusVal(int id,string status)
        {
            foreach(var item in _dataContext.Advertisers)
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