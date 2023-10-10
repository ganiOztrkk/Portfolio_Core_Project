using System;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.Dashboard
{
	public class TopStatistics : ViewComponent
	{
		Context context = new Context();
		public IViewComponentResult Invoke()
		{
			List<int> values = new List<int>();
			foreach (var item in context.Skills)
			{
				values.Add(Convert.ToInt32(item.Value));
			}
			ViewBag.SkillCount = context.Skills.Count();
			ViewBag.SkillValue = values.Average();
			ViewBag.UnreadMessages = context.Messages.Where(x => x.ReadStatus == false).Count(); 
			ViewBag.TotalMessages = context.Messages.Count();
			ViewBag.ExperienceCount = context.Experiences.Count();
			return View();
		}
	}
}

