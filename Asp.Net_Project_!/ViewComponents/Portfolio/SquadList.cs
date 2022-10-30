using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Portfolio
{
    public class SquadList : ViewComponent
    {
        SquadManager squadManager = new SquadManager(new EFSquadDAL());
        public IViewComponentResult Invoke()
        {
            var values = squadManager.TGetList();
            return View(values);
        }
    }
}