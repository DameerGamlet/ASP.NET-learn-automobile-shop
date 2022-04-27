using ACP_learn.Models;
namespace ACP_learn.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; } = default!;
        public string? currentCategory { get; set; }
    }
}