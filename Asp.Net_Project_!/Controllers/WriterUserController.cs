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
    public class WriterUserController : Controller
    {
        WriterUserManager writerUserManager = new WriterUserManager(new EFWriterUserDAL());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(writerUserManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddUser(WriterUser p)
        {
            writerUserManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}
