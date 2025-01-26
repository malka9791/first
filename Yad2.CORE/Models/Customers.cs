using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Yad2.CORE.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public bool IsActive { get; set; }
       public List<Product> Products { get; set; }
    }
}
