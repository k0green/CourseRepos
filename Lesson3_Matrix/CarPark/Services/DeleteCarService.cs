using CarPark.Interfaces;
using CarsParkDb.Interfaces;

namespace CarPark.Services
{
    public class DeleteCarService : IDeleteCarService
    {
        private readonly IDbContext _dbContext;

        public DeleteCarService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(Guid id)
        {
            var car = _dbContext.Cars.Single(c => c.Id == id);

            _dbContext.Cars.Remove(car);

            _dbContext.SaveChanges();
        }
    }
}
