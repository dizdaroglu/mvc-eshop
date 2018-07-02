using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class AdminCustomerController : Controller
    {
        ICustomerServices _customerServices;
        public AdminCustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }
        // GET: AdminCustomer
        public ActionResult getCustomer()
        {
            List<Customer> list = _customerServices.getCustomer();
            return View(list);
        }
        public ActionResult Details(int id)
        {
            Customer costumer = _customerServices.customerDetails(id);
            return View(costumer);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Customer customer = _customerServices.customerDetails(id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult Update(int id,Customer customer)
        {
            Customer findCustomer = _customerServices.customerDetails(id);
            findCustomer.Name = customer.Name;
            findCustomer.Password = customer.Password;
            findCustomer.Surname = customer.Surname;
            findCustomer.UserName = customer.UserName;
            findCustomer.Email = customer.Email;
           int s = _customerServices.customerUpdate();
            return RedirectToAction("getCustomer","AdminCustomer");
        }
        public ActionResult Delete(int id)
        {
            int res = _customerServices.customerDelete(id);
            return RedirectToAction("getCustomer","AdminCustomer");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer,HttpPostedFileBase resim)
        {
            WebImage ımage = new WebImage(resim.InputStream);
            FileInfo ınfo = new FileInfo(resim.FileName);
            String newImage = customer.Name + customer.Surname + customer.UserName + ınfo.Extension;
            ımage.Resize(300, 300);
            ımage.Save("~/img/resimler/" + newImage);
            customer.ProfileImage = "/img/resimler/" + newImage;


            int s = _customerServices.customerCreate(customer);

            return RedirectToAction("getCustomer","AdminCustomer");
        }

    }
}