using Garage.Interfaces;
using Garage.Models;
using CarsParkDb.Entities;
using CarsParkDb.Interfaces;

namespace Garage.Services
{
    public class GetAllCarsService : IGetAllCarsService
    {
        private readonly IDbContext _dbContext;

        public GetAllCarsService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CarItemModel>> GetAll()
        {
            var allCars = _dbContext.Cars.Select(c => new CarItemModel
            {
                Name = c.Name,
                Id = c.Id,
                OwnerPhone = c.User.Name
            }).ToList();

            return allCars;
        }
    }
}
