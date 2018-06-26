using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryServices _categoryServices;
        private IColorServices _colorServices;
        private ISizeServices _sizeServices;
        private IBrandServices _brandServices;
        private IBasketServices _basketServices;
        public HomeController( IBasketServices basketServices, ICategoryServices categoryServices,IColorServices colorServices,ISizeServices sizeServices,IBrandServices brandServices)
        {
            _categoryServices = categoryServices;
            _colorServices = colorServices;
            _sizeServices = sizeServices;
            _brandServices = brandServices;
            _basketServices = basketServices;
        }

        public ActionResult Index()
        {
             List<Category> list = _categoryServices.GetCategories();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult _CategoryListPartial()
        {
            List<Category> list = _categoryServices.GetCategories();
            return View(list);
        }
        public ActionResult _SearchPartial()
        {
            List<Category> liste = _categoryServices.GetCategories();
            return View(liste);
        }

        public ActionResult _PartialColors()
        {
            List<Colors> colorList = _colorServices.GetColors();
            return View(colorList);
        }

        public ActionResult _PartialSizes()
        {
            List<Size> sizeList = _sizeServices.GetSizeList();
            return View(sizeList);
        }

        public ActionResult _PartialBrands()
        {
            List<Brand> brands = _brandServices.GetBrands();
            return View(brands);
        }
        public ActionResult _MenuNavPartial()
        {
            List<Category> list = _categoryServices.GetCategories();
            return View(list);
        }

        public ActionResult _BasketPartial()
        {
            Customer loginCustomer = Session["loginCustomer"] as Customer;
            List<Basket> list = _basketServices.GetBaskets(loginCustomer.UserName);
            return View(list);
        }
            
    }
}