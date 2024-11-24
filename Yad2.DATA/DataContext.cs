using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace Yad2.DATA
{
    public class DataContext
    {
        public List<Advertiser> Advertisers { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }
        public DataContext()
        {
            Advertisers = new List<Advertiser> { new Advertiser { Id = 1, Id_product = 1, Kind_Advertiser = "old", Name = "Chaim",Status="ective" } };
            Customers = new List<Customer> { new Customer { Id = 1, Name = "Nomi", IsActive = true, Mail = "1@gmail.com" } };
            Products = new List<Product> { new Product { Id = 1, Description = "small cupboard", Price = 150, Status = "by using 5 years" } };
        }
    }
}
