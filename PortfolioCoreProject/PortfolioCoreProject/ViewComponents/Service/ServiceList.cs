using System;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.Service
{
	public class ServiceList : ViewComponent
	{
        private readonly IServiceService _serviceService = new ServiceManager(new EfServiceDal());

        public IViewComponentResult Invoke()
        {
            var values = _serviceService.GetList().Where(x => x.ServiceStatus == true);
            return View(values);
        }
    }
}