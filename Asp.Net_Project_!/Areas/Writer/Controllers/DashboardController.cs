using Data_Access_Layer.Concrete;
using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Asp.Net_Project__.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.writerUserName;

            //Statistics
            Context c = new Context();
            ViewBag.v1 = c.WriterMessages.Where(x => x.Receiver == values.Email).Count();
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.Users.Count();
            ViewBag.v4 = c.Squads.Count();
            

            //weather api
            string api = @"ffc9a2142d3850ec7731be306237b906";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=izmir&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
//http://api.openweathermap.org/data/2.5/weather?q=izmir&mode=xml&lang=tr&units=metric&appid=ffc9a2142d3850ec7731be306237b906