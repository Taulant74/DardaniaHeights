using Microsoft.AspNetCore.Mvc;

namespace DardaniaHeights.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello, World!");
        }
    }
}
