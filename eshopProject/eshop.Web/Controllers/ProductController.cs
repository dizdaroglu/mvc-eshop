using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        //// GET: Product
        //public ActionResult Index()
        //{
        //    List<Product> list = _productServices.GetProductList();
        //    return View(list);
        //}

        public ActionResult Details(int id)
        {
            Product product = _productServices.GetProductById(id);
            return View(product);
        }

        public ActionResult Index(String searchBy, String res)
        {
            List<Product> listProducts = _productServices.SearchList(searchBy, res);
            return View(listProducts);
        }



    }
}