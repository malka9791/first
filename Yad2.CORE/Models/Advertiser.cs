using System.ComponentModel.DataAnnotations;

namespace Yad2.CORE.Models
{
    public class Advertiser
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public List<Product> products { get; set; }

    }
}
