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
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDAL());
        [HttpGet]
        public IActionResult Index()
        {
            var values = aboutManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
