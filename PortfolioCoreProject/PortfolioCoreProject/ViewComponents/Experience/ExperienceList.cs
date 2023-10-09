using System;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.Experience
{
	public class ExperienceList : ViewComponent
	{
        private readonly IExperienceService _experienceService = new ExperienceManager(new EfExperienceDal());

        public IViewComponentResult Invoke()
        {
            var values = _experienceService.GetList().Where(x => x.ExperienceStatus == true);
            return View(values);
        }
    }
}

