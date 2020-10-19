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
            // All Womens' Leagues
            ViewBag.WomensLeagues = _context.Leagues
                .Where(wl => wl.Name.Contains("Womens"))
                .ToList();
            // All Hockey Leagues
            ViewBag.allHockey = _context.Leagues
                .Where(h => h.Sport.Contains("Hockey"));
            // All Leagues that are not football
            ViewBag.notFootball = _context.Leagues
                .Where(nf => !nf.Sport.Contains("Football"));
            // All Leauges with "Conference"
            ViewBag.Conferences = _context.Leagues
                .Where(c => c.Name.Contains("Conference"));
            // All Teams in Dallas
            ViewBag.DallasTeams = _context.Teams
                .Where(dallasTeams => dallasTeams.Location == "Dallas")
                .ToList();
            // All Players named Joshua
            ViewBag.Joshuas = _context.Players
                .Where(joshua => joshua.FirstName == "Joshua");
            // All Teams ordered by Alphabetical Location
            ViewBag.Alphabetical = _context.Teams.OrderBy(a => a.Location);
            // All Teams that start with T
            ViewBag.TNames = _context.Teams
                .ToList()
                .Where(h => h.TeamName[0] == 'T'); 
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