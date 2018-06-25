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
    }
}
