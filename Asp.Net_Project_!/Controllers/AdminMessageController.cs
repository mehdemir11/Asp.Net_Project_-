using Business_Layer.Concrete;
using Data_Access_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EFWriterMessageDAL());

        public IActionResult InBox()
        {
            string p;
            p = "mehmetcandemir12@outlook.com.tr";
            var values = writerMessageManager.GetListRecieversMessage(p);
            return View(values);
        }
        public IActionResult OutBox()
        {
            string p;
            p = "mehmetcandemir12@outlook.com.tr";
            var values = writerMessageManager.GetListSendersMessage(p);
            return View(values);
        }
        public IActionResult MessageContentDetails(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            return View(values);
        }
        public IActionResult DeleteContactMessage(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            writerMessageManager.TDelete(values);
            return RedirectToAction("AdminMessage");
        }
        [HttpGet]
        public IActionResult AdminSendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminSendMessage(WriterMessage p)
        {
            p.Sender = "mehmetcandemir12@outlook.com.tr";
            p.SenderName = "Mehmetcan Demir";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usersurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.writerUserName + " " + y.writerUserSurname).FirstOrDefault();
            writerMessageManager.TAdd(p);
            return RedirectToAction("OutBox");
        }
    }
}
