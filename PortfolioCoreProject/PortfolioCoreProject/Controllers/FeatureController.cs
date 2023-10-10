using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var value = _featureService.GetById(1);
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            _featureService.Update(feature);
            return RedirectToAction("Index");
        }
    }
}

