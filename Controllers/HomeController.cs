using Allegra.Models;
using Allegra.Repositories.Interfaces;
using Allegra.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Allegra.Controllers
{
    public class HomeController : Controller
    {

        private readonly IJoiaRepository _joiaRepository;

        public HomeController(IJoiaRepository joiaRepository)
        {
            _joiaRepository = joiaRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                JoiasPreferidas = _joiaRepository.JoiasPreferidas
            };

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}