using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.BusinessLayer.Abstract
{
    public interface ICustomerServices
    {
        bool CustomerLogin(string userName,string password);

        Customer GetCustomerByUsername(String username);

        void Register(Customer customer);

        bool AnyEmail(String email);

        bool AnyUsername(String username);

        #region Admin
        List<Customer> getCustomer();
        int customerCount();
        Customer customerDetails(int id);
        int customerUpdate();
        int customerDelete(int id);
        int customerCreate(Customer customer);
        #endregion
    }
}
