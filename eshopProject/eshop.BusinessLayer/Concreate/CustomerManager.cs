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
       
        public bool CustomerLogin(string userName, string password)
        {
            
               return unitOfWork.CustomerDal.FindAll().Any(m=>m.UserName.Equals(userName) && m.Password.Equals(password));
            
         
        }

        public Customer GetCustomerByUsername(string username)
        {
            return unitOfWork.CustomerDal.Find(m => m.UserName.Equals(username));
        }

    }
}
