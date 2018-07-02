using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class AdminFavController : Controller
    {
        IFavServices _favServices;
        public AdminFavController(IFavServices favServices)
        {
            _favServices = favServices;
        }

        // GET: AdminFav
        public ActionResult getFav()
        {
            List<Fav> list = _favServices.GetFav();
            return View(list);
        }
        public ActionResult Details(int id)
        {
            Fav fav = _favServices.favDetails(id);
            return View(fav);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Fav fav = _favServices.favDetails(id);
            return View(fav);
        }
        [HttpPost]
        public ActionResult Update(int id, Fav fav)
        {
            Fav findFav = _favServices.favDetails(id);
            findFav.Customer = fav.Customer;
            findFav.Product = fav.Product;
            int s = _favServices.favUpdate();
            return RedirectToAction("getFav", "AdminFav");
        }
        public ActionResult Delete(int id)
        {
            int find = _favServices.favDelete(id);
            return RedirectToAction("getFav", "AdminFav");
        }
    }
}