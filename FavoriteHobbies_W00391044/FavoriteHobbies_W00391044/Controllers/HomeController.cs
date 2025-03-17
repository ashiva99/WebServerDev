using System.Diagnostics;
using FavoriteHobbies_W00391044.Models;
using Microsoft.AspNetCore.Mvc;

namespace FavoriteHobbies_W00391044.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var hobbiesList = new List<Hobby>()
            {
                new Hobby("Basket ball", 7, true),
                new Hobby("Writing", 5, true),
                new Hobby("Cooking", 6, false)
            };
            return View(hobbiesList);
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
