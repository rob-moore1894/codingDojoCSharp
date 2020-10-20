using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context; 
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // All Dishes
            ViewBag.AllDishes = _context.Dishes.OrderByDescending(dish => dish.CreatedAt).ToList();
            return View();
        }

        [HttpGet("new")]
        [HttpPost("new")]
        public IActionResult New(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index"); 
            } else {
                return View("New");
            }
        }

        [HttpGet("{dishId}")]
        public IActionResult Show(int dishId)
        {
            ViewBag.OneDish = _context.Dishes.Where(dish => dish.DishId == dishId);
            return View(); 
        }

        [HttpPost("delete/{dishId}")]
        public IActionResult DeleteDish(int dishId)
        {
            Dish DishToDelete = _context.Dishes.SingleOrDefault(dish => dish.DishId == dishId); 
            _context.Dishes.Remove(DishToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index"); 
        }

        [HttpPost("edit/{dishId}")]
        public IActionResult EditDish(int dishId)
        {
            Dish DishToEdit = _context.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            return RedirectToAction("Edit");
        }
        
    }
}
