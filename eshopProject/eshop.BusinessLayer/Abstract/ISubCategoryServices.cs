using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.BusinessLayer.Abstract
{
   public interface ISubCategoryServices
    {
        List<SubCategory> getSubCategory();
        SubCategory subcategoryDetails(int id);
        int subcategoryUpdate();
        int subcategoryDelete(int id);
        int subcategoryCreate(SubCategory subCategory);
    }
}
