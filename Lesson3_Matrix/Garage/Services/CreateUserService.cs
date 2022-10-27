using Garage.Interfaces;
using Garage.Models;
using CarsParkDb.Entities;
using CarsParkDb.Interfaces;

namespace Garage.Services
{
    public class CreateUserService : ICreateUserService
    {
        private readonly IDbContext _dbContext;

        public CreateUserService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Create(CreateUserRequest request)
        {
            var rnd = new Random();
            var id = rnd.Next(10);

            var user = new User
            {
                Id = id,
                Name = request.Name,
                Phone = request.Phone,
            };

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            return id;
        }
    }
}
