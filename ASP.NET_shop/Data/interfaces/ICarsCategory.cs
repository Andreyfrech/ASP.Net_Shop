using ASP.NET_shop.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_shop.Data.interfaces
{
   public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
