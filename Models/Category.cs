using simulation2.Models.Common;

namespace simulation2.Models
{
    public class Category:BaseEntity
    {
        public  string  Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
