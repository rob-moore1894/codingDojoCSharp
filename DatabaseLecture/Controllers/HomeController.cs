using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DatabaseLecture.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLecture.Controllers
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
            // READ a user (Queries)
            ViewBag.AllUsers = _context.Users.ToList();
            return View();
        }

        // CREATE a user
        [HttpPost("postmethod")]
        public IActionResult postmethod(User newUser)
        {
            if(ModelState.IsValid) // Validations to ensure all required fields have been filled out
            {
                _context.Add(newUser); //Add the user to the table
                _context.SaveChanges(); // Save the changes
                return RedirectToAction("Index");
            } else {
                return View("Index");
            }
        }
    }
}
