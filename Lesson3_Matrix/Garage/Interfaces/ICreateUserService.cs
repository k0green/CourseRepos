using Garage.Models;

namespace Garage.Interfaces
{
    public interface ICreateUserService
    {
        Task<int> Create(CreateUserRequest request);
    }
}
