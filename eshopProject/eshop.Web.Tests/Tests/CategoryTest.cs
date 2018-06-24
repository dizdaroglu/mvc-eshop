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
    public class CategoryTest
    {
        CategoryManager manager = null;
        public CategoryTest()
        {
            manager = new CategoryManager();
        }
        [TestMethod]
        public void GetCategories()
        {
            List<Category> list = manager.GetCategories();
            foreach (var item in list)
            {
                Debug.WriteLine(item.Description);
                
            }

        }
    }
}
