using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDAL());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
        
    }
}
