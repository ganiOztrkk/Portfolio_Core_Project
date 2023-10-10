using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.GetList().Where(x => x.ServiceStatus == true);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            service.ServiceStatus = true;
            _serviceService.Insert(service);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var service = _serviceService.GetById(id);
            _serviceService.Delete(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var service = _serviceService.GetById(id);
            return View(service);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.Update(service);
            return RedirectToAction("Index");
        }

        public IActionResult PassiveService(int id)
        {
            var service = _serviceService.GetById(id);
            service.ServiceStatus = false;
            _serviceService.Update(service);
            return RedirectToAction("Index");
        }
    }
}

