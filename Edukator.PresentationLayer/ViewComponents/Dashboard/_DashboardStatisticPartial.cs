using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardStatisticPartial : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.totalCourseCount = context.Courses.Count();
            ViewBag.totalCourseCategory = context.Categories.Count();
            ViewBag.totalMemberCount = context.Users.Count();
            ViewBag.messageBoxCount = context.Contacts.Count();
            return View();
        }
    }
}
