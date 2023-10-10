using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace PortfolioCoreProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var value = _aboutService.GetById(1);
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            _aboutService.Update(about);
            return RedirectToAction("Index");
        }
    }
}

