using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class RecipesController : Controller
    {
        [HttpGet("recipes")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("recipes/{id}")]
        public IActionResult Recipe(Guid id)
        {
            return View(id);
        }
    }
}
