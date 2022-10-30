using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.Controllers
{
    public class ContactMessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EFMessageDAL());

        public IActionResult Index()
        {
            var values = messageManager.TGetList();
            return View(values);
        }
        public IActionResult DeleteContactMessage(int id)
        {
            var values = messageManager.TGetByID(id);
            messageManager.TDelete(values);
            return RedirectToAction("OutBox");
        }
        public IActionResult ContentDetails(int id)
        {
            var values = messageManager.TGetByID(id);
            return View(values);
        }
    }
}
