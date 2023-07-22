using System.Runtime.InteropServices;

namespace Store.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Brand BrandId { get; set; }
        public Brand Brand { get; set; }
      
    }
}