using CarPark.Models;

namespace CarPark.Interfaces
{
    public interface ICreateCarService
    {
        void Create(CreateCarRequest request);
    }
}
