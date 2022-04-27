using System.ComponentModel;
using ACP_learn.Interfaces;
using ACP_learn.Models;

namespace ACP_learn.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> allCaterories
        {
            get
            {
                return new List<Category> {
                    new Category{categoryName = "Электромобили", description = "Современный вид транспорта"},
                    new Category{categoryName = "Классические автомодили", description = "Машины с двигателем внктренего сгорания"}
                };
            }
        }

    }
}