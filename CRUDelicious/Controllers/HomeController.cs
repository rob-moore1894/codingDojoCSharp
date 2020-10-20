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
            List<Dish> AllDishes = _context.Dishes.OrderByDescending(dish => dish.CreatedAt).ToList();
            return View(AllDishes);
        }

        [HttpGet("dish/new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("dish/new/submit")]
        public IActionResult CreateDish(Dish newDish)
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
            Dish OneDish = _context.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            return View(OneDish); 
        }

        [HttpGet("delete/{dishId}")]
        public IActionResult DeleteDish(int dishId)
        {
            Dish DishToDelete = _context.Dishes.SingleOrDefault(dish => dish.DishId == dishId); 
            _context.Remove(DishToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index"); 
        }

        [HttpGet("edit/{dishId}")]
        public IActionResult Edit(int dishId)
        {
            Dish DishToEdit = _context.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            return View(DishToEdit);
        }

        [HttpPost("edit/{dishId}/submit")]
        public IActionResult EditDish(int dishId, Dish editDish)
        {
            if(ModelState.IsValid)
            {
                Dish DishToEdit = _context.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
                DishToEdit.Name = editDish.Name;
                DishToEdit.Chef = editDish.Chef;
                DishToEdit.Calories = editDish.Calories;
                DishToEdit.Tastiness = editDish.Tastiness;
                DishToEdit.Description = editDish.Description;
                DishToEdit.UpdatedAt = editDish.UpdatedAt;
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("Edit");
            }
        }
        
    }
}
