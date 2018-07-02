using eshop.BusinessLayer.Abstract;
using System;
using eshop.EntitiesLayer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class AdminSizeController : Controller
    {
        ISizeServices _sizeServices;
        IProductServices _productSevices;
        public AdminSizeController(ISizeServices sizeServices,IProductServices productServices)
        {
            _sizeServices = sizeServices;
            _productSevices = productServices;
        }
        // GET: AdminSize
        public ActionResult getSize()
        {
            List<Size> list = _sizeServices.GetSizeList();
            return View(list);
        }
        public ActionResult Details(int id)
        {
            Size size = _sizeServices.sizeDetails(id);
            return View(size);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Size size = _sizeServices.sizeDetails(id);
            return View(size);
        }
        [HttpPost]
        public ActionResult Update(int id, Size size)
        {
            Size findSize = _sizeServices.sizeDetails(id);
            findSize.Product = size.Product;
           
            findSize.SizeName = size.SizeName;
            int s = _sizeServices.sizeUpdate();
            return RedirectToAction("getSize", "AdminSize");
        }
        public ActionResult Delete(int id)
        {
            int find = _sizeServices.sizeDelete(id);
            return RedirectToAction("getSize", "AdminSize");
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.ProductId = new SelectList(_productSevices.GetProductList(),"ProductId","Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Size size)
        {
            int s = _sizeServices.sizeCreate(size);
            return RedirectToAction("getSize","AdminSize");
        }
    }
}