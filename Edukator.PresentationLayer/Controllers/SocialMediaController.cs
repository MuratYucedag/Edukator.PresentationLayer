using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;
        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        public IActionResult Index()
        {
            var values = _socialMediaService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaService.TInsert(socialMedia);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var values = _socialMediaService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaService.TUpdate(socialMedia);
            return RedirectToAction("Index");
        }
    }
}
