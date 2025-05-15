using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using simulation2.DataAccesssLayer;
using simulation2.Models;
using simulation2.ViewModels.ProductViewModels;

namespace simulation2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Select(x => new ProductGetVm()
            {
                Id = x.Id,
                Title = x.Title,
                Rating = x.Rating,
                WatchingViews = x.WatchingViews,
                Category = x.Category.Name,
                ImagePath = x.ImagePath
            }).ToListAsync();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        
    }
}
