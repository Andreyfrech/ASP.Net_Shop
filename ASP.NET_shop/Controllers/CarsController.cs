using ASP.NET_shop.Data.interfaces;
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
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
