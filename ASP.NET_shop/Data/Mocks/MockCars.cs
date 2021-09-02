using ASP.NET_shop.Data.interfaces;
using ASP.NET_shop.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get 
            {
                return new List<Car> 
                {
                    new Car
                    {
                        name = "Tesla model s",
                        shortDesc = "Современный электрокар",
                        longDesc = "Электрический седен от компании Tesla, способный разгоняться до 100 км/ч за 3.2 секунды",
                        img = "/img/model s.jpg",
                        price = 45000,
                        isFavourite = true,
                        availabel = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Saab 9-5 aero",
                        shortDesc = "Легендарный шведский автомобиль",
                        longDesc = "Седан шведской компании saab",
                        img = "/img/9-5.jpeg",
                        price = 45000,
                        isFavourite = true,
                        availabel = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
