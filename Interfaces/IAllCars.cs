using ACP_learn.Models;

namespace ACP_learn.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> allCars { get; }
        IEnumerable<Car> getFavCars { get; }
        Car getObjectCar(int carId);
    }
}