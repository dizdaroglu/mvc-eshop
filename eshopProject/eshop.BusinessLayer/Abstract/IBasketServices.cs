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

        #region Admin
        List<Basket> getBasket();
        int basketCount();
        Basket basketDetails(int id);
        int basketUpdate();
        int basketDelete(int id);
        int basketCreate(Basket basket);
#endregion
    }
}
