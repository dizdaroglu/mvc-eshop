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
    public class ColorTest
    {
        private ColorManager colorManager;
        public ColorTest()
        {
            colorManager = new ColorManager();
        }

        [TestMethod]
        public void getColors()
        {
           List<Colors> colors =  colorManager.GetColors();
            foreach (var item in colors)
            {
                Debug.WriteLine(item.Name);
            }
        }

    }
}
