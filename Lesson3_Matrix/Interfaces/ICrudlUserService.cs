using Coffee.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Interfaces
{
    public interface ICrudlUserService : ICreateService, IDeleteService, IUpdateService, IGetAllService
    {
        public List<User> GetAllUser();
        public User GetUser(int id);
        public User GetUserByLogin(string login);
        public void CreateUser(string name, string login, string password, int roleId);

    }
}
