using Garage.Interfaces;
using Garage.Models;
using CarsParkDb.Entities;
using CarsParkDb.Interfaces;

namespace Garage.Services
{
    public class DeleteCarService : IDeleteCarService
    {
        private readonly IDbContext _dbContext;

        public DeleteCarService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Delete(int id)
        {
            var car = _dbContext.Cars.Single(c => c.Id == id);

            _dbContext.Cars.Remove(car);

            _dbContext.SaveChanges();
        }
    }
}
