using Coffee.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Interfaces
{
    public interface ICrudlRoleService : IGetAllService
    {
        public List<Role> GetAllRole();
        public Role GetRole(int? id);

    }
}
