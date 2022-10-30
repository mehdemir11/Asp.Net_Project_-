using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EFExperienceDAL());
        public IActionResult Index()
        {
            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.TUpdate(values);
            return View();
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}
