using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore; 
using OneToMany.Models;

namespace OneToMany.Controllers
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
            List<Octopus> AllOctopi = _context.Octopi.ToList();
            return View(AllOctopi);
        }

        [HttpGet("octopus/new")]
        public IActionResult NewOctopus()
        {
            return View();
        }

        [HttpPost("octopus/new/submit")]
        public IActionResult SaveOctopus(Octopus oct){
            if(ModelState.IsValid)
            {
                _context.Add(oct);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("NewOctopus"); 
            }
        }
        [HttpGet("octopus/{id}")]
        public IActionResult ShowOctopus(int id)
        {
            Octopus thisOctopus = _context.Octopi.Include(o => o.Tentacles).FirstOrDefault(oct => oct.OctopusId == id);
            return View(thisOctopus);
        }

        [HttpGet("tentacle/new")]
        public IActionResult NewTentacle()
        {
            ViewBag.AllOctopi = _context.Octopi.ToList();
            return View(); 
        }

        [HttpPost("tentacle/new/submit")]
        public IActionResult SaveTentacle(Tentacle tent)
        {
            if(ModelState.IsValid)
            {
                _context.Tentacles.Add(tent);
                _context.SaveChanges();
                return RedirectToAction("Index"); 
            } else {
                return View("NewTentacle");
            }
        }
    }
}
