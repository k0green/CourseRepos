using Coffee.Entities;
using Coffee.Interfaces;

namespace Coffee.Services
{
    public class UserCrudlServices : ICrudlUserService
    {

        private readonly IDbContext _dbContext;

        public UserCrudlServices(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<User> GetAllUser()
        {
            var allUser = _dbContext.Users.ToList();
            return allUser;
        }

        public User GetUser(int id)
        {
            return _dbContext.Users.FirstOrDefault(d => d.Id == id);
        }

        public User GetUserByLogin(string login)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Login == login);
        }

        public void CreateUser(string name, string login, string password, int roleId)
        {
            _dbContext.Users.Add(new User { Name = name, Login = login, Password = IRegistrationService.HashPassword(password), RoleId = roleId });
            _dbContext.SaveChanges();
        }
    }
}
