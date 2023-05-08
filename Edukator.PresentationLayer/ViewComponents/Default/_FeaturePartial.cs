using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        private readonly IFeatureService _featureService;
        public _FeaturePartial(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _featureService.TGetList();
            return View(values);
        }
    }
}
