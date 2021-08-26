using ASP.NET_shop.Data.interfaces;
using ASP.NET_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_shop.Controllers
{
    public class CarsController : Controller
    {
          private readonly IAllCars _allCars;
          private readonly ICarsCategory _carsCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _carsCategory = iCarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.getAllCars = _allCars.Cars;
            obj.currCategory = "Автомобили"; 
         //   var cars = _allCars.Cars;
            return View(obj);
        }
    }
}
