using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Dashboard
{
    public class NewExperienceList : ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EFExperienceDAL());
        public IViewComponentResult Invoke()
        {
            var values = experienceManager.TGetList();
            return View(values);
        }
    }
}
