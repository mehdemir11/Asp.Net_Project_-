using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EFContactDAL());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetList();
            return View(values);
        }
    }
}
