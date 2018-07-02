using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class AdminController : Controller
    {
        ICommentServices _commentServices;
        ICustomerServices _customerServices;
        IBasketServices _basketServices;
        IProductServices _productServices;
        public AdminController(IProductServices productServices,ICommentServices commentServices, ICustomerServices customerServices, IBasketServices basketServices)
        {
            _commentServices = commentServices;
            _customerServices = customerServices;
            _basketServices = basketServices;
            _productServices = productServices;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult _AdminSideMenuPartial()
        {
            return View();
        }
        public ActionResult _AdminHeaderPartial()
        {
            ViewBag.CommentSayisi= _commentServices.commentCount();
            ViewBag.CustomerSayisi = _customerServices.customerCount();
            ViewBag.BasketSayisi = _basketServices.basketCount();
            ViewBag.ProductSayisi = _productServices.productCount();
            return View();
        }
    }
}