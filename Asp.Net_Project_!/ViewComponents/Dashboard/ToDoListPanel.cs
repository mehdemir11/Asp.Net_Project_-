using Business_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EFToDoListDAL());
        public IViewComponentResult Invoke()
        {
            var values = toDoListManager.TGetList();
            return View(values);
        }
    }
}
