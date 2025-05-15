using Microsoft.AspNetCore.Mvc;
//using simulation2.Models;
using System.Diagnostics;

namespace simulation2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}