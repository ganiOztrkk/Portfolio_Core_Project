using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IExperienceService _experienceService; 

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            var values = _experienceService.GetList().Where(x => x.ExperienceStatus == true);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experience.ExperienceStatus = true;
            _experienceService.Insert(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var experience = _experienceService.GetById(id);
            _experienceService.Delete(experience);
            return RedirectToAction("Index");
        }

        public IActionResult PassiveExperience(int id)
        {
            var experience = _experienceService.GetById(id);
            experience.ExperienceStatus = false;
            _experienceService.Update(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var experience = _experienceService.GetById(id);
            return View(experience);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            _experienceService.Update(experience);
            return RedirectToAction("Index");
        } 
    }
}