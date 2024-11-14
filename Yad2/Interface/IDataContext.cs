namespace Yad2.Interface
{
    public interface IDataContext
    {
         List<Advertiser> Advertisers { get; set; }
         List<Customer> Customers { get; set; }
        List<Product> Products { get; set; }
    }
}
