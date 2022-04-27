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
                        img = "https://upload.wikimedia.org/wikipedia/commons/4/4f/Tesla_Model_S_02_2013.jpg",
                        price = 45000, isFavourite = true, available = true, category = categoryCars.allCaterories.ElementAt(0)},
                    new Car {
                        name = "Ford Fiesta",
                        shortDesc= "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/2017_Ford_Fiesta_Zetec_Turbo_1.0_Front.jpg/1280px-2017_Ford_Fiesta_Zetec_Turbo_1.0_Front.jpg",
                        price = 11000, isFavourite = false, available = true, category = categoryCars.allCaterories.ElementAt(1)},
                    new Car {
                        name = "вмw м3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://avatars.mds.yandex.net/get-verba/1540742/2a00000178874741ebe297e8ba6c4145a1c7/cattouchret",
                        price = 65000, isFavourite = true, available = true, category = categoryCars.allCaterories.ElementAt(1)
                    },
                    new Car {
                        name = "Mercedes c class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://cdn.motor1.com/images/mgl/k3pee/s1/mercedes-c-klasse-limousine-2021.jpg",
                        price = 40000, isFavourite = false, available = false, category = categoryCars.allCaterories.ElementAt(1)},
                    new Car {
                        name = "nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/2018_Nissan_Leaf_Tekna_Front.jpg/800px-2018_Nissan_Leaf_Tekna_Front.jpg",
                        price = 14000, isFavourite = true, available = true, category = categoryCars.allCaterories.ElementAt(0)
                    }
                };
            }
        }
        public IEnumerable<Car>? getFavCars { get; }
        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}