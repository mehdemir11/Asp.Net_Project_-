using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {

        [Required(ErrorMessage = "Lütfen Adınızı Giriniz! ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lütfen Soy Adınızı Giriniz! ")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz! ")]
        public string NickName { get; set; }
        
        [Required(ErrorMessage = "Lütfen Resim URL Giriniz! ")]
        public string ImageUrl { get; set; }
        
        [Required(ErrorMessage = "Lütfen Şifre Giriniz! ")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Lütfen Şifreyi Onaylayınız! ")]
        [Compare("Password",ErrorMessage = "Şifreler Uyuşmamaktadır! ")]
        public string ConfirmPassword { get; set; }
        
        [Required(ErrorMessage = "Lütfen e-Mail Adresinizi Giriniz! ")]
        public string Mail { get; set; }
    }
}
