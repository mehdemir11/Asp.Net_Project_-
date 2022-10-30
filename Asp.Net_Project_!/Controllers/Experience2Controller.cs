using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EFExperienceDAL());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
        public IActionResult GetById(int experienceID)
        {
            var v= experienceManager.TGetByID(experienceID);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }
        public IActionResult DeleteExperience(int id)
        {
            var v = experienceManager.TGetByID(id);
            experienceManager.TDelete(v);
            return NoContent();
        }
        [HttpPost]
        public IActionResult UpdateExperience(int experienceID,string Title,string Task)
        {
            var v = experienceManager.TGetByID(experienceID);
            if (v!=null)
            {
                v.experienceTitle = Title;
                v.experienceDate = Task;
                experienceManager.TUpdate(v);
                var values = JsonConvert.SerializeObject(v);
                return Json(values);
            }
            else
            {
                return Json(new object());
            }
                
        }
    }
}
