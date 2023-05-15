using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardCourseRegisterPartial : ViewComponent
    {
        private readonly ICourseRegisterService _courseRegisterService;
        public _DashboardCourseRegisterPartial(ICourseRegisterService courseRegisterService)
        {
            _courseRegisterService = courseRegisterService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _courseRegisterService.TCourseRegisterListWithCoursesAndUsers();
            return View(values);
        }
    }
}
