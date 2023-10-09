using System;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.Feature
{
	public class FeatureList : ViewComponent
	{
		private readonly IFeatureService _featureService = new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
		{
			var values = _featureService.GetList().Where(x => x.FeatureStatus == true);
			return View(values);
		}
	}
}

