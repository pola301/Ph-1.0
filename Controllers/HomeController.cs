using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Filter()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}