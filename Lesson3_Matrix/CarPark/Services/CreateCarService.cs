using CarPark.Interfaces;
using CarPark.Models;
using CarsParkDb.Entities;
using CarsParkDb.Interfaces;

namespace CarPark.Services
{
    public class CreateCarService : ICreateCarService
    {
        private readonly IDbContext _dbContext;

        public CreateCarService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(CreateCarRequest request)
        {
            var car = new Car
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                UserId = request.UserId,
            };

            try
            {
                _dbContext.Cars.Add(car);
                _dbContext.SaveChanges();
            }
            catch
            {
                _dbContext.Cars.Remove(car);
                throw;
            }
        }
    }
}
