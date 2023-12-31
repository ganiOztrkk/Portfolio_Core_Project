﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.Controllers
{
    
    public class DefaultController : Controller
    {
        private readonly IMessageService _messageService;

        public DefaultController(IMessageService messageService)
        {
            _messageService = messageService;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessagePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SendMessagePartial(Message message)
        {
            message.Date = DateTime.Now;
            message.ReadStatus = true;
            message.MessageStatus = true;
            _messageService.Insert(message);
            return PartialView("Index");
        }


        public IActionResult Inbox()
        {
            var values = _messageService.GetList().Where(x => x.MessageStatus == true);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var message = _messageService.GetById(id);
            message.ReadStatus = false;
            _messageService.Update(message);
            return View(message);
        }

        public IActionResult DeleteMessage(int id)
        {
            var message = _messageService.GetById(id);
            _messageService.Delete(message);
            return RedirectToAction("Inbox");
        }

        public IActionResult ArchiveMessage(int id)
        {
            var message = _messageService.GetById(id);
            message.MessageStatus = false;
            _messageService.Update(message);
            return RedirectToAction("Inbox");
        }
    }
}