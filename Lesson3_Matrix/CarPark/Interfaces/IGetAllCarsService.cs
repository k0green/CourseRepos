using CarPark.Models;

namespace CarPark.Interfaces
{
    public interface IGetAllCarsService
    {
        List<CarItemModel> GetAll();
    }
}
