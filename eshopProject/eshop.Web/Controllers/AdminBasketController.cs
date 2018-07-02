using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class AdminBasketController : Controller
    {
        IBasketServices _basketServices;
        public AdminBasketController(IBasketServices basketServices)
        {
            _basketServices = basketServices;
        }
        // GET: AdminBasket
        public ActionResult getBasket()
        {
            List<Basket> list = _basketServices.getBasket();
            return View(list);
        }
        public ActionResult Details(int id)
        {
            Basket basket = _basketServices.basketDetails(id);
            return View(basket);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Basket basket = _basketServices.basketDetails(id);
            return View(basket);
        }
        [HttpPost]
        public ActionResult Update(int id,Basket basket)
        {
            Basket findBasket = _basketServices.basketDetails(id);
            findBasket.Customer = basket.Customer;
            findBasket.Product = basket.Product;
            findBasket.ProductId = basket.ProductId;
            findBasket.BasketId = basket.BasketId;
            int s = _basketServices.basketUpdate();
            return RedirectToAction("getBasket","AdminBasket");
        }
        public ActionResult Delete(int id)
        {
            int res = _basketServices.basketDelete(id);
            return RedirectToAction("getBasket","AdminBasket");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Basket basket)
        {
            int s = _basketServices.basketCreate(basket);
            return RedirectToAction("getBasket","AdminBasket");
        }
    }
}