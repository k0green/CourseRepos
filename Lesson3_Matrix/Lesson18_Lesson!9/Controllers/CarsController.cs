using Microsoft.AspNetCore.Mvc;

namespace Lesson18_Lesson_9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : Controller
    {
        private static List<Car> cars = new List<Car>()
        {
            new Car
            {
                Model= "Camry",
                Id=4367,
            },
            new Car
            {
                Model= "Aventador",
                Id=0001,
            }

        };
        [HttpGet]
        public async Task<List<Car>> GetCars()
        {
            return cars;
        }

        [HttpPost]
        public async Task AddCar([FromBody] CreateCar createCar)
        {
            cars.Add(new Car
            {
                Model = createCar.Model,
                Id = createCar.Id,
            });
        }

        // GET: CarsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CarsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public int Id { get; set; }
    }

    public class CreateCar
    {
        public string Model { get; set; }
        public int Id { get; set; }
    }
}
