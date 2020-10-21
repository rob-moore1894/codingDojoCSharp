using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
    
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            _context = context;
        }


        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> AllChefs = _context.Chefs.Include(c => c.Dishes).ToList(); 
            return View(AllChefs);
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {
            return View(); 
        }

        [HttpPost("new/submit")]
        public IActionResult SaveChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("NewChef");
            }
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> AllDishes = _context.Dishes.Include(c => c.Owner).ToList();
            return View(AllDishes); 
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            ViewBag.AllChefs = _context.Chefs.ToList();
            return View(); 
        }

        [HttpPost("dishes/new/submit")]
        public IActionResult SaveDish(Dish newDish)
        {
            ViewBag.AllChefs = _context.Chefs.ToList();
            if(ModelState.IsValid)
            {
                _context.Dishes.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Dishes");
            } else {
                return View("NewDish");
            }
        }
    }
}
