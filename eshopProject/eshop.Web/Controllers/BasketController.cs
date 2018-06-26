using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class BasketController : Controller
    {
        private IBasketServices _basketServices;
        private IProductServices _productServices;
        public BasketController(IBasketServices basketServices,IProductServices productServices)
        {
            _basketServices = basketServices;
            _productServices = productServices;
        }
        // GET: Basket
        //public ActionResult BasketList()
        //{
        //    Customer loginCustomer = Session["loginCustomer"] as Customer;
        //    List<Basket> list = _basketServices.GetBaskets(loginCustomer.UserName);

        //    return View();
        //}

        public ActionResult RemoveBasket(int id)
        {
             _basketServices.RemoveBasket(id);

            return RedirectToAction("Index", "Product");
        }

        public ActionResult AddToBasket(int id)
        {
            Customer loginCustomer = Session["loginCustomer"] as Customer;
            Product product = _productServices.GetProductById(id);
            if (Session["loginCustomer"] != null)
            {
                Basket basket = new Basket()
                {
                    CustomerId = loginCustomer.CustomerId,
                    ProductId = product.ProductId,
                    CreatedDate = DateTime.Now
                };
                _basketServices.AddToBasket(basket);
                return RedirectToAction("Index", "Product");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}