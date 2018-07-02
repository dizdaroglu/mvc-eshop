using eshop.BusinessLayer.Abstract;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Abstract;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Concreate;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.BusinessLayer.Concreate
{
    public class BasketManager : IBasketServices
    {
        private IUnitOfWork _uow;
        public BasketManager()
        {
            _uow = new UnitofWork(new DataAccessLayer.DAL.DatabaseContext());
        }

        public void AddToBasket(Basket basket)
        {
            _uow.BasketDal.Add(basket);
            _uow.Complete();
        }

        public int basketCount()
        {
            return _uow.BasketDal.FindAll().Count();
        }

        public int basketCreate(Basket basket)
        {
            _uow.BasketDal.Add(basket);
            return _uow.Complete();
        }

        public int basketDelete(int id)
        {
           Basket find = _uow.BasketDal.Find(m=>m.BasketId == id);
            
            _uow.BasketDal.Remove(find);

            return _uow.Complete();
        }

        public Basket basketDetails(int id)
        {
            return _uow.BasketDal.Find(m=>m.BasketId == id);
        }

        public int basketUpdate()
        {
            return _uow.Complete();
        }

        public List<Basket> getBasket()
        {
            return _uow.BasketDal.FindAll();
        }

        public List<Basket> GetBaskets(string username)
        {
            return _uow.BasketDal.FindAll(m => m.Customer.UserName.Equals(username));
        }

        public void RemoveBasket(int basketId)
        {
            Basket basket = _uow.BasketDal.Find(m => m.BasketId == basketId);
            _uow.BasketDal.Remove(basket);
            _uow.Complete();
        }


    }
}
