using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.BusinessLayer.Abstract
{
    public interface IHomeSliderServices
    {
        void AddToHomeSlider(HomeSlider homeSlider);
    }
}
