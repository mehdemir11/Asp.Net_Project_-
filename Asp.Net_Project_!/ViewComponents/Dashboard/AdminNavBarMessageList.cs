using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Dashboard
{
    public class AdminNavBarMessageList:ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EFWriterMessageDAL());
        public IViewComponentResult Invoke()
        {
            string p = "mehmetcandemir12@outlook.com.tr";
            var values = writerMessageManager.GetListRecieversMessage(p).OrderByDescending(x => x.WriterMessageID).Take(3).ToList();
            return View(values);
        }
    }
}
