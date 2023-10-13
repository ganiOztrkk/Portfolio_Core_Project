using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace PortfolioCoreProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var value = _contactService.GetById(1);
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _contactService.Update(contact);
            return RedirectToAction("Index");
        }

    }
}

