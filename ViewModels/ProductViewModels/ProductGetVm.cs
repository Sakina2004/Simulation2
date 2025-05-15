using simulation2.Models;

namespace simulation2.ViewModels.ProductViewModels
{
    public class ProductGetVm
    {
        public  int Id { get; set; }
        public string Title { get; set; }
        public float WatchingViews { get; set; }
        public string ImagePath { get; set; }
        public float Rating { get; set; }
        public string Category { get; set; }
    }
}
