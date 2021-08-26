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
                        img = "https://yandex.ru/images/search?from=tabbar&text=tesla%20model%20s&pos=1&img_url=https%3A%2F%2Fwallsdesk.com%2Fwp-content%2Fuploads%2F2016%2F05%2FTesla-Model-S-High-Definition-Wallpapers-.jpg&rpt=simage",
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
                        img = "https://yandex.ru/images/search?text=saab%209-5%20aero&from=tabbar&pos=1&img_url=https%3A%2F%2Fsun9-16.userapi.com%2Fc11032%2Fu80321298%2F150723911%2Fx_c06edac2.jpg&rpt=simage",
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
