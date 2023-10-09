﻿using System;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.Contact
{
	public class ContactDetails : ViewComponent
	{
        private readonly IContactService _contactService = new ContactManager(new EfContactDal());

        public IViewComponentResult Invoke()
        {
            var values = _contactService.GetList().Where(x => x.ContactStatus == true);
            return View(values);
        }
    }
}

