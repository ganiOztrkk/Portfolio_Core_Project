using System;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.About
{
	public class AboutList : ViewComponent
	{
		private readonly IAboutService _aboutService;

        public AboutList(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
		{
			var values = _aboutService.GetList().Where(x => x.AboutStatus == true);
			return View(values);
		}
	}
}

