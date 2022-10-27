using Garage.Interfaces;
using Garage.Models;
using CarsParkDb.Entities;
using CarsParkDb.Interfaces;

namespace Garage.Services
{
    public class UpdateCarService : IUpdateCarService
    {
        private readonly IDbContext _dbContext;

        public UpdateCarService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Update(UpdateCarRequest request)
        {
            var car = _dbContext.Cars.Single(c => c.Id == request.Id);

            car.Name = request.Name;
            car.UserId = request.UserId;

           _dbContext.SaveChanges();
        }
    }
}
