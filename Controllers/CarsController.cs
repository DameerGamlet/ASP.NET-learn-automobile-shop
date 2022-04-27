using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ACP_learn.Models;

using ACP_learn.Interfaces;
using ACP_learn.ViewModels;


namespace ACP_learn.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars allCars;
        private readonly ICarsCategory allCategoties;

        public CarsController(IAllCars IAllCars, ICarsCategory ICarsCat)
        {
            allCars = IAllCars;
            allCategoties = ICarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = allCars.allCars;
            obj.currentCategory = "Автомобили";

            return View(obj);
        }
    }
}