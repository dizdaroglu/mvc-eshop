﻿using eshop.BusinessLayer.Concreate;
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
   public class LoginTest
    {
        CustomerManager manager = null;

        public LoginTest()
        {
            manager = new CustomerManager();
        }
        [TestMethod]
        public void Login()
        {
            bool userName = manager.CustomerLogin("ert123","1234546");
            Debug.Write(userName);

        }
    }
}
