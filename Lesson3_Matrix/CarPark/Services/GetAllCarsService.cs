using CarPark.Interfaces;
using CarPark.Models;
using CarsParkDb.Interfaces;

namespace CarPark.Services
{
    public class GetAllCarsService : IGetAllCarsService
    {
        private readonly IDbContext _dbContext;

        public GetAllCarsService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<CarItemModel> GetAll()
        {
            var allCars = _dbContext.Cars.Select(c => new CarItemModel
            {
                Name = c.Name,
                Id = c.Id,
                OwnerEmail = c.User.Email
            }).ToList();

            return allCars;
        }
    }
}
