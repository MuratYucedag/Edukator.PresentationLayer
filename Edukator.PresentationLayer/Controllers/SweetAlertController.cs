using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class SweetAlertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
