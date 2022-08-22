using Lesson18.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson18.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
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
        [HttpGet]
        public async Task<List<Car>> GetCars()
        {
            return cars;
        }
        [HttpPost]
        public async Task AddCar([FromBody] Car car)
        {
            cars.Add(new Car
            {
                Id = car.Id,    
                Company = car.Company,
                Model = car.Model,
                Type=car.Type,
                Year=car.Year
            });
        }
        [HttpDelete("{model}")]
        public async Task Delete(string model)
        {
            cars=cars.Where(car=>car.Model!=model).ToList();
        }
        
    }
}
