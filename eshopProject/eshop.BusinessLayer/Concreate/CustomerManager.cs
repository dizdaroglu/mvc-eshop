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
    public class CustomerManager : ICustomerServices
    {
        private IUnitOfWork unitOfWork;
        public CustomerManager()
        {
            unitOfWork = new UnitofWork(new DataAccessLayer.DAL.DatabaseContext());
        }

        public bool AnyEmail(string email)
        {
            return unitOfWork.CustomerDal.FindAll().Any(m => m.Email.Equals(email));
        }

        public bool AnyUsername(string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                return unitOfWork.CustomerDal.FindAll().Any(m => m.UserName.Equals(username)); 
            }
            return false;
        }

        public int customerCount()
        {
            return unitOfWork.CustomerDal.FindAll().Count();
        }

        public int customerCreate(Customer customer)
        {
             unitOfWork.CustomerDal.Add(customer);
            return unitOfWork.Complete();
        }

        public int customerDelete(int id)
        {
            Customer find = unitOfWork.CustomerDal.Find(m => m.CustomerId == id);
            #region ilişkilerin silinmesi
            foreach (var item in find.Favs.ToList())//listeleri siler
            {
                unitOfWork.FavDal.Remove(item);

            }
            foreach (var item in find.Baskets.ToList())//basket listeleri siler
            {
                unitOfWork.BasketDal.Remove(item);

            }
            foreach (var item in find.Comments.ToList())//commet listeleri siler
            {
                unitOfWork.CommentsDal.Remove(item);

            }
            foreach (var item in find.BillAddresses.ToList())//BillAddresses listeleri siler
            {
                unitOfWork.BillAdressDal.Remove(item);

            }
            foreach (var item in find.Sales.ToList())//sales listeleri siler
            {
                unitOfWork.SalesDal.Remove(item);

            }
            #endregion
            unitOfWork.CustomerDal.Remove(find);
            return unitOfWork.Complete();
            //image silinecek( klasör )
        }

        public Customer customerDetails(int id)
        {
            return unitOfWork.CustomerDal.Find(m => m.CustomerId == id);
        }

        public bool CustomerLogin(string userName, string password)
        {
            
               return unitOfWork.CustomerDal.FindAll().Any(m=>m.UserName.Equals(userName) && m.Password.Equals(password));
            
         
        }

        public int customerUpdate()
        {
            return unitOfWork.Complete();//save cahange
        }

        public List<Customer> getCustomer()
        {
            return unitOfWork.CustomerDal.FindAll();
        }

        public Customer GetCustomerByUsername(string username)
        {
            return unitOfWork.CustomerDal.Find(m => m.UserName.Equals(username));
        }

        public void Register(Customer customer)
        {
            unitOfWork.CustomerDal.Add(customer);
            unitOfWork.Complete();
        }
    }
}
