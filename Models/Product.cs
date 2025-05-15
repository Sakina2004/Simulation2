using simulation2.Models.Common;

namespace simulation2.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public  Category Category { get; set; }
    }
}





