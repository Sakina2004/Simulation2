using Microsoft.AspNetCore.Mvc;

namespace simulation2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult>Create()
        {
            return View();
        }

    }
}
