using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.BusinessLayer.Abstract
{
    public interface ISizeServices
    {
        // Bür ürünün sahip oldugu sizelar 
        List<Size> GetSizeList();
    }
}
