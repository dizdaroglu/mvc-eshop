using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.BusinessLayer.Abstract
{
    public interface IBrandServices
    {
        List<Brand> GetBrands();

        Brand brandDetails(int id);
        int brandUpdate();
        int brandDelete(int id);
        int brandCreate(Brand brand);
    }
}
