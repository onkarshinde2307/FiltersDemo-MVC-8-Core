using Microsoft.AspNetCore.Mvc;

namespace FiltersDemo_In_MVC8_Core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("🎯 [Controller] HomeController.Index executing");
            return View();
        }

        public IActionResult Throw()
        {
            throw new Exception("🔥 Simulated Exception from Action");
        }
    }
}
