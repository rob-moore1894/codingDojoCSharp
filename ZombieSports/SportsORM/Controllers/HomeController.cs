using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            //All Womens' Leagues
            ViewBag.WomensLeagues = _context.Leagues
                .Where(wl => wl.Name.Contains("Womens"))
                .ToList();
            // All Hockey Leagues
            ViewBag.allHockey = _context.Leagues
                .Where(h => h.Sport.Contains("Hockey"));
            // All Leagues that are not football
            ViewBag.notFootball = _context.Leagues
                .Where(nf => !nf.Sport.Contains("Football"));
            // All Leagues with "Conference"
            ViewBag.Conferences = _context.Leagues
                .Where(c => c.Name.Contains("Conference"));
            // All Leagues in Atlantic Region
            ViewBag.AtlanticRegion = _context.Leagues
                .Where(ar => ar.Name.Contains("Atlantic")); 
            // All Teams in Dallas
            ViewBag.DallasTeams = _context.Teams
                .Where(dallasTeams => dallasTeams.Location == "Dallas")
                .ToList();
            // All Teams named Raptors
            ViewBag.allRaptors = _context.Teams
                .Where(r => r.TeamName == "Raptors");
            // All Teams whose location includes "City"
            ViewBag.locCity = _context.Teams
                .Where(lc => lc.Location.Contains("City")); 
            // All Teams that start with T
            ViewBag.TNames = _context.Teams
                .ToList()
                .Where(h => h.TeamName[0] == 'T'); 
            // All Teams ordered by Alphabetical Location
            ViewBag.Alphabetical = _context.Teams.OrderBy(a => a.Location);
            // All Teams ordered by Reverse Alphabetical
            ViewBag.ReverseAlphabetical = _context.Teams.OrderByDescending(ra => ra.TeamName);
            // All Players named Cooper (First Name Alphabetical - just cuz)
            ViewBag.Coopers = _context.Players
                .Where(coop => coop.LastName == "Cooper")
                .OrderBy(a => a.FirstName);
            // All Players named Joshua
            ViewBag.Joshuas = _context.Players
                .Where(joshua => joshua.FirstName == "Joshua")
                .OrderBy(a => a.LastName);
            // All players last name Cooper, first name not Joshua
            ViewBag.CJ = _context.Players
                .Where(cj => cj.LastName == "Cooper" && cj.FirstName != "Joshua")
                .OrderBy(a => a.FirstName); 
            // All players with First Name "Alexander" or First Name "Wyatt"
            ViewBag.AW = _context.Players
                .Where(aw => aw.FirstName == "Alexander" || aw.FirstName == "Wyatt")
                .OrderBy(a => a.FirstName);
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}