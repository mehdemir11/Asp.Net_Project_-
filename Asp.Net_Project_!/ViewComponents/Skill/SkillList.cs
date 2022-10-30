using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EFSkillDAL());
        public IViewComponentResult Invoke()
        {
            var values = skillManager.TGetList();
            return View(values);
        }
    }
}
