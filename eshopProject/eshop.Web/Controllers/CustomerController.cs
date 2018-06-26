using eshop.BusinessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using eshop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
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

        public ActionResult MyAccount()
        {
            Customer loginCustomer = Session["loginCustomer"] as Customer;
            return View(loginCustomer);
        }

        // GET: Customer
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginDto loginDto)
        {
            bool res = _customerServices.CustomerLogin(loginDto.UserName, loginDto.password);
            Customer loginCustomer = _customerServices.GetCustomerByUsername(loginDto.UserName);
            if (res == true)
            {
                if (loginCustomer != null)
                {
                    Session["loginCustomer"] = loginCustomer;
                    Session.Timeout = 720; // Expire date!
                    return RedirectToAction("Index", "Home");
                }

            }
            else
            {
                ModelState.AddModelError("", "Kullanici adinizi veya şifrenizi kontrol ediniz.");
            }
            return View(loginDto);
        }

        public ActionResult Logout()
        {
            Session["loginCustomer"] = null;
            Session.Abandon();
            Session.Clear();

            return RedirectToAction("Index", "Product");
        }

        public ActionResult Register()
        {

            return View();
        }

        // Register alanına bak !
        [HttpPost]
        public ActionResult Register(Customer customer)
        {
            if (customer != null)
            {

                customer.CreatedDate = DateTime.Now;
                customer.ProfileImage = "/img/bay.png";
                if (_customerServices.AnyUsername(customer.UserName))
                {
                    ModelState.AddModelError("", "bu kullanici adi kullaniliyor");
                }
                else if (_customerServices.AnyEmail(customer.Email))
                {
                    ModelState.AddModelError("", "bu email  kullaniliyor");
                }
                else if (_customerServices.AnyUsername(customer.UserName) == false && _customerServices.AnyEmail(customer.Email) == false)
                {
                    // Crypto.Hash(customer.Password, "md5");
                    _customerServices.Register(customer);
                    ModelState.AddModelError("", "Başarıyla kayıt oldunuz.");
                    System.Threading.Thread.Sleep(3000);
                    return RedirectToAction("Login", "Customer");
                }
            }

            return View(customer);
        }

    }
}