using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;
        private readonly PortfolioValidator _validations;


        public PortfolioController(IPortfolioService portfolioService, PortfolioValidator validations)
        {
            _portfolioService = portfolioService;
            _validations = validations;
        }

        public IActionResult Index()
        {
            var values = _portfolioService.GetList().Where(x => x.PortfolioStatus == true);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            ValidationResult result = _validations.Validate(portfolio);

            if (result.IsValid)
            {
                portfolio.PortfolioStatus = true;
                _portfolioService.Insert(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }

        public IActionResult DeletePortfolio(int id)
        {
            var portfolio = _portfolioService.GetById(id);
            _portfolioService.Delete(portfolio);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var portfolio = _portfolioService.GetById(id);
            return View(portfolio);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            _portfolioService.Update(portfolio);
            return RedirectToAction("Index");
        }

        public IActionResult PassivePortfolio(int id)
        {
            var portfolio = _portfolioService.GetById(id);
            portfolio.PortfolioStatus = false;
            _portfolioService.Update(portfolio);
            return RedirectToAction("Index");
        }
    }
}

