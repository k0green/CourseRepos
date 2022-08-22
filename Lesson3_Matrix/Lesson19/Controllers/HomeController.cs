using Lesson19.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson19.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static List<Car> cars = new List<Car>
        {
            new Car
            {
                Type = "universal",
                Company="VolsWagen",
                Model = "Passat",
                Id="1792-AM 7",
                Year=2021
            },
            new Car
            {
                Type = "sedan",
                Company="VolsWagen",
                Model = "Polo",
                Id="5712-HP 7",
                Year=2008
            },
            new Car
            {
                Type = "kupe",
                Company="Audi",
                Model = "TT",
                Id="1117-AA 7",
                Year=2019
            },
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Car = cars;
            return View();
        }

        [HttpGet]
        public IActionResult AddCar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCar(string type, string company, string model, string id, int year)
        {
            cars.Add(new Car
            {
                Id = id,
                Company = company,
                Model = model,
                Year = year,
                Type = type
            });
            return View();
        }
        [HttpGet]
        public IActionResult DeleteCar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteCar(int id)
        {
            id--;
            cars.RemoveAt(id);
            return View();
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