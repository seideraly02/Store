using System.Runtime.InteropServices;

namespace Store.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        
        public override string ToString()
        {
            return $"{Id} - {Name} - {Brand} - {Price}";
        }
    }
}