
using Yad2.Interface;

namespace Yad2.data
{

    public class FakeContexet:IDataContext
    {
        public List<Advertiser> Advertisers { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }

        public FakeContexet()
        {
            Advertisers = new List<Advertiser> { new Advertiser { Id = 1, Id_product = 1, Kind_Advertiser = "old", Name = "Chaim" } };
            Customers = new List<Customer> { new Customer { Id = 1, Name = "Nomi", IsActive = true, Mail = "1@gmail.com" } };
            Products = new List<Product> { new Product{Id=1,Description="small cupboard",Price=150,Status="by using 5 years" } };
        }
    }
}
