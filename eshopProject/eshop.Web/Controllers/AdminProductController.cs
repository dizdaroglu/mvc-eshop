using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Views.Shared
{
    public class AdminProductController : Controller
    {
        IProductServices _productServices;
        IBrandServices _brandServices;
        public AdminProductController(IProductServices productServices,IBrandServices brandServices)
        {
            _productServices = productServices;
            _brandServices = brandServices;
        }
        // GET: AdminProduct
        public ActionResult getProduct()
        {
            List<Product> list = _productServices.GetProductList();
            return View(list);
        }
        public ActionResult Details(int id)
        {
            Product product = _productServices.productDetails(id);
            return View(product);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Product product = _productServices.productDetails(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Update(int id, Product product)
        {
            Product findProduct = _productServices.productDetails(id);
            findProduct.Name = product.Name;
            findProduct.Description = product.Description;
            findProduct.UnitPrice = product.UnitPrice;

            int s = _productServices.productUpdate();
            return RedirectToAction("getProduct", "AdminProduct");

        }
        public ActionResult Delete(int id)
        {
            int res = _productServices.productDelete(id);
            return RedirectToAction("getProduct", "AdminProduct");
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.BrandId = new SelectList(_brandServices.GetBrands(), "BrandId","BrandName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            int s = _productServices.productCreate(product);
            return RedirectToAction("getProduct", "AdminProduct");
        }
    }
}