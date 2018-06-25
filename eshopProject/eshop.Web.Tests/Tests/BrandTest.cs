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
    public class BrandTest
    {
        BrandManager bm = null;
        public BrandTest()
        {
            bm = new BrandManager();
        }
        
        [TestMethod]
        public void GetBrandsTest()
        {
            List<Brand> list =  bm.GetBrands();
            foreach (var item in list)
            {
                Debug.WriteLine(item.BrandName);
            }
        }
    }
}
