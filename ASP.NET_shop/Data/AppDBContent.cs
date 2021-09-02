using ASP.NET_shop.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_shop.Data
{
    public class AppDBContent: DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options): base (options)
        {

        }
        public DbSet<Car> car { get; set; }
        public DbSet<Category> category { get; set; }
    }
}
