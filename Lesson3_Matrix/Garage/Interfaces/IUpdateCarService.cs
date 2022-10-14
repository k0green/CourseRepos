using Garage.Models;

namespace Garage.Interfaces
{
    public interface IUpdateCarService
    {
        Task Update(UpdateCarRequest request);
    }
}
