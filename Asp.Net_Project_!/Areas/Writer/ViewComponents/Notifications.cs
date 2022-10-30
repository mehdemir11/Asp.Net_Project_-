using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.Areas.Writer.ViewComponents
{
    public class Notification:ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EFAnnouncementDAL());
        public IViewComponentResult Invoke()
        {
            var values = announcementManager.TGetList().Take(4).ToList();
            return View(values);
        }
    }
}
