﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ValidLecture.Models;

namespace ValidLecture.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("success")]
        public IActionResult Success(){
            return View();
        }

        [HttpPost("submit")]
        public IActionResult Submit(CampingTrip trip){
            if(ModelState.IsValid){
                return RedirectToAction("Success");
            }
            else {
                ViewBag.Name = trip.Name;
                ViewBag.StartDate = trip.StartDate;
                ViewBag.EndDate = trip.EndDate;
                ViewBag.Location = trip.Location;
                ViewBag.BearProtection = trip.BearProtection; 
                return View("Index");
            }
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
