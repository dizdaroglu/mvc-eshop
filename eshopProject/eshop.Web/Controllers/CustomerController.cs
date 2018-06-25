using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using eshop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class CustomerController : Controller
    {

        private ICustomerServices _customerServices;
        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }
        // GET: Customer
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginDto loginDto)
        {
             bool res =  _customerServices.CustomerLogin(loginDto.UserName, loginDto.password);
            Customer loginCustomer = _customerServices.GetCustomerByUsername(loginDto.UserName);
            if (res==true)
            {
                if (loginCustomer!=null)
                {
                    Session["loginCustomer"] = loginCustomer;
                    return RedirectToAction("Index", "Home");
                }
                
             }
            else
            {
                ModelState.AddModelError("", "Kullanici adinizi veya şifrenizi kontrol ediniz.");
            }
            return View(loginDto);
        }
    }
}