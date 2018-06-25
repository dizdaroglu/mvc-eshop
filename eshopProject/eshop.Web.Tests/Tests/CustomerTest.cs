using eshop.BusinessLayer.Concreate;
using eshop.EntitiesLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Web.Tests.Tests
{
    [TestClass]
    public class CustomerTest
    {
        private CustomerManager cm = null;
        public CustomerTest()
        {
            cm = new CustomerManager();
        }
        [TestMethod]
        public void GetCustomerByUsernameTest()
        {
            Customer customer = cm.GetCustomerByUsername("ert123");
            Debug.WriteLine(customer.Name);
        }

    }
}
