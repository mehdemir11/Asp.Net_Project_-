using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EFSocialMediaDAL()); 
        public IActionResult Index()
        {
            var values = socialMediaManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia p)
        {
            p.status = true;
            socialMediaManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = socialMediaManager.TGetByID(id);
            socialMediaManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var values = socialMediaManager.TGetByID(id);
            socialMediaManager.TUpdate(values);
            return View();
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia p)
        {
            socialMediaManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
