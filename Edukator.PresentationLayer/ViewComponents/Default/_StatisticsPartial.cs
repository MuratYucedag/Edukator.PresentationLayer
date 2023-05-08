using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _StatisticsPartial:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Categories.Count();
            ViewBag.v2 = context.Courses.Count();
            ViewBag.v3 = 684;
            return View();
        }
    }
}
