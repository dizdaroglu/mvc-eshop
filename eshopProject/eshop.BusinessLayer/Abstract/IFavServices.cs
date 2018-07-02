using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.BusinessLayer.Abstract
{
  public interface IFavServices
    {
        void AddFav(Fav fav);
        void RemoveFav(int favId);
       
        List<Fav> GetFavList(int customerId);
        Fav GetFav(int? favId);

        #region Admin
        List<Fav> GetFav();
        Fav favDetails(int id);
        int favUpdate();
        int favDelete(int id);
        #endregion

    }
}
