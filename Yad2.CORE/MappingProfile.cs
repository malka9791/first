using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.DTOs;
using Yad2.CORE.Models;

namespace Yad2.CORE
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerDTO, Customer>().ReverseMap();
            CreateMap<CustomerUpdate, Customer>().ReverseMap();
            CreateMap<CustomerPost, Customer>().ReverseMap();

            CreateMap<ProductDTO, Product>().ReverseMap();
            CreateMap<ProductGetDTO, Product>().ReverseMap();
            CreateMap<ProductUpdate, Product>().ReverseMap();

            CreateMap<AdvertisterDTO,Advertiser>().ReverseMap();
            CreateMap<AdvertisterPost, Advertiser>().ReverseMap();
            CreateMap<AdvertisterUpdate, Advertiser>().ReverseMap();

        }
    }
}
