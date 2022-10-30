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
    public class PortfoliosContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EFContactDAL());
        [HttpGet]
        public IActionResult Index()
        {
            var values = contactManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contactManager.TUpdate(contact);
            return RedirectToAction("Index", "Default");
        }
    }
}
