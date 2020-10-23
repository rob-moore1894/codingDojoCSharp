using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BeltReviewLecture.Models;
using Microsoft.AspNetCore.Identity; 
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BeltReviewLecture.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
    
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            _context = context;
        }

        // Login and Register Page
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        // Logout - GET
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); 
            return RedirectToAction("Index");
        }

        // Post Request for Register
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
                return RedirectToAction("Dashboard");
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
                    return RedirectToAction("Dashboard");
                }
            } else {
                return View("Index"); 
            }
        }

        // Dashboard page for logged in user
        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            int? loggedIn = HttpContext.Session.GetInt32("logged_in");
            if(loggedIn == null)
            {
                return RedirectToAction("Index");
            } else {
                ViewBag.LoggedIn = _context.Users.Include(s => s.Commissions).FirstOrDefault(a => a.UserId == (int)loggedIn);
                ViewBag.Orders = _context.Orders.Include(d => d.Gig).Where(a => a.UserId == (int)loggedIn);
                ViewBag.Commissions = _context.Orders.Include(f => f.Gig).Where(h => h.Gig.UserId == (int)loggedIn);
                return View();
            }
        }
        
        //Add Gig - GET 
        [HttpGet("AddGig")]
        public IActionResult AddGig()
        {
            int? loggedIn = HttpContext.Session.GetInt32("logged_in");
            if(loggedIn == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        //Post Request for adding a gig
        [HttpPost("CreateGig")]
        public IActionResult CreateGig(Gig newGig)
        {
            if(ModelState.IsValid)
            {
                int? loggedIn = HttpContext.Session.GetInt32("logged_in");
                newGig.UserId = (int)loggedIn;
                _context.Add(newGig);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            } else {
                return View("AddGig");
            }
        }
        //Edit gig - GET
        [HttpGet("Edit/{GigId}")]
        public IActionResult Edit(int GigId)
        {
            ViewBag.Gig = _context.Gigs.FirstOrDefault(f => f.GigId == GigId);
            return View();
        }

        //Post Request for updating a gig
        [HttpPost("UpdateGig/{GigId}")]
        public IActionResult Update(Gig upGig, int GigId)
        {
            if(ModelState.IsValid)
            {
                Gig oldGig = _context.Gigs.FirstOrDefault(g => g.GigId == GigId);
                oldGig.Title = upGig.Title;
                oldGig.Description = upGig.Description;
                oldGig.Price = upGig.Price;
                oldGig.DeliveryTime = upGig.DeliveryTime;
                oldGig.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            ViewBag.Gig = _context.Gigs.FirstOrDefault(f => f.GigId == GigId);
            return View("Edit", GigId);
        }

        //View all gigs - GET
        [HttpGet("AllGigs")]
        public IActionResult AllGigs()
        {
            ViewBag.AllGigs = _context.Gigs.ToList();
            return View();
        }
        //View one gig - GET
        [HttpGet("Gig/{GigId}")]
        public IActionResult OneGig(int GigId)
        {
            int? loggedIn = HttpContext.Session.GetInt32("logged_in");
            if(loggedIn == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.OneGig = _context.Gigs.FirstOrDefault(s => s.GigId == GigId);
            ViewBag.User = loggedIn;
            return View();
        }
        //Post request for placing order

        [HttpPost("OrderGig")]
        public IActionResult OrderGig(OrderHistory newOrder)
        {
            if(newOrder.Request == null)
            {
                newOrder.Request = "No special request made";
            }
            _context.Add(newOrder);
            _context.SaveChanges();
            return RedirectToAction("Thanks");
        }
        //View "Thank you for order" Page - GET
        [HttpGet("Thanks")]
        public IActionResult Thanks()
        {
            return View();
        }

        // Delete Order - GET
        [HttpGet("Delete/{OrderId}")]
        public IActionResult Delete(int OrderId)
        {
            OrderHistory orderToDelete = _context.Orders.SingleOrDefault(a => a.OrderId == OrderId);
            _context.Orders.Remove(orderToDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}
