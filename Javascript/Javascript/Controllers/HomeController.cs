using Microsoft.AspNetCore.Mvc;

namespace Javascript.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Javascript1()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }
    }
}