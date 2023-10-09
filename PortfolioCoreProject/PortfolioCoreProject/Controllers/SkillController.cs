using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            var values = _skillService.GetList().Where(x=>x.SkillStatus == true);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skill.SkillStatus = true;
            _skillService.Insert(skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var skill = _skillService.GetById(id);
            _skillService.Delete(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var skill = _skillService.GetById(id);
            return View(skill);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            _skillService.Update(skill);
            return RedirectToAction("Index");
        }

        public IActionResult PassiveSkill(int id)
        {
            var skill = _skillService.GetById(id);
            skill.SkillStatus = false;
            _skillService.Update(skill);
            return RedirectToAction("Index");
        }
    }
}