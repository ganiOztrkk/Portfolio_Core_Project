using System;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.Skill
{
	public class SkillList : ViewComponent
	{
        private readonly ISkillService _skillService;

        public SkillList(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _skillService.GetList().Where(x => x.SkillStatus == true);
            return View(values);
        }
    }
}

