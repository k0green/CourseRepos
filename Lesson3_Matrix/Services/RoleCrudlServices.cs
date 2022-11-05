using Coffee.Entities;
using Coffee.Interfaces;

namespace Coffee.Services
{
    public class RoleCrudlServices : ICrudlRoleService
    {

        private readonly IDbContext _dbContext;

        public RoleCrudlServices(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Role> GetAllRole()
        {
            var allRole = _dbContext.Roles.ToList();
            return allRole;
        }

        public Role GetRole(int? id)
        {
            return _dbContext.Roles.FirstOrDefault(d => d.Id == id);
        }
    }
}
