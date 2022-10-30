using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.SocialMedia
{
    public class SocialMediaList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SocialMediaManager socialMediaManager = new SocialMediaManager(new EFSocialMediaDAL());
            var values = socialMediaManager.TGetList();
            return View(values);
        }
    }
}
