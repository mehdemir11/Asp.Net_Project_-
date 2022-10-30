using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EFMessageDAL());
        public IViewComponentResult Invoke()
        {
            var values = messageManager.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}
