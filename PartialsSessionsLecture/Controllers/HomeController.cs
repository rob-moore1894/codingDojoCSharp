﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialsSessionsLecture.Models;

namespace PartialsSessionsLecture.Controllers
{
    public class HomeController : Controller
    {

        public static AllModels allmodels = new AllModels();

        [HttpGet("")]
        public IActionResult Index()
        { 
            return View("Index", allmodels);
        }

        [HttpPost("addDonut")]
        public PartialViewResult addDonut(Donut newDonut)
        {
            allmodels.AllDonuts.Add(newDonut);
            return PartialView("Index");
        }

        [HttpPost("addDrink")]
        public PartialViewResult addDrink(Drink newDrink)
        {
            allmodels.AllDrinks.Add(newDrink);
            return PartialView("Index");
        }

    }
}
