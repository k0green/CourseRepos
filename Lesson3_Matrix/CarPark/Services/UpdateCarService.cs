using CarPark.Interfaces;
using CarPark.Models;
using CarsParkDb.Interfaces;

namespace CarPark.Services
{
    public class UpdateCarService : IUpdateCarService
    {
        private readonly IDbContext _dbContext;

        public UpdateCarService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(UpdateCarRequest request)
        {
            var car = _dbContext.Cars.Single(c => c.Id == request.Id);

            car.Name = request.Name;
            car.UserId = request.UserId;

            _dbContext.SaveChanges();
        }
    }
}
