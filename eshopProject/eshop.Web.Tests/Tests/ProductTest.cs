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
    public class ProductTest
    {
        ProductManager pm = null;
        public ProductTest()
        {
            pm = new ProductManager();
            
        }
        [TestMethod]
        public void GetProductsTest()
        {
            List<Product> list =  pm.GetProductList();
        }
        [TestMethod]
        public void GetProductById()
        {
            Product product = pm.GetProductById(1);
            Debug.WriteLine(product.Name);
        }
    }
}
