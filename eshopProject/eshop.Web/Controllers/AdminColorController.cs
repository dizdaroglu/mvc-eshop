using eshop.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eshop.EntitiesLayer.Models;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class AdminColorController : Controller
    {
        IColorServices _colorServices;
        IProductServices _productServices;
        public AdminColorController(IColorServices colorServices,IProductServices productServices)
        {
            _colorServices = colorServices;
            _productServices = productServices;
        }
        // GET: AdminColor
        public ActionResult getColor()
        {
            List<Colors> list = _colorServices.GetColors();
            return View(list);
        }
        public ActionResult Details(int id)
        {
            Colors color = _colorServices.colorDetails(id);
            return View(color);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Colors colors = _colorServices.colorDetails(id);
            return View(colors);
        }
        [HttpPost]
        public ActionResult Update(int id, Colors colors)
        {
            Colors findColors = _colorServices.colorDetails(id);
            findColors.Code = colors.Code;
            findColors.Name = colors.Name;
            findColors.Product = colors.Product;
            int s = _colorServices.colorUpdate();
            return RedirectToAction("getColor", "AdminColor");
        }
        public ActionResult Delete(int id)
        {
            int find = _colorServices.colorDelete(id);
            return RedirectToAction("getDelete", "AdminDelete");
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.ProductId = new SelectList(_productServices.GetProductList(),"ProductId","Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Colors color)
        {
            int s = _colorServices.colorCreate(color);
            return RedirectToAction("getColor", "AdminColor");
        }
    }
}