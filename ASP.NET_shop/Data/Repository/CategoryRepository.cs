using ASP.NET_shop.Data.interfaces;
using ASP.NET_shop.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent AppDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.AppDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories =>AppDBContent.category;
    }
}
