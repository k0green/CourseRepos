using Garage.Models;

namespace Garage.Interfaces
{
    public interface IGetAllCarsService
    {
        Task<List<CarItemModel>> GetAll();
    }
}
