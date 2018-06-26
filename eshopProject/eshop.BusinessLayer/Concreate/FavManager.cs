using eshop.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eshop.EntitiesLayer.Models;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Abstract;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Concreate;

namespace eshop.BusinessLayer.Concreate
{
    public class FavManager : IFavServices
    {
        private IUnitOfWork unitOfWork;
        public FavManager()
        {
            unitOfWork = new UnitofWork(new DataAccessLayer.DAL.DatabaseContext());
        }
        public void AddFav(Fav fav)
        {
            unitOfWork.FavDal.Add(fav);
            unitOfWork.Complete();
        }

        public Fav GetFav(int? favId)
        {
           if(favId != null)
            {
                return unitOfWork.FavDal.Find(m => m.FavId == favId);
            }
            return null;
        }
        
        public List<Fav> GetFavList(int customerId)
        {
            return unitOfWork.FavDal.FindAll(m =>m.Customer.CustomerId == customerId);
        }

        public void RemoveFav(int favId)
        {
            Fav fav = unitOfWork.FavDal.Find(m => m.FavId == favId);

            unitOfWork.FavDal.Remove(fav);
            unitOfWork.Complete();
        }

        
    }
}
