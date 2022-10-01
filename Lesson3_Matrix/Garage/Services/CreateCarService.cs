using Garage.Interfaces;
using Garage.Models;
using CarsParkDb.Entities;
using CarsParkDb.Interfaces;

namespace Garage.Services
{
    public class CreateCarService : ICreateCarService
    {
        private readonly IDbContext _dbContext;

        public CreateCarService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(CreateCarRequest request)
        {
            var rnd = new Random();
            var car = new Car
            {
                Id = rnd.Next(10),
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
