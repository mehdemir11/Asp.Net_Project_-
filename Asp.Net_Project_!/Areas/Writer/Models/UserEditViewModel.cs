using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.Areas.Writer.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string PhoneNumber { get; set; }
        public string PictureUrl { get; set; }
        public string Email { get; set; }
        public IFormFile Picture { get; set; }
    }
}
