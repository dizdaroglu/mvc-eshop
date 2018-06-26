using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eshop.EntitiesLayer.Models;

namespace eshop.BusinessLayer.Abstract
{
    public interface IBasketServices
    {
        List<Basket> GetBaskets(String username);

        void AddToBasket(Basket basket);

        void RemoveBasket(int basketId);

    }
}
