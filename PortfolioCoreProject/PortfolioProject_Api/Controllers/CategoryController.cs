using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject_Api.DAL.ApiContext;
using PortfolioProject_Api.DAL.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PortfolioProject_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            using var context = new Context();
            return Ok(context.Categories.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            using var context = new Context();
            var value = context.Categories.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            using var context = new Context();
            context.Add(category);
            context.SaveChanges();
            return Created("", category);
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            using var context = new Context();
            var value = context.Categories.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            context.Remove(value);
            context.SaveChanges();
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            using var context = new Context();
            var value = context.Find<Category>(category.CategoryId);
            if (value == null)
            {
                return NotFound();
            }
            value.CategoryName = category.CategoryName;
            context.Update(value);
            context.SaveChanges();
            return Ok();
        }
    }
}

