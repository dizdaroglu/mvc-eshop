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
    public class SizeTest
    {
        SizeManager sm = null;
        public SizeTest()
        {
            sm = new SizeManager();
        }
        // ürün idisne gore sizeleri ceken kod 
        [TestMethod]
        public void getSizes()
        {
             List<Size> listsize =  sm.GetSizeList();
            foreach (var item in listsize)
            {
                Debug.WriteLine(item.SizeName);
            }
            // Assert.AreEqual()
        }
    }
}
