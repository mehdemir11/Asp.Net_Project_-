using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDAL());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View(values);
        }
    }
}
