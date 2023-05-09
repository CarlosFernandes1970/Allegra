using Microsoft.AspNetCore.Mvc;

namespace Allegra.Controllers
{
    public class AdminController : Controller
    {
        /* public IActionResult Index()
         {
             return View();
         }*/
        public string Index()
        {
            return $"Testando index: {DateTime.Now}";
        }

        public string Demo()
        {
            return $"Testando demo: {DateTime.Now}";
        }
    }
}
