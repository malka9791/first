namespace Yad2.CORE.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public double Price { get; set; } = 0;
    }
}
