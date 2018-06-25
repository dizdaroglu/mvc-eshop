using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eshop.Web.Models
{
    public class LoginDto
    {

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi  giriniz")]
        [Display(Name = "Şifre")]
        public string password { get; set; }
    }
}