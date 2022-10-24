using CarPark.Interfaces;
using CarPark.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarPark.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private readonly IGetAllCarsService _getAllCarsService;
        private readonly IUpdateCarService _updateCarService;
        private readonly ICreateCarService _createCarService;
        private readonly IDeleteCarService _deleteCarService;

        public HomeController(
            IGetAllCarsService getAllCarsService,
            IUpdateCarService updateCarService,
            ICreateCarService createCarService,
            IDeleteCarService deleteCarService)
        {
            _getAllCarsService = getAllCarsService;
            _updateCarService = updateCarService;
            _createCarService = createCarService;
            _deleteCarService = deleteCarService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return View(_getAllCarsService.GetAll());
        }

        [HttpPut]
        public void Update(UpdateCarRequest request)
        {
            _updateCarService.Update(request);
        }

        [HttpPost]
        public void Add(CreateCarRequest request)
        {
            _createCarService.Create(request);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _deleteCarService.Delete(id);
        }
    }
}