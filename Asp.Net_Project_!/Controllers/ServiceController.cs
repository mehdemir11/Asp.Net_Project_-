using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EFServiceDAL());
        public IActionResult Index()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetByID(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values = serviceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
