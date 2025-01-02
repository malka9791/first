namespace Yad2.CORE.Models
{
    public class Advertiser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public List<Product> products { get; set; }

    }
}
