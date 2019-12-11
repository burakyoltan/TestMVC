using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eTicaretMVC.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz.")]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}