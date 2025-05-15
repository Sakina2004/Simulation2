using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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
        //public  async Task<IActionResult>Create(ProductCreateVm vm)
        //{
        //    if (!ModelState.IsValid)
        //        return View(vm);
        //    if(vm.Image.Length*1024*1024>2)
        //    {
        //        ModelState.AddModelError("Image", "Image 2 kb-dan chox ola bilmez!");
        //        return View(vm);
        //    }
        //    if(!vm.Image.ContentType.Contains("image"))
        //    {
        //        ModelState.AddModelError("Image", "Yalniz shekil formatinda data daxil ede bilersiniz");
        //        return View(vm);
        //    }
        //    string filename = Guid.NewGuid().ToString() + vm.Image.FileName;
        //    string path = Path.Combine(Path.GetTempPath(), "wwwroot", "images", filename);
        //}
    }
}
