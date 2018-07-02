using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class FavController : Controller

    {
        private IFavServices favServices;
        private IProductServices productServices;
        public FavController(IFavServices favServices, IProductServices productServices)
        {
            this.favServices = favServices;
            this.productServices = productServices;
        }
        // GET: Fav
        public ActionResult AddToFav(int id)
        {
            Customer customer = Session["loginCustomer"] as Customer;
            if (customer != null)
            {
                Product product = productServices.GetProductById(id);
                Fav fav = new Fav()
                {
                    CustomerId = customer.CustomerId,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    productID = product.ProductId
                };

                favServices.AddFav(fav);
                return RedirectToAction("Details", "Product", new { id = id });
            }

            return RedirectToAction("Index", "Home");
        }
        public ActionResult RemoveFav(int id)
        {

            favServices.RemoveFav(id);
            return RedirectToAction("Index", "Product");


        }
        
    }
}