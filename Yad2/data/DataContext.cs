using CsvHelper;
using Microsoft.Extensions.Logging;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using Yad2.Interface;

namespace Yad2.data
{
    public class DataContext:IDataContext
    {
        public List<Advertiser> Advertisers { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }
        public DataContext()
        {
            using (var reader = new StreamReader("data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Advertisers = csv.GetRecords<Advertiser>().ToList();
                Customers = csv.GetRecords<Customer>().ToList();
                Products = csv.GetRecords<Product>().ToList();
            }
        }
    }
}
