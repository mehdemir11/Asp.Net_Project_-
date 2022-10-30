using Asp.Net_Project__.Areas.Writer.Models;
using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]

    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.writerUserName;
            model.Surname = values.writerUserSurname;
            model.PhoneNumber = values.PhoneNumber;
            model.PictureUrl = values.writerUserImageUrl;
            model.Email = values.Email;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Picture != null)
            {
                var resouce = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Picture.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resouce + "/wwwroot/userimage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Picture.CopyToAsync(stream);
                user.writerUserImageUrl = imagename;
            }
            user.writerUserName = p.Name;
            user.writerUserSurname = p.Surname;
            user.PhoneNumber = p.PhoneNumber;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            else
            {

            }
            return View();
        }
    }
}
