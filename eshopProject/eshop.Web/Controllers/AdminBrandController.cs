using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class AdminBrandController : Controller
    {
        IBrandServices _brandServices;
        public AdminBrandController(IBrandServices brandServices)
        {
            _brandServices = brandServices;
        }
        // GET: AdminBrand
        public ActionResult getBrand()
        {
            List<Brand> list = _brandServices.GetBrands();
            return View(list);
        }
        public ActionResult Details(int id)
        {
            Brand brand = _brandServices.brandDetails(id);
            return View(brand);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Brand brand = _brandServices.brandDetails(id);
            return View(brand);
        }
        [HttpPost]
        public ActionResult Update(int id, Brand brand)
        {
            Brand findBrand = _brandServices.brandDetails(id);
            findBrand.BrandIcon = brand.BrandIcon;
            findBrand.BrandName = brand.BrandName;
            findBrand.Products = brand.Products;
            int s = _brandServices.brandUpdate();
            return RedirectToAction("getBrand", "AdminBrand");
        }
        public ActionResult Delete(int id)
        {
            int res = _brandServices.brandDelete(id);
            return RedirectToAction("getBrand", "AdminBrand");

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Brand brand)
        {
            int s = _brandServices.brandCreate(brand);
            return RedirectToAction("getBrand", "AdminBrand");
        }
    }
}