using Lesson20.ExeptionClasses;
using Lesson20.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson20.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
                return View();
        }
        public string Check()
        {
            try
            {
                int i = 8;
                int m = 0;
                int r;
                if (m != 0)
                {
                    r = i / m;
                }
                else
                {
                    throw new GeneralExeption("DivideByZero");
                }

                return r.ToString();
            }
            catch (GeneralExeption ex1)
            {
                return $"{ex1.Message}";
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}