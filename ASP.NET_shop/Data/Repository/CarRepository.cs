using ASP.NET_shop.Data.interfaces;
using ASP.NET_shop.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent AppDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.AppDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => AppDBContent.car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => AppDBContent.car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId) => AppDBContent.car.FirstOrDefault(p => p.id == carId);
     
    }
}
