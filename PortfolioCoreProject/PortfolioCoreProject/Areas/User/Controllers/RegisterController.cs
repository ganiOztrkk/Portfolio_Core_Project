using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioCoreProject.Areas.User.Models;

namespace PortfolioCoreProject.Areas.User.Controllers
{
    [AllowAnonymous]
    [Area("User")]
    [Route("User/[controller]/[action]")]

    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManeger;

        public RegisterController(UserManager<AppUser> userManeger)
        {
            _userManeger = userManeger;
        }

        [HttpGet]
        public IActionResult Index()


        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterVM registerVM)
        {
            AppUser appUser = new AppUser()
            {
                UserName = registerVM.Username,
                Email = registerVM.Mail
            };

            if (registerVM.Password == registerVM.ConfirmPassword)
            {
                var result = await _userManeger.CreateAsync(appUser, registerVM.Password!);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View();
                }
            }
            ModelState.AddModelError("", "Passwords are not the same.");
            return View();
        }
    }
}

