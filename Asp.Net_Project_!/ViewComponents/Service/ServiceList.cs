using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EFServiceDAL());
        public IViewComponentResult Invoke()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }
    }
}
