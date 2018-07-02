using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class AdminCommentController : Controller
    {

        private ICommentServices _commentServices;
        private IProductServices _productServices;
        private ICustomerServices _customerServices;
        public AdminCommentController(ICustomerServices customerServices,ICommentServices commentServices,IProductServices productServices)
        {
            _commentServices = commentServices;
            _productServices = productServices;
            _customerServices = customerServices;
        }

        // GET: AdminComment
        public ActionResult getList()
        {
            List<Comments> list = _commentServices.getComment();

            return View(list);
        }
        public ActionResult Details(int id)
        {
            Comments comment = _commentServices.commentsDetails(id);
            return View(id);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Comments comments = _commentServices.commentsDetails(id);
            return View(comments);
        }
        [HttpPost]
        public ActionResult Update(int id , Comments comments)
        {
            Comments findComment = _commentServices.commentsDetails(id);          
            findComment.Customer = comments.Customer;
            findComment.Product = comments.Product;            
            findComment.Text = comments.Text;
            int s = _commentServices.commentsUpdate();
            return RedirectToAction("getList", "AdminComment");
        }
        public ActionResult Delete(int id)
        {
            int find = _commentServices.commentsDelete(id);
            return RedirectToAction("getList","AdminComment");
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.ProductId = new SelectList(_productServices.GetProductList(),"ProductId","Name");
            ViewBag.CustomerId = new SelectList(_customerServices.getCustomer(), "CustomerId", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Comments comments)
        {
            int s = _commentServices.commentCreate(comments);
            return RedirectToAction("getList", "AdminComment");
        }
    }
}