using Garage.Interfaces;
using Garage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IGetAllCarsService _getAllCarsService;
        private readonly IUpdateCarService _updateCarService;
        private readonly ICreateCarService _createCarService;
        private readonly IDeleteCarService _deleteCarService;

        public CarsController(
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
        public async Task<List<CarItemModel>> GetAllAsync()
        {
            return await _getAllCarsService.GetAll();
        }

        [HttpPut]
        public async Task UpdateAsync(UpdateCarRequest request)
        {
            await _updateCarService.Update(request);
        }

        [HttpPost]
        public async Task Add(CreateCarRequest request)
        {
           await _createCarService.Create(request);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
           await  _deleteCarService.Delete(id);
        }
    }
}
