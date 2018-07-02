using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class AdminCategoryController : Controller
    {
        ICategoryServices _categoryServices;
        public AdminCategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        // GET: AdminCategory
        public ActionResult getCategory()
        {
            List<Category> list = _categoryServices.GetCategories();
            return View(list);
        }
        public ActionResult Details(int id)
        {
            Category category = _categoryServices.categoryDetails(id);
            return View(category);
        }
        [HttpGet]
       public ActionResult Update(int id)
        {
            Category category = _categoryServices.categoryDetails(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Update(int id , Category category)
        {
            Category findCategory = _categoryServices.categoryDetails(id);
            findCategory.Description = category.Description;
            findCategory.Name = category.Name;
            findCategory.SubCategories = category.SubCategories;
            int s = _categoryServices.categoryUpdate();
            return RedirectToAction("getCategory", "AdminCategory");
        }
        public ActionResult Delete(int id)
        {
            int find = _categoryServices.categoryDelete(id);
            return RedirectToAction("getCategory", "AdminCategory");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            int s = _categoryServices.categoryCreate(category);
            return RedirectToAction("getCategory","AdminCategory");
        }
    }
}