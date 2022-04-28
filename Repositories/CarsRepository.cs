using ACP_learn.Interfaces;
using ACP_learn.Models;
using Microsoft.EntityFrameworkCore;


namespace ACP_learn.Repositories
{
    public class CarsRepository : IAllCars
    {
        private readonly AppDbContent appDbContent;

        public CarsRepository( AppDbContent appDbContent){
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Car> allCars => appDbContent.Car.Include(c => c.category);

        public IEnumerable<Car> getFavCars => appDbContent.Car.Where(p => p.isFavourite).Include(c => c.category);
        public Car getObjectCar(int carId) => appDbContent.Car.FirstOrDefault(p => p.id == carId);
    }
}