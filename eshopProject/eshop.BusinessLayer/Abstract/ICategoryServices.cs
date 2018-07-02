using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.BusinessLayer.Abstract
{
    public interface ICategoryServices
    {
        List<Category> GetCategories();

        Category categoryDetails(int id);
        int categoryUpdate();
        int categoryDelete(int id);
        int categoryCreate(Category category);
    }
}
