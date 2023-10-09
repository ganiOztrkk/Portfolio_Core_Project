using System;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.Portfolio
{
	public class PortfolioList : ViewComponent
	{
        private readonly IPortfolioService _portfolioService = new PortfolioManager(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = _portfolioService.GetList().Where(x => x.PortfolioStatus == true);
            return View(values);
        }
    }
}

