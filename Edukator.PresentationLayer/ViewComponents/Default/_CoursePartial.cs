using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _CoursePartial : ViewComponent
    {
        private readonly ICourseService _courseService;
        public _CoursePartial(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _courseService.TGetCoursesWithCategories();
            return View(values);
        }
    }
}
