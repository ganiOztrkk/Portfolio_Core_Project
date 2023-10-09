using System;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.Testimonial
{
	public class TestimonialList : ViewComponent
	{
        private readonly ITestimonialService _testimonialService = new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.GetList().Where(x => x.TestimonialStatus == true);
            return View(values);
        }
    }
}

