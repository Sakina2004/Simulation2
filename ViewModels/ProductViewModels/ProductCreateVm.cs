using simulation2.Models;

namespace simulation2.ViewModels.ProductViewModels
{
    public class ProductCreateVm
    {
        public IFormFile Image { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public float Rating { get; set; }
        public  int Category{ get; set; }
        public float WatchingViews { get; set; }
    }
}
//Id = x.Id,
//                Title = x.Title, 
//                  Rating = x.Rating,
//                  WatchingViews = x.WatchingViews,
//                  Category = x.Category,
//                  ImagePath = x.ImagePath