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
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDAL());
        public IActionResult Index()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial p)
        {
            testimonialManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var values = testimonialManager.TGetByID(id);
            testimonialManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var values = testimonialManager.TGetByID(id);
            testimonialManager.TUpdate(values);
            return View();
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}
