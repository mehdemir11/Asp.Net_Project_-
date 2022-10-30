using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EFMessageDAL());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            //var values = experienceManager.TGetList();
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.status = true;
        //    messageManager.TAdd(p);
        //    return View();
        //}
    }
}
