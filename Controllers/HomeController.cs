using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product[] array =
            {
                new Product {Name = "Kajak", Price = 275M},
                new Product {Name = "Kamizelka ratunkowa", Price = 48.95M},
                new Product {Name = "Piłka nożna", Price = 19.50M},
                new Product {Name = "Flaga narożna", Price = 34.95M}
            };
            return View(array);
        }
    }
}