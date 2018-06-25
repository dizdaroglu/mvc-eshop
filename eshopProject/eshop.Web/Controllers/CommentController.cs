using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult DoComment(String comment)
        {
            // Login olan kullaniciyi bul ve yorum yaptır!.
            return View();
        }

        public ActionResult RemoveComment(int commentId)
        {
            // Yapılan yorumu sil 
            return View();
        }

        
    }
}