using Data_Access_Layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Skills.Count();
            ViewBag.v2 = c.Messages.Where(x => x.status==false).Count();
            ViewBag.v3 = c.Messages.Where(x => x.status == true).Count();
            ViewBag.v4 = c.Experiences.Count();

            return View();
        }
    }
}
