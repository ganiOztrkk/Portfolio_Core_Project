using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioCoreProject.Areas.User.Models;

namespace PortfolioCoreProject.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    [Route("/User/[controller]/[action]")]
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DefaultController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity!.Name!);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserUpdateVM userUpdateVM)
        {
            var user = await _userManager.FindByNameAsync(User.Identity!.Name!);

            user!.ImageUrl = userUpdateVM.ImageUrl;
            user.Name = userUpdateVM.Name;
            user.Surname = userUpdateVM.Surname;
            user.UserName = userUpdateVM.Username;
            user.Email = userUpdateVM.Email;
            user.PhoneNumber = userUpdateVM.Phone;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

