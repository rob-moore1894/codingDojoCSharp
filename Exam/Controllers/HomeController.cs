using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exam.Models;
using Microsoft.AspNetCore.Identity; 
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Exam.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
    
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            _context = context;
        }
        // Login Register Page
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        // Register - POST
        [HttpPost("Register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(e => e.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>(); 
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("logged_in", newUser.UserId);
                return RedirectToAction("home");
            } else {
                return View("Index");
            }
        }

        // Post request for Login
        [HttpPost("Login")]
        public IActionResult Login(LUser login)
        {
            if(ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == login.LEmail); 
                if(userInDb == null)
                {
                    ModelState.AddModelError("LEmail", "Invalid Login"); 
                    return View("Index");
                } else {
                    var hasher = new PasswordHasher<LUser>();
                    var result = hasher.VerifyHashedPassword(login, userInDb.Password, login.LPassword);
                    if(result == 0)
                    {
                        ModelState.AddModelError("LEmail", "Invalid Login"); 
                        return View("Index");
                    }
                    HttpContext.Session.SetInt32("logged_in", userInDb.UserId);
                    return RedirectToAction("home");
                }
            } else {
                return View("Index"); 
            }
        }

        // Dashboard Page for logged in user
        [HttpGet("home")]
        public IActionResult Home()
        {
            int? loggedIn = HttpContext.Session.GetInt32("logged_in");
            if(loggedIn == null)
            {
                return RedirectToAction("Index");
            } else {
                ViewBag.LoggedIn = _context.Users.FirstOrDefault(a => a.UserId == (int)loggedIn);
                return View();
            }
        }

        // Add activity page - GET
        [HttpGet("new")]
        public IActionResult NewActivity()
        {
            int? loggedIn = HttpContext.Session.GetInt32("logged_in");
            if(loggedIn == null)
            {
                return RedirectToAction("Index");
            } else {
                return View();
            }
        }

        // Create activity - POST
        [HttpPost("NewActivity")]
        public IActionResult CreateActivity(Activity newActivity)
        {
            if(ModelState.IsValid)
            {
                int? loggedIn = HttpContext.Session.GetInt32("logged_in");
                newActivity.UserId = (int)loggedIn;
                _context.Add(newActivity);
                _context.SaveChanges();
                return RedirectToAction("home");
            } else {
                return View("new"); 
            }
        }

        
        // Logout - GET
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
