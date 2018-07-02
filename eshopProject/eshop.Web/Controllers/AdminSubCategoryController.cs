using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class AdminSubCategoryController : Controller
    {
        ISubCategoryServices _subcategoryServices;
        ICategoryServices _categoryServices;
        public AdminSubCategoryController(ISubCategoryServices subcategoryServices, ICategoryServices categoryServices)
        {
            _subcategoryServices = subcategoryServices;
            _categoryServices = categoryServices;

        }
        // GET: AdminSubCategory
        public ActionResult getSubCategory()
        {
            List<SubCategory> list = _subcategoryServices.getSubCategory();
            return View(list);
        }
        public ActionResult Details(int id)
        {
            SubCategory subcategory = _subcategoryServices.subcategoryDetails(id);
            return View(subcategory);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            SubCategory subCategory = _subcategoryServices.subcategoryDetails(id);
            return View(subCategory);
        }
        [HttpPost]
        public ActionResult Update(int id, SubCategory subCategory)
        {
            SubCategory findsubCategory = _subcategoryServices.subcategoryDetails(id);
            findsubCategory.Category = subCategory.Category;
            findsubCategory.Products = subCategory.Products;
            findsubCategory.SubCategoryDescription = subCategory.SubCategoryDescription;
            findsubCategory.SubCategoryName = subCategory.SubCategoryName;
            int s = _subcategoryServices.subcategoryUpdate();
            return RedirectToAction("getSubCategory", "AdminSubCategory");
        }
        public ActionResult Delete(int id)
        {
            int find = _subcategoryServices.subcategoryDelete(id);
            return RedirectToAction("getSubCategory", "AdminSubCategory");
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(_categoryServices.GetCategories(), "CategoryId", "Name");
    
            return View();
        }
        [HttpPost]
        public ActionResult Create(SubCategory subCategory)
        {
            int s = _subcategoryServices.subcategoryCreate(subCategory);
            return RedirectToAction("getSubCategory", "AdminSubCategory");
        }
    }
}