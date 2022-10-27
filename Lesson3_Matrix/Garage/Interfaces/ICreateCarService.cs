using Garage.Models;

namespace Garage.Interfaces
{
    public interface ICreateCarService
    {
        Task Create(CreateCarRequest request);
    }
}
