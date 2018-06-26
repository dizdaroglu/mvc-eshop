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
    public class FavTest
    {
        private FavManager favManager;
        public FavTest()
        {
            favManager = new FavManager();
        }

        //[TestMethod]
        //public void AddFav()
        //{
        //    Fav fav = new Fav()
        //    {
        //        CreatedDate = DateTime.Now,
        //        CustomerId = 1,
        //        productID = 3,
        //        ModifiedDate = DateTime.Now


        //    };
        //    favManager.AddFav(fav);

        //}
        //[TestMethod]
        //public void RemoveFav()
        //{

        //    favManager.RemoveFav(6);

        //}
        [TestMethod]
        public void GetFavList()
        {
           List<Fav> list = favManager.GetFavList(1);
            foreach (var item in list)
            {
                Debug.WriteLine(item.Product.Name);
            }
        }
    }
    
}
