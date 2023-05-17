using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[action]")]
    public class MyCourseController : Controller
    {
        private readonly ICourseRegisterService _courseRegisterService;
        private readonly UserManager<AppUser> _userManager;
        public MyCourseController(ICourseRegisterService courseRegisterService, UserManager<AppUser> userManager)
        {
            _courseRegisterService = courseRegisterService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            var values2 = _courseRegisterService.TCourseRegisterListWithCourseByUser(values.Id);

            return View(values2);
        }
    }
}
