using System.ComponentModel;
using ACP_learn.Interfaces;
using ACP_learn.Models;

namespace ACP_learn.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory categoryCars = new MockCategory();
        public IEnumerable<Car> allCars
        {
            get
            {
                return new List<Car>{
                    new Car {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img = "/img/tesla.jpg",
                        price = 45000, isFavourite = true, available = true, category = categoryCars.allCaterories.ElementAt(0)},
                    new Car {
                        name = "Ford Fiesta",
                        shortDesc= "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/ford.jpg",
                        price = 11000, isFavourite = false, available = true, category = categoryCars.allCaterories.ElementAt(1)},
                    new Car {
                        name = "вмw м3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/bmw.jpeg",
                        price = 65000, isFavourite = true, available = true, category = categoryCars.allCaterories.ElementAt(1)
                    },
                    new Car {
                        name = "Mercedes c class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/mersedes.jpg",
                        price = 40000, isFavourite = false, available = false, category = categoryCars.allCaterories.ElementAt(1)},
                    new Car {
                        name = "nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/nissan.jpg",
                        price = 14000, isFavourite = true, available = true, category = categoryCars.allCaterories.ElementAt(0)
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; }
        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}